using Microsoft.EntityFrameworkCore;

namespace Lasmart.DotService.Backend;

public class DotContext : DbContext
{
    protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "DotServiceDB");
    }

    public DbSet<Dot> Dots { get; set; }
    public DbSet<Comment> Comments { get; set; }
}