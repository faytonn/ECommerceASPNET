using ECommerceBackendASPNET.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceBackendASPNET.DataAccessLayer
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Footer> Footers { get; set; }
    }
}
