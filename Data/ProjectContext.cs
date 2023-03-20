using Microsoft.EntityFrameworkCore;
using re2023_api.Data.Models;

namespace re2023_api.Data
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Data.Models.Project> Projects { get; set; }
        public DbSet<Data.Models.Event> Events { get; set; }
        public DbSet<Data.Models.Task> Tasks { get; set; }
    }
}
