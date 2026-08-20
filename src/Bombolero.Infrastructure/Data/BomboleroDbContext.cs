using Microsoft.EntityFrameworkCore;
using Bombolero.Core.Entities;

namespace Bombolero.Infrastructure.Data;

public class BomboleroDbContext : DbContext
{
    public BomboleroDbContext(DbContextOptions<BomboleroDbContext> options)
        : base(options)
    {
        
    }
    
    public DbSet<Ingredient> Ingredients { get; set; }
}