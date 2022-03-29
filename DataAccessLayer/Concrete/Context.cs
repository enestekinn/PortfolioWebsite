using EntityLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=localhost;database=PortfolioWebsite;integrated security=false;User=sa;Password=root.ROOT1");
        }
        public DbSet<About>  Abouts { get; set; }
        public DbSet<Conctact>  Conctacts { get; set; }
        public DbSet<Feature>  Features { get; set; }
        public DbSet<Message>  Messages { get; set; }
        public DbSet<Portfolio>  Portfolios { get; set; }
        public DbSet<Service>  Services { get; set; }
        public DbSet<Skill>  Skills { get; set; }
        public DbSet<SocialMedia>  SocialMedias { get; set; }
        public DbSet<Testimonial>  Testimonials { get; set; }
    }
}