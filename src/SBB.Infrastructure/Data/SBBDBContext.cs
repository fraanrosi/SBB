using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SBB.Core.Entities;

namespace SBB.Infrastructure.Data;

public class SBBDBContext : DbContext
{
    public SBBDBContext(DbContextOptions<SBBDBContext> options) : base(options)
    {
    }
    public SBBDBContext() 
    { 
    }

    public DbSet<User> Users{ get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
