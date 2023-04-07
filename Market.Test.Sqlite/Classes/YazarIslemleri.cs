using Market.Test.Sqlite.Enums;
using Market.Test.Sqlite.Helpers;
using Market.Test.Sqlite.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection;

namespace Market.Test.Sqlite.Classes
{
  public class YazarIslemleri
  {
    public List<Yazar> Liste(out ResultObject result, bool isDeleted, bool isActive = false)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Listeleme İşlemi";

      try
      {
        List<Yazar> liste = ProgramInfo.context.Yazarlar.Where(t => t.IsDeleted == isDeleted).ToList();



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
    public void Ekle(out ResultObject result, Yazar yazar)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Ekleme İşlemi";

      try
      {
        //ProgramInfo.context.Yazarlar.Add(yazar);
        ProgramInfo.context.Entry(yazar).State = Microsoft.EntityFrameworkCore.EntityState.Added;
        ProgramInfo.context.SaveChanges();

        result.ResultStatus = ResultStatus.Success;
        result.Message = "İşlem başarılı";
        return;

      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"İşlem Hatası";
        result.Description = ex.Message;
        return;
      }
    }

    public void Duzenle(out ResultObject result, Yazar yazar)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Duzenle İşlemi";

      try
      {
        //Yazar yazarProc = ProgramInfo.context.Yazarlar.Find(yazar.Id);
        //yazarProc.Ad = yazar.Ad;
        //yazarProc.Soyad = yazar.Soyad;
        //ProgramInfo.context.Entry<Yazar>(yazarProc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;


        // ProgramInfo.context.ChangeTracker.Entries().Count();
        // ProgramInfo.context.Entry(yazar).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        ProgramInfo.context.Entry(yazar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //ProgramInfo.context.Entry<Yazar>(yazar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //ProgramInfo.context.Yazarlar.Update(yazar);
        ProgramInfo.context.SaveChanges();
        //ProgramInfo.context!.SaveChanges();

        result.ResultStatus = ResultStatus.Success;
        result.Message = "İşlem başarılı";
        return;

      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"İşlem Hatası";
        result.Description = ex.Message;
        return;
      }
    }

    public void Sil(out ResultObject result, Yazar yazar)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Sil İşlemi";

      try
      {

        //yazar.IsDeleted= true;
        //ProgramInfo.context.Entry(yazar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

        ProgramInfo.context.Entry(yazar).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        //ProgramInfo.context.Yazarlar.Remove(yazar);
        ProgramInfo.context.SaveChanges();

        result.ResultStatus = ResultStatus.Success;
        result.Message = "İşlem başarılı";
        return;

      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"İşlem Hatası";
        result.Description = ex.Message;
        return;
      }
    }


  }
}
