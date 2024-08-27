using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Model;

namespace UniversityManagementSystem.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
