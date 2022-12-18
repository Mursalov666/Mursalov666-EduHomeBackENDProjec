using EduHomeProject.Models;
using System.ComponentModel.DataAnnotations;

namespace EduHomeBackEndProject.Models
{
    public class Tag : BaseEntity
    {
        [Required(ErrorMessage = "Enter tag name!")]
        [StringLength(maximumLength: 30)]
        public string Name { get; set; }
    }
}
