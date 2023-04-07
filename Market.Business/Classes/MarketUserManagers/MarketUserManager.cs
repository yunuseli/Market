using Market.DataAccess.Contexts;
using Market.DataAccess.Seeds;
using Market.Entity.Classes.DbClasses.UserClasses;
using Market.Entity.Classes.DtoClasses;
using Market.Entity.Classes.ResponseClasses;
using Market.Entity.Enums;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Market.Business.Classes.MarketUserManagers
{
  public class MarketUserManager
  {

    public MarketUser LoginMarketUser(out ResultObject result, LoginDto login)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Kullanıcı Girişi";

      try
      {
        #region Ön Kontrolller
        if (login == null ||
          String.IsNullOrEmpty(login.EMail) ||
          String.IsNullOrWhiteSpace(login.EMail) ||
          login.EMail.Length > 50 ||
          String.IsNullOrEmpty(login.Password) ||
          String.IsNullOrWhiteSpace(login.Password) |
          String.IsNullOrWhiteSpace(login.Password)
          )
        {
          result.ResultStatus = ResultStatus.Error;
          result.Message = $"Kullanıcı bilgileri boş geçilemez";
          return null;
        }
        if (login.EMail.Length > 50 ||
          login.Password.Length > 50
          )
        {
          result.ResultStatus = ResultStatus.Error;
          result.Message = $"Kullanıcı bilgileri çok uzun";
          return null;
        }
        #endregion

        DataTable dt = new DataTable();

        #region Veritabanı kullanıcı sorgula
        string sqlstr = @"
          SELECT 
            Id
            ,CreatedOn
            ,CreatedBy
            ,LastModifiedOn
            ,LastModifiedBy
            ,IsDeleted
            ,IsActive
            ,Name
            ,SurName
            ,Password
            ,EMail
          FROM 
            MarketUser
          WHERE
            EMail = @EMail
            AND Password = @Password 
            AND IsDeleted = @IsDeleted 
            AND IsActive = @IsActive 

          ";

        using (SqlDataAdapter da = new SqlDataAdapter(sqlstr, MarketDbContext.GetDBConn()))
        {
          da.SelectCommand.Parameters.Add("@EMail", SqlDbType.NVarChar).Value = login.EMail;
          da.SelectCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = login.Password;
          da.SelectCommand.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = false;
          da.SelectCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = true;
          da.Fill(dt);
        }
        #endregion

        #region Kullanıcı yoksa yapılacak kontroller
        if (dt.Rows.Count == 0)
        {
          // Kullanıcı bulunamadı, listeye bak, hiç kullanıcı yoksa admin ekle
          sqlstr = @"SELECT * FROM MarketUser";
          using (SqlDataAdapter da = new SqlDataAdapter(sqlstr, MarketDbContext.GetDBConn()))
            da.Fill(dt);

          if (dt.Rows.Count != 0)
          {
            // Tabloda kullanıcı var, şifre veya email yanlış -> hata dön
            result.ResultStatus = ResultStatus.Error;
            result.Message = $"Kullanıcı bilgileri hatalı";
            return null;
          }

          // **** Hiç kullanıcı yok          
          MarketUserDefaultAdmin seed = new MarketUserDefaultAdmin();
          MarketUser admin = seed.GetDefaultAdmin();

          int affecteRows = 0;
          string insertedId = "";

          sqlstr = @"
          INSERT INTO MarketUser (
            CreatedOn
            ,CreatedBy
            ,LastModifiedOn
            ,LastModifiedBy
            ,IsDeleted
            ,IsActive
            ,Name
            ,SurName
            ,Password
            ,EMail 
            ,BirthDate 
            ,ImageBytes
            ,ImageType) VALUES (
            @CreatedOn
            ,@CreatedBy
            ,@LastModifiedOn
            ,@LastModifiedBy
            ,@IsDeleted
            ,@IsActive
            ,@Name
            ,@SurName
            ,@Password
            ,@EMail
            ,@BirthDate 
            ,@ImageBytes
            ,@ImageType)
            SET @eklenenId = SCOPE_IDENTITY()
          ";

          using (SqlCommand cmd = new SqlCommand(sqlstr, MarketDbContext.GetDBConn()))
          {
            cmd.Parameters.Add("@eklenenId", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters.Add("@CreatedOn", SqlDbType.DateTime).Value = admin.CreatedOn;
            cmd.Parameters.Add("@CreatedBy", SqlDbType.NVarChar).Value = admin.CreatedBy;
            cmd.Parameters.Add("@LastModifiedOn", SqlDbType.DateTime).Value = admin.LastModifiedOn;
            cmd.Parameters.Add("@LastModifiedBy", SqlDbType.NVarChar).Value = admin.LastModifiedBy;
            cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = admin.IsDeleted;
            cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = admin.IsActive;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = admin.Name;
            cmd.Parameters.Add("@SurName", SqlDbType.NVarChar).Value = admin.SurName;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = admin.Password;
            cmd.Parameters.Add("@EMail", SqlDbType.NVarChar).Value = admin.EMail;
            cmd.Parameters.Add("@BirthDate", SqlDbType.NVarChar).Value = admin.BirthDate;
            cmd.Parameters.Add("@ImageBytes", SqlDbType.VarBinary).Value = DBNull.Value;
            cmd.Parameters.Add("@ImageType", SqlDbType.VarChar).Value = DBNull.Value;

            affecteRows = cmd.ExecuteNonQuery();

            insertedId = cmd.Parameters["@eklenenId"].Value.ToString();
          }

          if (affecteRows == 0)
          {
            result.ResultStatus = ResultStatus.Error;
            result.Message = $"Kullanıcı yok, varsayılan kullanıcı eklenemedi";
            return null;
          }


          // ekleme başarılı
          result.ResultStatus = ResultStatus.Info;
          result.Message = $"Tanımlı kullanıcı yoktu, varsayılan yönetci hesabı eklendi";
          result.Description = $"Varsayılan yönetici bilgileri; EMail : {admin.EMail}, Şifre : {admin.Password}";

          admin.Id = Convert.ToInt32(insertedId);
          return admin;
        }
        #endregion

        // Kullanıcı bulundu
        MarketUser marketUser = new MarketUser();
        marketUser.Id = Convert.ToInt32(dt.Rows[0]["Id"].ToString());
        marketUser.CreatedBy = dt.Rows[0]["CreatedBy"].ToString();
        marketUser.CreatedOn = Convert.ToDateTime(dt.Rows[0]["CreatedOn"]);
        if (dt.Rows[0]["LastModifiedBy"].ToString() != "")
        {
          marketUser.LastModifiedBy = dt.Rows[0]["LastModifiedBy"].ToString();
          marketUser.LastModifiedOn = Convert.ToDateTime(dt.Rows[0]["LastModifiedOn"]);
        }
        marketUser.IsActive = Convert.ToBoolean(dt.Rows[0]["IsActive"]);
        marketUser.IsDeleted = Convert.ToBoolean(dt.Rows[0]["IsDeleted"]);
        marketUser.Name = dt.Rows[0]["Name"].ToString();
        marketUser.SurName = dt.Rows[0]["SurName"].ToString();
        marketUser.EMail = dt.Rows[0]["EMail"].ToString();
        marketUser.Password = dt.Rows[0]["Password"].ToString();


        result.ResultStatus = ResultStatus.Success;
        result.Message = "Giriş başarılı";
        return marketUser;

      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"İşlem Hatası";
        result.Description = ex.Message;
        return null;
      }


    }


    public List<MarketUser> MarketUserList(out ResultObject result, bool isDeleted, bool isActive = false)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Kullanıcı Listesi";

      try
      {
        DataTable dt = new DataTable();

        #region Veritabanı kullanıcı sorgula
        string sqlstr = @"
          SELECT 
            Id
            ,CreatedOn
            ,CreatedBy
            ,LastModifiedOn
            ,LastModifiedBy
            ,IsDeleted
            ,IsActive
            ,Name
            ,SurName
            ,Password
            ,EMail            
            ,BirthDate
            ,ImageBytes
            ,ImageType
          FROM 
            MarketUser
          WHERE
            IsDeleted = @IsDeleted 
            --AND IsActive = @IsActive 
          ";

        using (SqlDataAdapter da = new SqlDataAdapter(sqlstr, MarketDbContext.GetDBConn()))
        {
          da.SelectCommand.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = isDeleted;
          //da.SelectCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;
          da.Fill(dt);
        }
        #endregion

        // Dönüş Listesini Oluştur
        List<MarketUser> list = new List<MarketUser>();

        // Datatable - Foreach
        foreach (DataRow dr in dt.Rows)
        {
          MarketUser marketUser = new MarketUser();
          marketUser.Id = Convert.ToInt32(dr["Id"]);
          marketUser.CreatedBy = dr["CreatedBy"].ToString();
          marketUser.CreatedOn = Convert.ToDateTime(dr["CreatedOn"]);
          marketUser.LastModifiedBy = dr["LastModifiedBy"].ToString();
          marketUser.LastModifiedOn = Convert.ToDateTime(dr["LastModifiedOn"]);
          marketUser.IsActive = Convert.ToBoolean(dr["IsActive"]);
          marketUser.IsDeleted = Convert.ToBoolean(dr["IsDeleted"]);
          marketUser.Name = dr["Name"].ToString();
          marketUser.SurName = dr["SurName"].ToString();
          marketUser.EMail = dr["EMail"].ToString();
          marketUser.Password = dr["Password"].ToString();
          marketUser.BirthDate = Convert.ToDateTime(dr["BirthDate"]);
          if (dr["ImageType"].ToString() != "")
          {
            marketUser.ImageBytes = (byte[])dr["ImageBytes"];
            marketUser.ImageType = dr["ImageType"].ToString();
          }
          else
          {
            marketUser.ImageBytes = null;
            marketUser.ImageType = "";
          }

          list.Add(marketUser);
        }

        // string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["Data"]);



        // LinQ
        //list = (from DataRow dr in dt.Rows
        //        select new MarketUser()
        //        {
        //          Id = Convert.ToInt32(dr["Id"]),
        //          CreatedBy = dr["CreatedBy"].ToString(),
        //          CreatedOn = Convert.ToDateTime(dr["CreatedOn"]),
        //          LastModifiedBy = dr["LastModifiedBy"].ToString(),
        //          LastModifiedOn = Convert.ToDateTime(dr["LastModifiedOn"]),
        //          IsActive = Convert.ToBoolean(dr["IsActive"]),
        //          IsDeleted = Convert.ToBoolean(dr["IsDeleted"]),
        //          Name = dr["Name"].ToString(),
        //          SurName = dr["SurName"].ToString(),
        //          EMail = dr["EMail"].ToString(),
        //          Password = dr["Password"].ToString(),
        //          BirthDate = Convert.ToDateTime(dr["BirthDate"])
        //        }).ToList();


        //                  LastModifiedOn = String.IsNullOrEmpty(dt.Rows[0]["LastModifiedBy"].ToString()) ? Convert.ToDateTime(dt.Rows[0]["LastModifiedOn"]) : DateTime.MinValue,


        result.ResultStatus = ResultStatus.Success;
        result.Message = "İşlem başarılı";
        return list;

      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"İşlem Hatası";
        result.Description = ex.Message;
        return null;
      }
    }

    public void DeleteMarketUser(out ResultObject result, int Id, CrudOperations operation, MarketUser currentUser)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Kullanıcı Silme";

      try
      {
        string sqlstr = "";
        switch (operation)
        {
          case CrudOperations.Delete:
            sqlstr = @"
              UPDATE MarketUser SET 
                IsDeleted = @IsDeleted
                ,LastModifiedOn = @LastModifiedOn
                ,LastModifiedBy = @LastModifiedBy
              WHERE
                Id = @Id
              ";
            break;
          case CrudOperations.DeleteHard:
            sqlstr = @"
              DELETE FROM 
                MarketUser
              WHERE
                Id = @Id
              ";
            break;
        }

        int affecteRows = 0;
        using (SqlCommand cmd = new SqlCommand(sqlstr, MarketDbContext.GetDBConn()))
        {
          cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
          if (operation == CrudOperations.Delete)
          {
            cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = true;
            cmd.Parameters.Add("@LastModifiedOn", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@LastModifiedBy", SqlDbType.NVarChar).Value = currentUser.FullName;
          }

          affecteRows = cmd.ExecuteNonQuery();
        }

        if (affecteRows == 0)
        {
          result.ResultStatus = ResultStatus.Error;
          result.Message = $"Silme işlemi gerçekleşmedi";
          result.Description = $"{affecteRows} satır silindi";
          return;
        }


        // işlem başarılı
        result.ResultStatus = ResultStatus.Success;
        result.Message = "Silme işlemi başarılı";
        result.Description = $"{affecteRows} satır silindi";
        result.AffectedId = Id;
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
    public void InsertMarketUser(out ResultObject result, MarketUser user, MarketUser currentUser)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Kullanıcı Ekleme";

      try
      {
        int affecteRows = 0;
        string insertedId = "";

        string sqlstr = @"
          INSERT INTO MarketUser (
            CreatedOn
            ,CreatedBy
            ,LastModifiedOn
            ,LastModifiedBy
            ,IsDeleted
            ,IsActive
            ,Name
            ,SurName
            ,Password
            ,EMail           
            ,BirthDate 
            ,ImageBytes
            ,ImageType) VALUES (
            @CreatedOn
            ,@CreatedBy
            ,@LastModifiedOn
            ,@LastModifiedBy
            ,@IsDeleted
            ,@IsActive
            ,@Name
            ,@SurName
            ,@Password
            ,@EMail
            ,@BirthDate 
            ,@ImageBytes
            ,@ImageType)
            SET @eklenenId = SCOPE_IDENTITY()
          ";

        using (SqlCommand cmd = new SqlCommand(sqlstr, MarketDbContext.GetDBConn()))
        {
          cmd.Parameters.Add("@eklenenId", SqlDbType.Int).Direction = ParameterDirection.Output;

          cmd.Parameters.Add("@CreatedOn", SqlDbType.DateTime).Value = DateTime.Now;
          cmd.Parameters.Add("@CreatedBy", SqlDbType.NVarChar).Value = currentUser.FullName;
          cmd.Parameters.Add("@LastModifiedOn", SqlDbType.DateTime).Value = DateTime.Now;
          cmd.Parameters.Add("@LastModifiedBy", SqlDbType.NVarChar).Value = currentUser.FullName;
          cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = user.IsDeleted;
          cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = user.IsActive;
          cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = user.Name;
          cmd.Parameters.Add("@SurName", SqlDbType.NVarChar).Value = user.SurName;
          cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;
          cmd.Parameters.Add("@EMail", SqlDbType.NVarChar).Value = user.EMail;
          cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime).Value = user.BirthDate;
          if (user.ImageBytes != null)
          {
            cmd.Parameters.Add("@ImageBytes", SqlDbType.VarBinary).Value = user.ImageBytes;
            cmd.Parameters.Add("@ImageType", SqlDbType.VarChar).Value = user.ImageType;
          }
          else
          {
            cmd.Parameters.Add("@ImageBytes", SqlDbType.VarBinary).Value = DBNull.Value;
            cmd.Parameters.Add("@ImageType", SqlDbType.VarChar).Value = DBNull.Value;
          }

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
    public void UpdateMarketUser(out ResultObject result, MarketUser user, MarketUser currentUser)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Kullanıcı Ekleme";

      try
      {
        int affecteRows = 0;

        string sqlstr = @"
          UPDATE MarketUser SET
            LastModifiedOn = @LastModifiedOn
            ,LastModifiedBy = @LastModifiedBy
            ,IsActive = @IsActive
            ,Name = @Name
            ,SurName = @SurName
            ,Password = @Password
            ,EMail = @EMail           
            ,BirthDate = @BirthDate
            ,ImageBytes = @ImageBytes
            ,ImageType = @ImageType
          WHERE
             Id = @Id
          ";

        using (SqlCommand cmd = new SqlCommand(sqlstr, MarketDbContext.GetDBConn()))
        {
          cmd.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;

          cmd.Parameters.Add("@LastModifiedOn", SqlDbType.DateTime).Value = DateTime.Now;
          cmd.Parameters.Add("@LastModifiedBy", SqlDbType.NVarChar).Value = currentUser.FullName;
          cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = user.IsActive;
          cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = user.Name;
          cmd.Parameters.Add("@SurName", SqlDbType.NVarChar).Value = user.SurName;
          cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;
          cmd.Parameters.Add("@EMail", SqlDbType.NVarChar).Value = user.EMail;
          cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime).Value = user.BirthDate;
          if (user.ImageBytes != null)
          {
            cmd.Parameters.Add("@ImageBytes", SqlDbType.VarBinary).Value = user.ImageBytes;
            cmd.Parameters.Add("@ImageType", SqlDbType.VarChar).Value = user.ImageType;
          }
          else
          {
            cmd.Parameters.Add("@ImageBytes", SqlDbType.VarBinary).Value = DBNull.Value;
            cmd.Parameters.Add("@ImageType", SqlDbType.VarChar).Value = DBNull.Value;
          }

          affecteRows = cmd.ExecuteNonQuery();
        }

        if (affecteRows == 0)
        {
          result.ResultStatus = ResultStatus.Error;
          result.Message = $"Güncelleme işlemi başarısız";
          result.Description = $"{affecteRows} satır güncellendi";
          return;
        }

        // işlem başarılı
        result.ResultStatus = ResultStatus.Success;
        result.Message = "Güncelleme işlemi başarılı";
        result.Description = $"{affecteRows} satır güncellendi";
        result.AffectedId = user.Id;
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


  } // Class Sonu
}
