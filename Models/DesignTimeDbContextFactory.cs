using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace University_Registrar.Models
{
  public class University_RegistrarContextFactory : IDesignTimeDbContextFactory<University_RegistrarContext>
  {

    University_RegistrarContext IDesignTimeDbContextFactory<University_RegistrarContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<University_RegistrarContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new University_RegistrarContext(builder.Options);
    }
  }
}