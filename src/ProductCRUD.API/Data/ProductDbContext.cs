using Microsoft.EntityFrameworkCore;
using ProductCRUD.API.Models;

namespace ProductCRUD.API.Data
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }
    }
}
