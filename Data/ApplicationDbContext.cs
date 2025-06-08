using Microsoft.EntityFrameworkCore;
using ProjectBoardApp.Models; // Assuming your models will be in the Models folder

namespace ProjectBoardApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define your DbSet properties for your models
        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; } // We'll create TaskItem later

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // You can add fluent API configurations here if needed
        }
    }
}