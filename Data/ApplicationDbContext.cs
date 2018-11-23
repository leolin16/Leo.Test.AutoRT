using Microsoft.EntityFrameworkCore;

namespace Leo.Test.AutoRT.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Screen> Screens { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            Database.Migrate();
        }
    }
}