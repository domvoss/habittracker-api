using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace HabitTracker.Infrastructure.Persistence
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            // Set up configuration to pull from appsettings and user secrets
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  // Set to project folder
                .AddJsonFile("appsettings.json", optional: true)  // Optional to keep it clean
                .AddJsonFile("appsettings.Development.json", optional: true)
                .AddEnvironmentVariables()
                .AddUserSecrets(Assembly.Load("HabitTracker.API"))
                .AddEnvironmentVariables()
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}