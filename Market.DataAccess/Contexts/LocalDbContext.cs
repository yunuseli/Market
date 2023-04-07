using System.Data;
using System.Data.SqlClient;

namespace Market.DataAccess.Contexts
{
  public class LocalDbContext
  {
    private static SqlConnection conDB;

    private static string conStrDB;

    public LocalDbContext()
    {
    //  conStrDB = "Data Source=(localDB)\\MSSQLLocalDB;AttachDbFilename=C:\\DBbak\\TestLocalDb.mdf;Integrated Security=True";
    }
    public static SqlConnection GetLocalDBConn()
    {
      if (conDB == null) conDB = new SqlConnection(conStrDB);
      if (conDB.State == ConnectionState.Closed) conDB.Open();

      return conDB;
    }
    public static string SetLocalDBConn(string appStartupPath)
    {
      try
      {
        conStrDB = "Data Source=(localDB)\\MSSQLLocalDB;AttachDbFilename=" +
          appStartupPath +
          "TestLocalDb.mdf;Integrated Security=True";

        return "OK";
      }
      catch (Exception ex)
      {
        return ex.Message;
      }
    }
  }
}
