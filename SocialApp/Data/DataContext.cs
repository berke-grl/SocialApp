using Microsoft.EntityFrameworkCore;
using SocialApp.Entities;

namespace SocialApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AppUser>().HasData(
        //            new AppUser() { Id = 1, UserName = "John" },
        //            new AppUser() { Id = 2, UserName = "Smith" },
        //            new AppUser() { Id = 3, UserName = "Leo" }
        //        );
        //}
    }
}
