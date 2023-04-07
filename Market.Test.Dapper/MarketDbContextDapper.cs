using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Market.Test.Dapper
{
  public class MarketDbContextDapper
  {
    private static string SystemDb_Context()
    {
      string server = "INPUTFF\\SQLEXPRESS";
      string database = "MarketDB";
      string user = "ProgramUser";
      string password = "852369741";
      return $"Data Source=\"{server}\";Initial Catalog=\"{database}\";Persist Security Info=True;User ID=\"{user}\";Password=\"{password}\"";
    }

    // Database connection - SQL
    private static System.Data.SqlClient.SqlConnection conDbSql;
    private static string conDbSqlStr;
    public MarketDbContextDapper()
    {
      conDbDapperStr = SystemDb_ContextDapper();
      conDbSqlStr = SystemDb_Context();
    }
    public static System.Data.SqlClient.SqlConnection GetSqlDbConn()
    {
      if (conDbSql == null) conDbSql = new System.Data.SqlClient.SqlConnection(conDbSqlStr);
      if (conDbSql.State == ConnectionState.Closed) conDbSql.Open();
      return conDbSql;
    }


    private static string SystemDb_ContextDapper()
    {
      string server = "INPUTFF\\SQLEXPRESS";
      string database = "MarketDB";
      string user = "ProgramUser";
      string password = "852369741";
      return $"Data Source=\"{server}\";Initial Catalog=\"{database}\";Integrated Security=true;Encrypt=false;User ID=\"{user}\";Password=\"{password}\"";

      //SqlConnection": "server=.; database=Dapper; Integrated Security=true; Encrypt=false"
    }
    private static IConfiguration conDbDapperConfig;
    private static string conDbDapperStr;

    private static IDbConnection conDbDapper;

    public MarketDbContextDapper(IConfiguration configuration)
    {
      conDbDapperConfig = configuration;
      conDbDapperStr = conDbDapperConfig.GetConnectionString("SqlConnection");
    }

    public IDbConnection CreateConnection()
        => new Microsoft.Data.SqlClient.SqlConnection(conDbDapperStr);



    public static IDbConnection GetDapperDbConn()
    {
      if (conDbDapper == null) conDbDapper = new Microsoft.Data.SqlClient.SqlConnection(conDbDapperStr);
      if (conDbDapper.State == ConnectionState.Closed) conDbDapper.Open();
      return conDbDapper;
    }
  }
}
