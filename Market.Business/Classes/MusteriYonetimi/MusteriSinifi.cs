using Market.DataAccess.Contexts;
using Market.Entity.Classes.DbClasses.MusteriSiniflari;
using Market.Entity.Classes.DbClasses.UserClasses;
using Market.Entity.Classes.ResponseClasses;
using Market.Entity.Enums;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Market.Business.Classes.MusteriYonetimi
{
  public class MusteriSinifi
  {


    public List<Musteri> MusteriListesi(out ResultObject result, bool isDeleted)
    {
      result = new ResultObject();

      try
      {
        List<Musteri> musteriler = new List<Musteri>();

        string sqlstr = @"
          SELECT * FROM Musteriler
          WHERE IsDeleted = @IsDeleted
        ";

        DataTable dt = new DataTable();
        using (SqlDataAdapter da = new SqlDataAdapter(sqlstr, MarketDbContext.GetDBConn()))
        {
          da.SelectCommand.Parameters.Add("@IsDeleted", System.Data.SqlDbType.Bit).Value = isDeleted;
          da.Fill(dt);
        }

        //// LinQ
        //musteriler = (from DataRow dr in dt.Rows
        //              select new Musteri()
        //              {
        //                Id = Convert.ToInt32(dr["Id"]),
        //                CreatedBy = dr["CreatedBy"].ToString(),
        //                CreatedOn = Convert.ToDateTime(dr["CreatedOn"]),
        //                LastModifiedBy = dr["LastModifiedBy"].ToString(),
        //                LastModifiedOn = Convert.ToDateTime(dr["LastModifiedOn"]),
        //                IsActive = Convert.ToBoolean(dr["IsActive"]),
        //                IsDeleted = Convert.ToBoolean(dr["IsDeleted"]),
        //                Ad = dr["Ad"].ToString(),
        //                Soyad = dr["Soyad"].ToString(),
        //                Telefon = dr["Telefon"].ToString()
        //              }).ToList();

        foreach (DataRow satir in dt.Rows)
        {
          musteriler.Add(new()
          {
            Id = Convert.ToInt32(satir["Id"]),
            CreatedBy = satir["CreatedBy"].ToString(),
            CreatedOn = Convert.ToDateTime(satir["CreatedOn"]),
            LastModifiedBy = satir["LastModifiedBy"].ToString(),
            LastModifiedOn = Convert.ToDateTime(satir["LastModifiedOn"]),
            IsActive = Convert.ToBoolean(satir["IsActive"]),
            IsDeleted = Convert.ToBoolean(satir["IsDeleted"]),
            Ad = satir["Ad"].ToString(),
            Soyad = satir["Soyad"].ToString(),
            Telefon = satir["Telefon"].ToString()
          });
        }



        // İşlem Başarılı
        result.ResultStatus = ResultStatus.Success;
        result.Message = "İşlem Başarılı";
        return musteriler;
      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = "İşlem Hatası";
        result.Description = ex.Message;
        return null;
      }
    }

    public void MusteriEkle(out ResultObject result, Musteri musteri, MarketUser currentUser)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Kullanıcı Ekleme";

      try
      {
        int affecteRows = 0;
        string insertedId = "";

        string sqlstr = @"
          INSERT INTO Musteriler (
            CreatedOn
            ,CreatedBy
            ,LastModifiedOn
            ,LastModifiedBy
            ,IsDeleted
            ,IsActive
            ,Ad
            ,Soyad
            ,Telefon) VALUES (
            @CreatedOn
            ,@CreatedBy
            ,@LastModifiedOn
            ,@LastModifiedBy
            ,@IsDeleted
            ,@IsActive
            ,@Ad
            ,@Soyad
            ,@Telefon)
            SET @eklenenId = SCOPE_IDENTITY()
          ";

        using (SqlCommand cmd = new SqlCommand(sqlstr, MarketDbContext.GetDBConn()))
        {
          cmd.Parameters.Add("@eklenenId", SqlDbType.Int).Direction = ParameterDirection.Output;

          cmd.Parameters.Add("@CreatedOn", SqlDbType.DateTime).Value = DateTime.Now;
          cmd.Parameters.Add("@CreatedBy", SqlDbType.NVarChar).Value = currentUser.FullName;
          cmd.Parameters.Add("@LastModifiedOn", SqlDbType.DateTime).Value = DateTime.Now;
          cmd.Parameters.Add("@LastModifiedBy", SqlDbType.NVarChar).Value = currentUser.FullName;
          cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = musteri.IsDeleted;
          cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = musteri.IsActive;
          cmd.Parameters.Add("@Ad", SqlDbType.NVarChar).Value = musteri.Ad;
          cmd.Parameters.Add("@Soyad", SqlDbType.NVarChar).Value = musteri.Soyad;
          cmd.Parameters.Add("@Telefon", SqlDbType.NVarChar).Value = musteri.Telefon;

          affecteRows = cmd.ExecuteNonQuery();

          insertedId = cmd.Parameters["@eklenenId"].Value.ToString();
        }

        if (affecteRows == 0)
        {
          result.ResultStatus = ResultStatus.Error;
          result.Message = $"Ekleme işlemi başarısız";
          result.Description = $"{affecteRows} satır eklendi";
          return;
        }

        // işlem başarılı
        result.ResultStatus = ResultStatus.Success;
        result.Message = "Ekleme işlemi başarılı";
        result.Description = $"{affecteRows} satır eklendi";
        result.AffectedId = Convert.ToInt32(insertedId);
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
