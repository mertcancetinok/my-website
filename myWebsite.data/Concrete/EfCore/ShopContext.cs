using Microsoft.EntityFrameworkCore;
using myWebsite.entity;

namespace myWebsite.data.Concrete.EfCore
{
    public class ShopContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<SocialMedia> SocialMediae{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=user.db");
        }
        
        
    }
}