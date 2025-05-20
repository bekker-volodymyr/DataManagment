using EFCoreIntro.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreIntro
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EfDemoDb;");
        }
    }
}
