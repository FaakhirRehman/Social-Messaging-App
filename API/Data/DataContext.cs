using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext // This will be used as a service
    {
        // Constructor
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<AppUser> Users { get; set; } // Our Table Name will be "Users" and the coloumns are going to be from the AppUser Class
    }
}