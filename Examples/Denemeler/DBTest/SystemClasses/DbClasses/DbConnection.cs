using DBTest.DataClasses.FileOperations;
using DBTest.DataModels.BaseModels;
using DBTest.SystemClasses.Enums;
using DBTest.SystemClasses.ProgramClasses;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace DBTest.SystemClasses.DbClasses
{
  public class DbConnection
  {

    private static SqlConnection conDB;
    private static string _conStrDB = "";

    public DbConnection()
    {
      //try
      //{
      //  string dsrc = "INPUTFF\\SQLEXPRESS";
      //  string ctlg = "WinformsTest";
      //  string user = "UserWinforms";
      //  string pass = "12345678";

      //  _conStrDB = $"Data Source=\"{dsrc}\";Initial Catalog=\"{ctlg}\";Persist Security Info=True;User ID=\"{user}\";Password=\"{pass}\"";
      //}
      //catch (Exception)
      //{
      //  throw;
      //}
    }
    public static void SetDBConn(string dbstr, out ResultObject result)
    {
      result = new ResultObject();
      string cn = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      try
      {
        FileOperation fileOperation = new FileOperation();
        string readDbFile = fileOperation.dbFileRead(out result);
        if (result.Status != ResultStatus.Success)
        {
          result.Status = Enums.ResultStatus.Error;
          result.Message = "Veritabanı ayar okuma hatası";
          result.Description = ProgramInfo.classMessage(result.Description, cn);
        }

        //if (conDB == null) conDB = new SqlConnection(_conStrDB);
          if (conDB == null) conDB = new SqlConnection(readDbFile);
          if (conDB.State == ConnectionState.Closed) conDB.Open();
        result.Status = Enums.ResultStatus.Success;
        result.Message = ProgramInfo.classMessage("Veritabanı bağlantısı sağlandı", cn);
      }
      catch (Exception ex)
      {
        result.Status = Enums.ResultStatus.Error;
        result.Message = "Veritabanı bağlantı hatası";
        result.Description = ProgramInfo.classMessage(ex.Message, cn);
      }
    }
    public static SqlConnection GetDBConn()
    {
      //try
      //{
      if (conDB == null) conDB = new SqlConnection(_conStrDB);
      if (conDB.State == ConnectionState.Closed) conDB.Open();
      return conDB;
      //}
      //catch (Exception)
      //{
      //  throw;
      //}
    }
  }
}
