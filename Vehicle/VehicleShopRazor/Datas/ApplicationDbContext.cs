using Microsoft.EntityFrameworkCore;
using VehicleShopRazor.NewFolder;

namespace VehicleShopRazor.Datas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        }

        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                 new Category { Id=1,Name="test1",DisplayOrder=1},
                 new Category { Id = 2, Name = "test2", DisplayOrder = 2 },
                new Category { Id = 3, Name = "test3", DisplayOrder = 3 }
                );
        }
    }
}
