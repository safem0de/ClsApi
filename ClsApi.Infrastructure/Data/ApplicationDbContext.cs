

using System.Data.Common;
using ClsApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClsApi.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}