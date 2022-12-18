using EduHomeProject.Models;
using System.ComponentModel.DataAnnotations;

namespace EduHomeBackEndProject.Models
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 100)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Surname { get; set; }
        public int BlogId { get; set; }
    }
}
