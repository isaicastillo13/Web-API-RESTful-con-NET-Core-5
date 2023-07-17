using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;

namespace ProductsAPI.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet <Product> Products { get; set; }

    }
}
