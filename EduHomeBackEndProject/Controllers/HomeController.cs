using EduHomeBackEndProject.ViewModels;
using EduHomeProject.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBackEndProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Settings = await _context.Settings.Where(s => s.IsDeleted == false).ToListAsync(),
                Events = await _context.Events.Where(e => e.IsDeleted == false).ToListAsync(),
                Courses = await _context.Courses.Where(c => c.IsDeleted == false).ToListAsync(),
                Teachers = await _context.Teachers.Where(t => t.IsDeleted == false).ToListAsync(),
                Blogs = await _context.Blogs.Where(b => b.IsDeleted == false).ToListAsync(),
                Tags = await _context.Tags.Where(t => t.IsDeleted == false).ToListAsync()
            };

            return View(homeVM);
        }
    }
}
