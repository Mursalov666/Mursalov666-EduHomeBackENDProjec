using EduHomeProject.Models;

namespace EduHomeBackEndProject.Models
{
    public class TeachersSkill : BaseEntity
    {
        public int TeacherId { get; set; }
        public int SkillId { get; set; }
    }
}
