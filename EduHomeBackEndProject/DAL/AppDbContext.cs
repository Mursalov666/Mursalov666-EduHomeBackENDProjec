using Microsoft.EntityFrameworkCore;
using EduHomeProject.Models;
using EduHomeBackEndProject.Models;

namespace EduHomeProject.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseFeature> CourseFeatures { get; set; }
        public DbSet<CourseTag> CourseTags { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventSpeaker> EventSpeakers { get; set; }
        public DbSet<Hobbie> Hobbies { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<SpeakersPosition> SpeakersPositions { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeachersHobbie> TeachersHobbies { get; set; }
        public DbSet<TeachersSkill> TeachersSkills { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<About> Abouts { get; set; }

    }
}
