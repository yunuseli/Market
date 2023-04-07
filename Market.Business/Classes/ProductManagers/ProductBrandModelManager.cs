using Market.DataAccess.Contexts;
using Market.Entity.Classes.DbClasses.ProductClasses;
using Market.Entity.Classes.DbClasses.UserClasses;
using Market.Entity.Classes.ResponseClasses;
using Market.Entity.Enums;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace Market.Business.Classes.ProductCategoryManagers
{
  public class ProductBrandModelManager
  {

    public void CreateTable(out ResultObject result)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Tablo oluşturma";

      try
      {
        string sqlstr = @"
          SET ANSI_NULLS ON

          SET QUOTED_IDENTIFIER ON

          CREATE TABLE [dbo].[BrandsModels](
	          [Id] [int] IDENTITY(1,1) NOT NULL,
	          [CreatedOn] [datetime] NOT NULL,
	          [CreatedBy] [nvarchar](50) NOT NULL,
	          [LastModifiedOn] [datetime] NULL,
	          [LastModifiedBy] [nvarchar](50) NULL,
	          [IsDeleted] [bit] NOT NULL,
	          [IsActive] [bit] NOT NULL,
	          [ParentId] [int] NOT NULL,	          
            [Definition] [nvarchar](50) NOT NULL,
	          [Description] [nvarchar](50) NOT NULL,
	          [ImageType] [varchar](5) NULL,
	          [ImageBytes] [varbinary](max) NULL,
           CONSTRAINT [PK_BrandsModels] PRIMARY KEY CLUSTERED 
          (
	          [Id] ASC
          )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
          ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
              ";

        int affecteRows = 0;
        using (SqlCommand cmd = new SqlCommand(sqlstr, MarketDbContext.GetDBConn()))
        {
          affecteRows = cmd.ExecuteNonQuery();
        }

        if (affecteRows == 0)
        {
          result.ResultStatus = ResultStatus.Error;
          result.Message = $"Tablo oluşturma işlemi gerçekleşmedi";
          return;
        }


        // işlem başarılı
        result.ResultStatus = ResultStatus.Success;
        result.Message = "Tablo oluşturma işlemi başarılı";
        return;

      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"Tablo oluşturma işlem hatası";
        result.Description = ex.Message;
        return;
      }
    }



    public List<BrandModel> List(out ResultObject result, bool isDeleted, bool isActive = false)
    {
      result = new ResultObject();
      string opc = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      string title = "Listeleme işlemi";

      string sqlstr = @"
          SELECT 
            Id
            ,CreatedOn
            ,CreatedBy
            ,LastModifiedOn
            ,LastModifiedBy
            ,IsDeleted
            ,IsActive
            ,ParentId
            ,Definition
            ,Description            
            ,ImageType
            ,ImageBytes
          FROM 
            BrandsModels
          WHERE
            IsDeleted = @IsDeleted 
            --AND IsActive = @IsActive 
          ";

      try
      {
        // Sql sorgula
        DataTable dt = new DataTable();
        using (SqlDataAdapter da = new SqlDataAdapter(sqlstr, MarketDbContext.GetDBConn()))
        {
          da.SelectCommand.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = isDeleted;
          //da.SelectCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;
          da.Fill(dt);
        }

        // Dönüş Listesini Oluştur
        List<BrandModel> list = new List<BrandModel>();

        // LinQ
        list = (from DataRow dr in dt.Rows
                select new BrandModel()
                {
                  Id = Convert.ToInt32(dr["Id"]),
                  CreatedBy = dr["CreatedBy"].ToString(),
                  CreatedOn = Convert.ToDateTime(dr["CreatedOn"]),
                  LastModifiedBy = dr["LastModifiedBy"].ToString(),
                  LastModifiedOn = Convert.ToDateTime(dr["LastModifiedOn"]),
                  IsActive = Convert.ToBoolean(dr["IsActive"]),
                  IsDeleted = Convert.ToBoolean(dr["IsDeleted"]),
                  ParentId = Convert.ToInt32(dr["ParentId"]),
                  Definition = dr["Definition"].ToString(),
                  Description = dr["Description"].ToString(),
                  ImageType = dr["ImageType"].ToString() ?? string.Empty,
                  ImageBytes = !Convert.IsDBNull(dr["ImageBytes"]) ? (byte[])dr["ImageBytes"] : null
                }).ToList();

        result.OriginProcess = opc;
        result.Title = title;
        result.ResultStatus = ResultStatus.Success;
        result.Message = "İşlem başarılı";
        return list;

      }
      catch (SqlException sqlex)
      {
        //https://learn.microsoft.com/en-us/previous-versions/sql/sql-server-2008-r2/cc645611(v=sql.105)

        //if (sqlex.Message.Contains("Invalid object name") && ex.Message.Contains("Categories"))
        if (sqlex.Number == 208)
        {
          // Tablo yok
          CreateTable(out result);
          if (result.ResultStatus != ResultStatus.Success)
          {
            result.OriginProcess = $"{opc}\n{result.OriginProcess}";
            result.Title = title;
            result.ResultStatus = ResultStatus.Error;
            result.Message = $"Listeleme işlem Hatası";
            result.Description = $"Tablo bulunamadı, oluşturma sırasında hata alındı; {result.Description}";
            return null;
          }

          result.OriginProcess = opc;
          result.Title = title;
          result.ResultStatus = ResultStatus.Warning;
          result.Message = $"Listeleme işlem uyarısı";
          result.Description = "İlgili tablo bulunamadı, veritababnında oluşturuldu, lütfen tekrar listeleme yapınız";
          return null;
        }

        result.OriginProcess = opc;
        result.Title = title;
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"Listeleme işlem hatası";
        result.Description = sqlex.Message;
        return null;
      }
      catch (Exception ex)
      {
        result.OriginProcess = opc;
        result.Title = title;
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"Listeleme işlem Hatası";
        result.Description = ex.Message;
        return null;
      }
    }

    public void Delete(out ResultObject result, int Id, CrudOperations operation, MarketUser currentUser)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Silme işlemi";

      try
      {
        string sqlstr = "";
        switch (operation)
        {
          case CrudOperations.Delete:
            sqlstr = @"
              UPDATE BrandsModels SET 
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
                BrandsModels
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
        result.Message = $"Silme işlem hatası";
        result.Description = ex.Message;
        return;
      }


    }
    public void Insert(out ResultObject result, Category category, MarketUser currentUser)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Ekleme işlemi";

      try
      {
        int affecteRows = 0;
        string insertedId = "";

        string sqlstr = @"
          INSERT INTO Categories (
            CreatedOn
            ,CreatedBy
            ,LastModifiedOn
            ,LastModifiedBy
            ,IsDeleted
            ,IsActive
            ,Definition
            ,Description 
            ,ImageBytes
            ,ImageType) VALUES (
            @CreatedOn
            ,@CreatedBy
            ,@LastModifiedOn
            ,@LastModifiedBy
            ,@IsDeleted
            ,@IsActive
            ,@Definition
            ,@Description 
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
          cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = category.IsDeleted;
          cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = category.IsActive;
          cmd.Parameters.Add("@Definition", SqlDbType.NVarChar).Value = category.Definition;
          if (!String.IsNullOrEmpty(category.Description))
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = category.Description;
          else
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = DBNull.Value;

          if (category.ImageBytes != null)
          {
            cmd.Parameters.Add("@ImageBytes", SqlDbType.VarBinary).Value = category.ImageBytes;
            cmd.Parameters.Add("@ImageType", SqlDbType.VarChar).Value = category.ImageType;
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
        result.Message = $"Ekleme işlem hatası";
        result.Description = ex.Message;
        return;
      }


    }
    public void Update(out ResultObject result, Category category, MarketUser currentUser)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Güncelleme işlemi";

      try
      {
        int affecteRows = 0;

        string sqlstr = @"
          UPDATE Categories SET
            LastModifiedOn = @LastModifiedOn
            ,LastModifiedBy = @LastModifiedBy
            ,IsActive = @IsActive
            ,Definition = @Definition
            ,Description = @Description
            ,ImageBytes = @ImageBytes
            ,ImageType = @ImageType
          WHERE
             Id = @Id
          ";

        using (SqlCommand cmd = new SqlCommand(sqlstr, MarketDbContext.GetDBConn()))
        {
          cmd.Parameters.Add("@Id", SqlDbType.Int).Value = category.Id;

          cmd.Parameters.Add("@LastModifiedOn", SqlDbType.DateTime).Value = DateTime.Now;
          cmd.Parameters.Add("@LastModifiedBy", SqlDbType.NVarChar).Value = currentUser.FullName;
          cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = category.IsActive;
          cmd.Parameters.Add("@Definition", SqlDbType.NVarChar).Value = category.Definition;
          if (!String.IsNullOrEmpty(category.Description))
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = category.Description;
          else
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = DBNull.Value;

          if (category.ImageBytes != null)
          {
            cmd.Parameters.Add("@ImageBytes", SqlDbType.VarBinary).Value = category.ImageBytes;
            cmd.Parameters.Add("@ImageType", SqlDbType.VarChar).Value = category.ImageType;
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
        result.AffectedId = category.Id;
        return;

      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"Güncelleme işlem Hatası";
        result.Description = ex.Message;
        return;
      }
    }
    public void Update(out ResultObject result, List<Category> categories, MarketUser currentUser)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Güncelleme işlemi";

      try
      {
        int affecteRows = 0;

        string sqlstr = @"
          UPDATE Categories SET
            LastModifiedOn = @LastModifiedOn
            ,LastModifiedBy = @LastModifiedBy
            ,IsActive = @IsActive
            ,Definition = @Definition
            ,Description = @Description
            ,ImageBytes = @ImageBytes
            ,ImageType = @ImageType
          WHERE
             Id = @Id
          ";

        foreach (Category category in categories)
        {
          using (SqlCommand cmd = new SqlCommand(sqlstr, MarketDbContext.GetDBConn()))
          {
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = category.Id;

            cmd.Parameters.Add("@LastModifiedOn", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@LastModifiedBy", SqlDbType.NVarChar).Value = currentUser.FullName;
            cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = category.IsActive;
            cmd.Parameters.Add("@Definition", SqlDbType.NVarChar).Value = category.Definition;
            if (!String.IsNullOrEmpty(category.Description))
              cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = category.Description;
            else
              cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = DBNull.Value;

            if (category.ImageBytes != null)
            {
              cmd.Parameters.Add("@ImageBytes", SqlDbType.VarBinary).Value = category.ImageBytes;
              cmd.Parameters.Add("@ImageType", SqlDbType.VarChar).Value = category.ImageType;
            }
            else
            {
              cmd.Parameters.Add("@ImageBytes", SqlDbType.VarBinary).Value = DBNull.Value;
              cmd.Parameters.Add("@ImageType", SqlDbType.VarChar).Value = DBNull.Value;
            }

            affecteRows += cmd.ExecuteNonQuery();
          }
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
        result.AffectedId = 0;
        return;

      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"Güncelleme işlem Hatası";
        result.Description = ex.Message;
        return;
      }
    }


  } // EOF
}
