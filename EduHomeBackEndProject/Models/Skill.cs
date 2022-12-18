using EduHomeProject.Models;
using System.ComponentModel.DataAnnotations;

namespace EduHomeBackEndProject.Models
{
    public class Skill : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 60)]
        public string Name { get; set; }
    }
}
