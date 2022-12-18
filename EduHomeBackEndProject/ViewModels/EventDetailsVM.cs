using EduHomeBackEndProject.Models;
using System.Collections.Generic;

namespace EduHomeBackEndProject.ViewModels
{
    public class EventDetailsVM
    {
        public Event Events { get; set; }
        public List<EventSpeaker> EventSpeakers { get; set; }
        public List<Speaker> Speakers { get; set; }
    }
}
