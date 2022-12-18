using EduHomeProject.Models;

namespace EduHomeBackEndProject.Models
{
    public class About : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string AboutImage { get; set; }
        public string Notice { get; set; }
        public string Date { get; set; }
    }
}
