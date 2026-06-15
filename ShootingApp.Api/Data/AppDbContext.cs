using Microsoft.EntityFrameworkCore;
using ShootingApp.Api.Models;

namespace ShootingApp.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ShootingSession> Sessions { get; set; }
    }
}