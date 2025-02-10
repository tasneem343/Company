using Company.DAL.Entities;
using Microsoft.EntityFrameworkCore;


namespace Company.DAL.DataBase
{
    public class ApplicationDBcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=DESKTOP-30D9VAR;Database=CompanyNTier;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
