using EduHomeProject.Models;
using System.ComponentModel.DataAnnotations;

namespace EduHomeBackEndProject.Models
{
    public class CourseFeature : BaseEntity
    {
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        [StringLength(maximumLength: 50)]
        public string Value { get; set; }
        public int CourseId { get; set; }
        public Course Courses { get; set; }
    }
}
