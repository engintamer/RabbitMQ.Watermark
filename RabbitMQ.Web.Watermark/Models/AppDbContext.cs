using Microsoft.EntityFrameworkCore;

namespace RabbitMQ.Web.Watermark.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
