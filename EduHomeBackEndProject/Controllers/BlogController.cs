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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Blog> blogs = await _context.Blogs.Where(b => b.IsDeleted == false).ToListAsync();


            return View(blogs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            BlogDetailsVM blogDetailsVM = new BlogDetailsVM
            {
                Blogs = await _context.Blogs.Where(b => b.IsDeleted == false).FirstOrDefaultAsync(b => b.Id == id)
            };

            return View(blogDetailsVM);
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
