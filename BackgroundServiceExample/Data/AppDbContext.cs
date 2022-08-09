using BackgroundServiceExample.Models;
using Microsoft.EntityFrameworkCore;

namespace BackgroundServiceExample.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<BackgroundProccess> BackgroundProccesses { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
