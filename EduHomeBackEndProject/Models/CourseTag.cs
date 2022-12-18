using EduHomeProject.Models;

namespace EduHomeBackEndProject.Models
{
    public class CourseTag : BaseEntity
    {
        public int CourseId { get; set; }
        public int TagId { get; set; }
    }
}
