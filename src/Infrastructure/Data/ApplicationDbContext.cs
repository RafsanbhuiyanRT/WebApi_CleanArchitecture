using Domain.Entity.Category;
using Domain.Entity.Product;
using Domain.Entity.Student;
using Domain.Entity.SubCategory;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Products> Products => Set<Products>();
    public DbSet<Categories> Categories => Set<Categories>();
    public DbSet<SubCategories> SubCategories { get; set; }
    public DbSet<Students> Students { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
