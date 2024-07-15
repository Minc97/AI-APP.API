using Microsoft.EntityFrameworkCore;

namespace AI_App.API.Models;

public partial class SampleDBContext : DbContext
{
    public SampleDBContext(DbContextOptions<SampleDBContext> options) : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity => { entity.HasKey(k => k.CustomerId); });
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}