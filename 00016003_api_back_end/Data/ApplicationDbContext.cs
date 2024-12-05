using Microsoft.EntityFrameworkCore;
using _00016003_api_back_end.Models;
namespace _00016003_api_back_end.Data
{
    // 00016003
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Newspaper> Newspapers { get; set; } // Table for newspapers
    }
}
// 00016003