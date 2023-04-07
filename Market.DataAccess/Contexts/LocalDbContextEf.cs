using Market.Entity.Classes.TestClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Market.DataAccess.Contexts
{
  // https://learn.microsoft.com/tr-tr/ef/ef6/fundamentals/databinding/winforms?source=recommendations
  // https://learn.microsoft.com/tr-tr/ef/core/get-started/winforms?source=recommendations
  // https://www.learnentityframeworkcore5.com/project-types/winform

  //https://www.connectionstrings.com/sqlconnection/
  public class LocalDbContextEf : DbContext
  {
    private readonly string _connectionString;
    public LocalDbContextEf(string connectionString)
    {
      _connectionString = connectionString;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(_connectionString, builder => builder.EnableRetryOnFailure());

      optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
      optionsBuilder.EnableSensitiveDataLogging(false);
    }

    public DbSet<Arkadas> Arkadaslar { get; set; }
  }
}
