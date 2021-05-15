 using BackEndProject.DAL;
using BackEndProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProject.ViewComponents
{
    public class CourseViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public CourseViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Course> course = _context.Courses.Take(take).ToList();
            return View(await Task.FromResult(course));
        }
    }
}
