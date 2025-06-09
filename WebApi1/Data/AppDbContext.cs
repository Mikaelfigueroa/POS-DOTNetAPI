using Microsoft.EntityFrameworkCore;
using WebApi.Models;
//here you are attaching the models to the db context
namespace WebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
