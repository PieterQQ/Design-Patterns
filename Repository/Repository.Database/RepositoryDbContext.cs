using Microsoft.EntityFrameworkCore;
using Repository.Database.Entities;

namespace Repository.Database
{
    public class RepositoryDbContext : DbContext
    {
        public RepositoryDbContext(DbContextOptions options):base(options)
        {
   
        }
        public DbSet<Settings> settings { get; set; }
    }
}
