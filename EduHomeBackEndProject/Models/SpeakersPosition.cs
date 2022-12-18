using EduHomeProject.Models;

namespace EduHomeBackEndProject.Models
{
    public class SpeakersPosition : BaseEntity
    {
        public int SpeakerId { get; set; }
        public int PositionId { get; set; }
    }
}
