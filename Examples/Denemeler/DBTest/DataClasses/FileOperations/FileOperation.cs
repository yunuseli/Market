using DBTest.DataModels.BaseModels;
using DBTest.SystemClasses.ProgramClasses;
using System.Reflection;
using System.Text;

namespace DBTest.DataClasses.FileOperations
{
  public class FileOperation
  {

    public string dbFileRead(out ResultObject result)
    {
      result = new ResultObject();
      string cn = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      try
      {
        string readDbFile = string.Empty;
        if (File.Exists(ProgramInfo.DataBase.systemDbFileName))
        {
          using (StreamReader str = new StreamReader(ProgramInfo.DataBase.systemDbFileName, Encoding.UTF8))
            readDbFile = str.ReadToEnd();

          if (String.IsNullOrEmpty(readDbFile))
          {
            result.Status = SystemClasses.Enums.ResultStatus.Error;
            result.Message = "Veritabanı dosyası boş";
            result.SenderName = cn;
            return string.Empty;
          }

          result.Status = SystemClasses.Enums.ResultStatus.Success;
          result.Message = "İşlem tamamlandı";
          result.SenderName = cn;
          return readDbFile;
        }
        else
        {
          File.WriteAllText(ProgramInfo.DataBase.systemDbFileName, ProgramInfo.DataBase.defaultDbConnStr);

          using (StreamReader str = new StreamReader(ProgramInfo.DataBase.systemDbFileName, Encoding.UTF8))
            readDbFile = str.ReadToEnd();

          if (String.IsNullOrEmpty(readDbFile))
          {
            result.Status = SystemClasses.Enums.ResultStatus.Error;
            result.Message = "Veritabanı dosyası boş";
            result.SenderName = cn;
            return string.Empty;
          }

          result.Status = SystemClasses.Enums.ResultStatus.Success;
          result.Message = "İşlem tamamlandı";
          result.SenderName = cn;
          return readDbFile;
        }
      }
      catch (Exception ex)
      {
        result.Status = SystemClasses.Enums.ResultStatus.Error;
        result.Message = "Veritabanı dosyası okuma işlem hatası";
        result.Description = ex.Message;
        result.SenderName = cn;
        return string.Empty;
      }
    }

    public void dbFileWrite(out ResultObject result, string sqlStr)
    {
      result = new ResultObject();
      string cn = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      try
      {
        File.WriteAllText(ProgramInfo.DataBase.systemDbFileName, sqlStr);
      }
      catch (Exception ex)
      {
        result.Status = SystemClasses.Enums.ResultStatus.Error;
        result.Message = "Veritabanı dosyası yazma işlem hatası";
        result.Description = ex.Message;
        result.SenderName = cn;
      }
    }
  }
}
