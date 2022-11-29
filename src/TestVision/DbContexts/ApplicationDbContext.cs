using Microsoft.EntityFrameworkCore;
using TestVisionAPI.Models;

namespace TestVisionAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<TestDetails> TestsDetails { get; set; }
    }
}
