// ApplicationDbContext.cs

using Microsoft.EntityFrameworkCore;

namespace testeKeevo.Data
{
    public class ApplicationDbContext : DbContext
    {
                            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                    => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=keevo;Username=postgres;Password=Dragoon@182811");
       public DbSet<Task> Tasks { get; set; }
    }


}
