using Microsoft.EntityFrameworkCore;
using WebCRUD.Models.Entities;

namespace WebCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        
    }
}
