using EduHomeProject.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace EduHomeBackEndProject.Models
{
    public class Blog : BaseEntity
    {
        public string Image { get; set; }
        [Required]
        [StringLength(maximumLength: 250)]
        public string Title { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(maximumLength: 1000)]
        public string Description { get; set; }
    }
}
