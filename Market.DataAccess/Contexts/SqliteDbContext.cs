using Market.Entity.Classes.TestClasses;
using Microsoft.EntityFrameworkCore;

namespace Market.DataAccess.Contexts
{

  //https://learn.microsoft.com/tr-tr/dotnet/navigate/data-access/


  public class SqliteDbContext : DbContext
  {
    // "Data Source=Db/xyz.db"
    private readonly string _connectionString;

    public SqliteDbContext(string connectionString)
    {
      _connectionString = connectionString;
    }

    //https://www.connectionstrings.com/sqlconnection/

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite(_connectionString);


      //optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
      //optionsBuilder.EnableSensitiveDataLogging(false);   
    }

    //public DbSet<Arkadas> Arkadaslar { get; set; }

  }
}
