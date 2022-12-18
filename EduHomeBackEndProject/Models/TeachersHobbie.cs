using EduHomeProject.Models;

namespace EduHomeBackEndProject.Models
{
    public class TeachersHobbie : BaseEntity
    {
        public int TeacherId { get; set; }
        public int HobbieId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
