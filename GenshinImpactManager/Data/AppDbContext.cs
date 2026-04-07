using Microsoft.EntityFrameworkCore;
using GenshinImpactManager.Models;

namespace GenshinImpactManager.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Character> Characters { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Character>().HasData(
            new Character { Id = 1, Name = "Hu Tao", Element = "Pyro", Rarity = 5 },
            new Character { Id = 2, Name = "Venti", Element = "Anemo", Rarity = 5 },
            new Character { Id = 3, Name = "Xingqiu", Element = "Hydro", Rarity = 4 }
        );
    }
}