using CQRSStudy.BusinessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSStudy.BusinessLayer
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=CRQSStudyDb;Integrated Security=True;Trust Server Certificate=True");
        }
        public DbSet<Product> Products { get; set; }
    }
}
