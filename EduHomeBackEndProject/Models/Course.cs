using EduHomeProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHomeBackEndProject.Models
{
    public class Course : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 70)]
        public string CourseName { get; set; }

        public string CourseImage { get; set; }

        public DateTime Time { get; set; }
        [Required]
        [StringLength(maximumLength: 500)]
        public string Description { get; set; }
        [Required]
        [StringLength(maximumLength: 500)]
        public string AboutCourseInfo { get; set; }
        [Required]
        [StringLength(maximumLength: 500)]
        public string HowToApplyInfo { get; set; }
        [Required]
        [StringLength(maximumLength: 500)]
        public string CertificationInfo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public List<CourseFeature> CourseFeatures { get; set; }

    }
}
