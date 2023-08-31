using Microsoft.EntityFrameworkCore;

namespace Entities;

public class DatabaseContext : DbContext
{
    public DbSet<Entities.User> Users { get; set; }
    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(builder =>
        {
            builder.ToTable("Tb_User");
            builder.HasIndex(x => x.Email).IsUnique();
        });

        modelBuilder.Entity<SaleItem>(builder =>
        {
            builder.ToTable("Tb_SaleItem");
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
            builder.HasIndex(x=>x.Name).IsUnique();
        });

        modelBuilder.Entity<ShoppingCard>(builder =>
        {
            builder.ToTable("Tb_ShoppingCard");
            builder.Property(p => p.TotalAmount).HasColumnType("decimal(18,2)");
        });

        modelBuilder.Entity<ShoppingCardDetail>(builder =>
        {
            builder.ToTable("Tb_ShoppingCardDetail");
            builder.Property(p => p.Fee).HasColumnType("decimal(18,2)");
            builder.Property(p => p.TotalAmount).HasColumnType("decimal(18,2)");
            builder.HasIndex(x => new { x.ShoppingCardId, x.SaleItemId }).IsUnique();
        });
    }
}