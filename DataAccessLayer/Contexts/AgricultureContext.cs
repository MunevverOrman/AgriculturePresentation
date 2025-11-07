using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Contexts
{
    public class AgricultureContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-I05VV5A;database=DbAgriculture;integrated security=true");
        }

        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
       
    }
}
