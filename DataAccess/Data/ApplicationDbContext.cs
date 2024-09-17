using Microsoft.EntityFrameworkCore;
using Business.Entities;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employes { get; set; }
    }
}
