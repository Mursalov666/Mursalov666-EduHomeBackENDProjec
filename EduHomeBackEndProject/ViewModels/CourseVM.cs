using EduHomeBackEndProject.Models;
using EduHomeProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeBackEndProject.ViewModels
{
    public class CourseVM
    {
        public List<Setting> Settings { get; set; }
        public List<Event> Events { get; set; }
        public Course Courses { get; set; }
        public CourseFeature CourseFeatures { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Tag> Tags { get; set; }


    }
}
