using Domain.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistence.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

    // Tables
    public virtual DbSet<Car> Cars { get; set; }
    public virtual DbSet<Gallery> Galleries { get; set; }
    public virtual DbSet<User> Users { get; set; }

}
