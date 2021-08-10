using Microsoft.EntityFrameworkCore;
using TaskOrganizorDBSeeder.Models;

namespace TaskOrganizorDBSeeder
{
    public class TaskOrganizorDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(AppConfig.ToConnectionString());
        }
        
        public DbSet<Task> Tasks { get; set; }
        
    }
}