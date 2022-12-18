using EduHomeProject.Models;
using System.ComponentModel.DataAnnotations;

namespace EduHomeBackEndProject.Models
{
    public class Position : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 70)]
        public string Name { get; set; }
    }
}
