using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCompany1.Models;

namespace MyCompany1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}
        public virtual DbSet<Department> Departments => Set<Department>();
        public virtual DbSet<Employee> Employees => Set<Employee>();
    }
}