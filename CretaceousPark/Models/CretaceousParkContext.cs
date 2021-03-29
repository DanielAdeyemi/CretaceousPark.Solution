using Microsoft.EntityFrameworkCore;

namespace CretaceousPark.Models
{
  public class CretaceousParkContext : DbContext
  {
    public CretaceousParkContext(DbContextOptions<CretaceousParkContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }
  }
}