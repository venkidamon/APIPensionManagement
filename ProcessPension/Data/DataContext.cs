using Microsoft.EntityFrameworkCore;
using ProcessPension.Entities;

namespace ProcessPension.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppProcessPension> appProcessPensions { get; set; }
    }
}
