using BackEndProject.DAL;
using BackEndProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialMediaController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public SocialMediaController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Teacher> teachers = _context.Teachers.Include(t => t.Socials).ToList();
            return View(teachers);
        }
        public IActionResult Create()
        {
            ViewBag.TeacherList = _context.Teachers.ToList();
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Social social)
        {
            ViewBag.TeacherList = _context.Teachers.ToList();
            if (!ModelState.IsValid) return View();
            await _context.Socials.AddAsync(social);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
