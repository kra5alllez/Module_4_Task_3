using Microsoft.EntityFrameworkCore;
using Module_4_Task_3_Vasylchenko.Entities;
using Module_4_Task_3_Vasylchenko.EntityConfigurations;

namespace Module_4_Task_3_Vasylchenko
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Title> Titels { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeeProject { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfigurations());
            modelBuilder.ApplyConfiguration(new OfficeConfigurations());
            modelBuilder.ApplyConfiguration(new ProjectConfigurations());
            modelBuilder.ApplyConfiguration(new TitelConfigurations());
        }
    }
}
