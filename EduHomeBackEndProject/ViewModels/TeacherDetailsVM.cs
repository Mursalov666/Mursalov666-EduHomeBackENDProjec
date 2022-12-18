using EduHomeBackEndProject.Models;
using System.Collections.Generic;

namespace EduHomeBackEndProject.ViewModels
{
    public class TeacherDetailsVM
    {
        public Teacher Teachers { get; set; }
        public List<TeachersHobbie> TeachersHobbies { get; set; }
        public List<Hobbie> Hobbie { get; set; }
    }
}
