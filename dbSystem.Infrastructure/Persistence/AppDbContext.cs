using Microsoft.EntityFrameworkCore;
using dbSystem.Domain.Entities;

namespace dbSystem.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("users");
        modelBuilder.Entity<User>().HasKey(u => u.id);
        modelBuilder.Entity<User>().Property(u => u.email).IsRequired();
    }
}
