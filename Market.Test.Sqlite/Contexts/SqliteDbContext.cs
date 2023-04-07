using Market.Test.Sqlite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Market.Test.Sqlite.Contexts
{
  // https://blog.devart.com/best-practices-in-using-the-dbcontext-in-ef-core.html

  // https://learn.microsoft.com/tr-tr/dotnet/navigate/data-access/

  // https://learn.microsoft.com/tr-tr/ef/core/get-started/winforms


  public class SqliteDbContext : DbContext
  {
    private readonly string _connectionString;


    public DbSet<Yazar> Yazarlar { get; set; }
    public DbSet<Yayinevi> Yayinevleri { get; set; }
    public DbSet<Kitap> Kitaplar { get; set; }


    //public SqliteDbContext(string connectionString) : base()
    public SqliteDbContext(string connectionString)
    {
      _connectionString = connectionString;

      // Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite(_connectionString);

      //ServiceLifetime.Transient

      //optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
      //optionsBuilder.EnableSensitiveDataLogging(false);   
    }


    //public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
    public override int SaveChanges()
    {
      ChangeTracker.DetectChanges();

      var entries = ChangeTracker.Entries();

      // SetBaseObjectValues(entries, string.Empty);
      SetBaseObjectValues(entries, "Admin");
      //return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
      return base.SaveChanges();
    }
    //private void SetBaseObjectValues(IEnumerable<EntityEntry> entries, string userName)
    private void SetBaseObjectValues(IEnumerable<EntityEntry> entries, string userName)
    {
      foreach (var entry in entries)
      {
        if (entry.Entity is BaseObject trackable)
        {
          var now = DateTime.Now;

          switch (entry.State)
          {
            case EntityState.Modified:
              trackable.LastModifiedOn = now;
              trackable.LastModifiedBy = userName;
              break;

            case EntityState.Added:
              trackable.CreatedOn = now;
              trackable.LastModifiedOn = now;
              trackable.CreatedBy = userName;
              trackable.LastModifiedBy = userName;
              trackable.IsActive = true;
              trackable.IsDeleted = false;
              break;
          }
        }
      }
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Yazar>().HasData(
          new Yazar { Id = 1, Ad = "Ali", Soyad = "Veli", IsActive = true, IsDeleted = false, CreatedBy = "Admin", CreatedOn = DateTime.Now, LastModifiedBy = "Admin", LastModifiedOn = DateTime.Now },
          new Yazar { Id = 2, Ad = "Veli", Soyad = "Ali", IsActive = true, IsDeleted = false, CreatedBy = "Admin", CreatedOn = DateTime.Now, LastModifiedBy = "Admin", LastModifiedOn = DateTime.Now }
          );

      modelBuilder.Entity<Yayinevi>().HasData(
          new Yayinevi { Id = 1, Tanim = "Yayıncı1", IsActive = true, IsDeleted = false, CreatedBy = "Admin", CreatedOn = DateTime.Now, LastModifiedBy = "Admin", LastModifiedOn = DateTime.Now },
          new Yayinevi { Id = 2, Tanim = "Yayıncı2", IsActive = true, IsDeleted = false, CreatedBy = "Admin", CreatedOn = DateTime.Now, LastModifiedBy = "Admin", LastModifiedOn = DateTime.Now }
          );

      modelBuilder.Entity<Kitap>().HasData(
          new Kitap { Id = 1, Adi = "Kitap1", Barkod = "Kitap1", BaskiYili = 1, SayfaSayisi = 1, Aciklama = "Kitap1", YazarId = 1, YayineviId = 1, IsActive = true, IsDeleted = false, CreatedBy = "Admin", CreatedOn = DateTime.Now, LastModifiedBy = "Admin", LastModifiedOn = DateTime.Now },
          new Kitap { Id = 2, Adi = "Kitap2", Barkod = "Kitap2", BaskiYili = 2, SayfaSayisi = 2, Aciklama = "Kitap2", YazarId = 2, YayineviId = 2, IsActive = true, IsDeleted = false, CreatedBy = "Admin", CreatedOn = DateTime.Now, LastModifiedBy = "Admin", LastModifiedOn = DateTime.Now }
          );
    }



  }
}
