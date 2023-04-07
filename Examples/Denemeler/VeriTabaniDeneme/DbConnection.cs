using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTabaniDeneme
{
  public class DbConnection
  {
    private static SqlConnection conDB;
    private static string conDbStr;

    public DbConnection()
    {
      string _server = "INPUTFF\\SQLEXPRESS";
      string _database = "BilgisayarDB";
      string _user = "UserWinforms";
      string _password = "12345678";

      conDbStr = $"Data Source=\"{_server}\";" +
        $"Initial Catalog=\"{_database}\";" +
        $"Persist Security Info=True;" +
        $"User ID=\"{_user}\";" +
        $"Password=\"{_password}\"";
    }

    public static SqlConnection GetDbConn()
    {
      if (conDB == null) conDB = new SqlConnection(conDbStr);
      if (conDB.State == System.Data.ConnectionState.Closed) conDB.Open();
      return conDB;
    }
  }
}
