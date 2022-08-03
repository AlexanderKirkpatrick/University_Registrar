using Microsoft.EntityFrameworkCore;

namespace University_Registrar.Models
{
  public class University_RegistrarContext : DbContext
  {
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<CourseStudent> CourseStudent { get; set; }
    public DbSet<DepartmentStudent> DepartmentStudent { get; set; }

    public University_RegistrarContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    optionsBuilder.UseLazyLoadingProxies();
    }
  }
}