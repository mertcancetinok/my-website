using Microsoft.EntityFrameworkCore;
using myWebsite.entity;

namespace myWebsite.data.Concrete.EfCore
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Portfolyo> Portfolyos { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }

       

    }
}