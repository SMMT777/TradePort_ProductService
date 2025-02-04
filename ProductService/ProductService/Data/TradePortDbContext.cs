using Microsoft.EntityFrameworkCore;
using ProductService.Models;

public class TradePortDbContext : DbContext
{
    public TradePortDbContext(DbContextOptions<TradePortDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; } // Example entity

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-8R14CKQ3\\SQLEXPRESS;Database=TradePortDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
