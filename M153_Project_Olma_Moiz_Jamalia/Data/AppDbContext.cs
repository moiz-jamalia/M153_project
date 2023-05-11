using M153_Project_Olma_Moiz_Jamalia.Models;
using Microsoft.EntityFrameworkCore;

namespace M153_Project_Olma_Moiz_Jamalia.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserStore> UserStores { get; set; }

        public DbSet<AdminStore> AdminStores { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
