using EduHomeBackEndProject.Models;
using EduHomeBackEndProject.ViewModels;
using EduHomeProject.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Event> events = await _context.Events.Where(b => b.IsDeleted == false).ToListAsync();


            return View(events);
        }

        public async Task<IActionResult> Detail(int id)
        {
            EventDetailsVM eventDetailsVM = new EventDetailsVM
            {
                //Courses = await _context.Courses.Include(c => c.CourseFeatures).FirstOrDefaultAsync(c => c.Id == id),
                //CourseFeatures = await _context.CourseFeatures.Include(cf => cf.Courses).Where(cf => cf.CourseId == id).Where(s => s.IsDeleted == false).FirstOrDefaultAsync(),

                Events = await _context.Events.Include(e => e.EventSpeakers).Where(e => e.IsDeleted == false).FirstOrDefaultAsync(e => e.Id == id),
                EventSpeakers = await _context.EventSpeakers.Include(es => es.Event).Where(es => es.EventId == id).Where(e => e.IsDeleted == false).ToListAsync(),
                Speakers = await _context.Speakers.Include(s => s.EventSpeakers).ThenInclude(es => es.Event).Where(s => s.Id == id).ToListAsync()
            };

            return View(eventDetailsVM);
        }

        public IActionResult LeftBar()
        {
            return View();
        }

        public IActionResult RightBar()
        {
            return View();
        }
    }
}
