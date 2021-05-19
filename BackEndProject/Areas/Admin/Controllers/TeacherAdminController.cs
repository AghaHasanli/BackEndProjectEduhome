using BackEndProject.DAL;
using BackEndProject.Extentions;
using BackEndProject.Helpers;
using BackEndProject.Models;
using BackEndProject.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeacherAdminController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public TeacherAdminController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Teacher> Teachers = _context.Teachers.Include(t=>t.TeacherDetail).Include(t=>t.Socials).ToList();
            return View(Teachers);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Teacher teacher)
        {
            if (!ModelState.IsValid) return View();

            if (!teacher.Photo.IsValidType("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image Type");
                return View();
            }
            if (!teacher.Photo.IsValidSize(300))
            {
                ModelState.AddModelError("Photo", "Please select image Size less than kb");
                return View();
            }
            string path = Path.Combine("img", "teacher");
            teacher.ImageUrl = await teacher.Photo.SaveFileAsync(_env.WebRootPath, path);

            teacher.TeacherDetail.Teacher = teacher;
            teacher.TeacherDetail.TeacherId = teacher.Id;

            await _context.AddRangeAsync(teacher, teacher.TeacherDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacherdb = _context.Teachers.Include(t => t.TeacherDetail).Include(t => t.Socials).FirstOrDefault(t => t.Id == id);
            if (teacherdb == null) return NotFound();
            TeacherVM teacherVM = new TeacherVM
            {
                Teacher = teacherdb,
                TeacherDetail = teacherdb.TeacherDetail
            };
            return View(teacherVM);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Teacher teacher)
        {
            if (id == null) return NotFound();
            if (!ModelState.IsValid) return NotFound();

            Teacher teacherDb = _context.Teachers.Include(t => t.TeacherDetail).FirstOrDefault(t => t.Id == id);
            if (teacherDb == null) return NotFound();
            if (!teacher.Photo.IsValidType("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image Type");
                return View(teacherDb);
            }
            if (!teacher.Photo.IsValidSize(300))
            {
                ModelState.AddModelError("Photo", "Please select image Size less than kb");
                return View(teacherDb);
            }
            string path = Path.Combine("img", "teacher");
            Helper.DeletedFile(_env.WebRootPath, path, teacherDb.ImageUrl);
            path = Path.Combine("img", "teacher");
            teacherDb.ImageUrl = await teacher.Photo.SaveFileAsync(_env.WebRootPath, path);
            teacherDb.FullName = teacher.FullName;
            teacherDb.Position = teacher.Position;
            teacherDb.TeacherDetail.AboutMe = teacher.TeacherDetail.AboutMe;
            teacherDb.TeacherDetail.Degree = teacher.TeacherDetail.Degree;
            teacherDb.TeacherDetail.Exprience = teacher.TeacherDetail.Exprience;
            teacherDb.TeacherDetail.Hobbies = teacher.TeacherDetail.Hobbies;
            teacherDb.TeacherDetail.Faculty = teacher.TeacherDetail.Faculty;
            teacherDb.TeacherDetail.MailMe = teacher.TeacherDetail.MailMe;
            teacherDb.TeacherDetail.MakeACall = teacher.TeacherDetail.MakeACall;
            teacherDb.TeacherDetail.Skype = teacher.TeacherDetail.Skype;
            teacherDb.TeacherDetail.Language = teacher.TeacherDetail.Language;
            teacherDb.TeacherDetail.Design = teacher.TeacherDetail.Design;
            teacherDb.TeacherDetail.TeamLeader = teacher.TeacherDetail.TeamLeader;
            teacherDb.TeacherDetail.Innovation = teacher.TeacherDetail.Innovation;
            teacherDb.TeacherDetail.Development = teacher.TeacherDetail.Development;
            teacherDb.TeacherDetail.Communication = teacher.TeacherDetail.Communication;

            _context.Update(teacherDb);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }

}

