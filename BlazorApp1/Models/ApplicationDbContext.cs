using Microsoft.EntityFrameworkCore;
using BlazorApp1.Models;

namespace BlazorApp1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define table properties for each entity (everything in models folder)
        public DbSet<User> Users { get; set; }
        public DbSet<Books> Books { get; set; }
    }
}