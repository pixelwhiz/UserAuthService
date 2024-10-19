using Microsoft.EntityFrameworkCore;

namespace UserAuthService.entity
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        public DbSet<Users> Users { get; set; } = null!;
    }
}