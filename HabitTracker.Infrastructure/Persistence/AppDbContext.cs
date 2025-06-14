using Microsoft.EntityFrameworkCore;
using HabitTracker.Domain.Entities;

namespace HabitTracker.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<HabitTask> HabitTasks { get; set; }
    }
}