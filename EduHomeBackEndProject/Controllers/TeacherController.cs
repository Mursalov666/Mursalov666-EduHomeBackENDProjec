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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Teacher> teachers = await _context.Teachers.Where(t => t.IsDeleted == false).ToListAsync();


            return View(teachers);
        }
        public async Task<IActionResult> Detail(int id)
        {
            TeacherDetailsVM teacherDetailsVM = new TeacherDetailsVM
            {
                Teachers = await _context.Teachers.Include(t => t.TeachersHobbies).Where(t => t.IsDeleted == false).FirstOrDefaultAsync(t => t.Id == id)
            };

            return View(teacherDetailsVM);
        }
    }
}
