using Market.Test.Sqlite.Enums;
using Market.Test.Sqlite.Helpers;
using Market.Test.Sqlite.Models;
using System.Data;
using System.Reflection;

namespace Market.Test.Sqlite.Classes
{
  public class KitapIslemleri
  {
    public List<Kitap> Liste(out ResultObject result, bool isDeleted, bool isActive = false)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Kitap Listesi";

      try
      {
        List<Kitap> liste = ProgramInfo.context.Kitaplar.Where(t => t.IsDeleted == isDeleted).ToList();


        result.ResultStatus = ResultStatus.Success;
        result.Message = "İşlem başarılı";
        return liste;

      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"İşlem Hatası";
        result.Description = ex.Message;
        return null;
      }
    }



  }
}
