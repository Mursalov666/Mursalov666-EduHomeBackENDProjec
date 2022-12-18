using EduHomeProject.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduHomeBackEndProject.Models
{
    public class Speaker : BaseEntity
    {
        [StringLength(maximumLength: 255)]
        public string Image { get; set; }
        [Required]
        [StringLength(maximumLength: 70)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 70)]
        public string Surname { get; set; }
        public List<EventSpeaker> EventSpeakers { get; set; }
    }
}
