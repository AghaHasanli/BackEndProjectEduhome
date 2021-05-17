using BackEndProject.DAL;
using BackEndProject.Extentions;
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
    public class EventAdminController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public EventAdminController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Event> Event = _context.Events.Include(e => e.EventDetail).Include(e => e.EventSpeakers).ThenInclude(e => e.Speaker).ToList();
            return View(Event);
        }
        public IActionResult Create()
        {
            ViewBag.Speakers = _context.Speakers.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventVM eventVM)
        {
            ViewBag.Speakers = _context.Speakers.ToList();


            if (!ModelState.IsValid) return View();

            {
                ModelState.AddModelError("", "Please Select Speakers");
                return View();
            }
            if (!eventVM.Event.Photo.IsValidType("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image Type");
            }
            if (!eventVM.Event.Photo.IsValidSize(300))
            {
                ModelState.AddModelError("Photo", "Please select image Size less than kb");
            }
            string path = Path.Combine("img", "event");
            eventVM.Event.ImageUrl = await eventVM.Event.Photo.SaveFileAsync(_env.WebRootPath, path);

            Event Event = eventVM.Event;
            EventDetail eventDetail = eventVM.EventDetail;

            eventDetail.Event = Event;
            eventDetail.Id = Event.Id;

            List<Speaker> speakers = new List<Speaker>();
            foreach (int sp in eventVM.Speakers)
            {
                Speaker speaker = new Speaker { Id = sp };
                speakers.Add(speaker);
            }

            List<EventSpeaker> EventSpeaker = new List<EventSpeaker>();
            foreach (EventSpeaker es in EventSpeaker)
            {
                es.Event = Event;
                es.EventId = Event.Id;
                foreach (Speaker s in speakers)
                {
                    es.Speaker = s;
                    es.SpeakerId = s.Id;
                }

            }
            await _context.AddRangeAsync(Event, eventDetail, speakers, EventSpeaker);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }
    }
}
