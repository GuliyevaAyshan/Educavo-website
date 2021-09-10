using EduCavoFinal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EduCavoFinal.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<ContactToTeam> ContactToTeam { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillToTeam> SkillToTeams { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<SocialToTeam> SocialToTeams { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Categories> Categories { get; set; }         
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SkillLevel> SkillLevels { get; set; }
        public DbSet<PriceLevel> PriceLevels { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CourseTypes> CourseTypes { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<FaqTitles> FaqTitles { get; set; }
        public DbSet<FaqToCourse> FaqToCourses { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<OfferState> OfferStates { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ErrorPage> Errors { get; set; }
        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<TeamToCourses> TeamToCourses { get; set; }
        public DbSet<Subscribe> Subscribe { get; set; }
        public DbSet<StudentsFeedback> StudentsFeedbacks { get; set; }
        public DbSet<DurationTime> DurationTimes { get; set; }
        public DbSet<Curriculum> Curriculum { get; set; }
        public DbSet<CurriculumTitles> CurriculumTitles { get; set; }
    
    }
}
