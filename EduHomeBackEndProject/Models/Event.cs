using EduHomeProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduHomeBackEndProject.Models
{
    public class Event : BaseEntity
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 1000)]
        public string Description { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime FinishTime { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Venue { get; set; }

        public List<EventSpeaker> EventSpeakers { get; set; }
    }
}
