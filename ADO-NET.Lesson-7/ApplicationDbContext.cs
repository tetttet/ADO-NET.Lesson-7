using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoNS;
public class ApplicationDbContext : DbContext {
  public ApplicationDbContext() {
    Database.EnsureDeleted();
    Database.EnsureCreated();
  }

  public DbSet<Author> Authors { get; set; }
  public DbSet<Location> Locations { get; set; }
  public DbSet<City> Cities { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
    if (!optionsBuilder.IsConfigured) {
      optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
  }
}
