using Market.DataAccess.Enums;
using Market.DataAccess.Seeds;
using Market.Entity.Classes.ResponseClasses;
using Market.Entity.Enums;
using Market.Helper.Classes.Encrypt;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace Market.DataAccess.Contexts
{

  // https://learn.microsoft.com/tr-tr/visualstudio/data-tools/accessing-data-in-visual-studio?view=vs-2022

  public class MarketDbContext
  {
    // Database connection
    private static SqlConnection conDB;
    private static string conDbStr;

    private static string SystemDb_Context()
    {
      // Yazılım içine gömülü veritabanı bağlantı cümlesi
      string server = "INPUTFF\\SQLEXPRESS";
      string database = "MarketDB";
      string user = "ProgramUser";
      string password = "852369741";
      return $"Data Source=\"{server}\";Initial Catalog=\"{database}\";Persist Security Info=True;User ID=\"{user}\";Password=\"{password}\"";
    }

    public MarketDbContext()
    {
      conDbStr = SystemDb_Context();
    }

    public static SqlConnection GetDBConn()
    {
      if (conDB == null) conDB = new SqlConnection(conDbStr);
      if (conDB.State == ConnectionState.Closed) conDB.Open();
      return conDB;
    }


    /// <summary>
    /// SQL bağlantısı kurulumu, verilen SQL cümlesi için
    /// </summary>
    /// <param name="result">İşlem durumu cevabı ResultObject tipinde verilir</param>
    /// <param name="dbstr">Sql bağlantı cümlesi</param>
    public static void SetDBConn(out ResultObject result, string dbstr)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      try
      {
        conDbStr = dbstr;
        if (conDB == null) conDB = new SqlConnection(conDbStr);
        if (conDB.State == ConnectionState.Closed) conDB.Open();

        result.ResultStatus = ResultStatus.Success;
        result.Message = "Bağlantı Kuruldu";
      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = "Bağlantı Hatası";
        result.Description = ex.Message;
        return;
      }
    }

    /// <summary>
    /// SQL bağlantısı kurulumu, tanımlı varsayılan sql veritabanı cümlesi kayıt dosyasından
    /// Eğer dosya yoksa yeni bir tane oluşturulur, içine varsayılan sql bağlantı cümlesi kaydedilir
    /// Program yeniden başlatılır ve sql bilgilerini düzenlemeniz gerekir.
    /// </summary>
    /// <param name="result">İşlem durumu cevabı ResultObject tipinde verilir</param>
    public static void SetDBConn(out ResultObject result, string applicationStartupPath, DbFileRecordingTypes dbFileRecordingType)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      try
      {
        DbContextDefault dbContextDefault = new DbContextDefault();
        AesHelper aes = new AesHelper();
        // Varsayılan veritabanı dosyasını oku
        string systemDbFileName = dbContextDefault.SystemDbFileName(applicationStartupPath);
        // Varsayılan veritabanı bağlantı cümlesi
        string defaultConnString = dbContextDefault.DefaultConnString();

        bool isDbFileNew = false;
        string readDbFile = string.Empty;

        if (dbFileRecordingType == DbFileRecordingTypes.Constructor)
        {
          conDbStr = SystemDb_Context();
          result.Description += "Veri bağlantısı ayarlandı (constructor)\n";
        }
        else
        {
          // Dosyayı kontrol et, varsa verileri oku ve bağlantıyı kur
          if (File.Exists(systemDbFileName))
          {
            // Dosay var, oku
            using (StreamReader str = new StreamReader(systemDbFileName, Encoding.UTF8))
            {
              readDbFile = str.ReadToEnd();
            }
            result.Description += "Dosya Okundu\n";

            // İçerik kontrolü
            if (String.IsNullOrEmpty(readDbFile))
            {
              isDbFileNew = true;
              result.Description += "Dosya içeriği boş\n";
            }
            // OK - dosya okundu
          }
          else
          {
            // Dosya yok - varsayılan değerler ile oluştur - kayıt tipine göre
            isDbFileNew = true;
            result.Description += "Veritabanı bağlantı dosyası yok\n";
          }
        }
        if (isDbFileNew)
        {
          // Dosya boş veya yok - varsayılan değerler ile yeniden yaz - kayıt tipine göre
          switch (dbFileRecordingType)
          {
            case DbFileRecordingTypes.TextFile:
              File.WriteAllText(systemDbFileName, defaultConnString);
              break;
            case DbFileRecordingTypes.JsonFile:
              break;
            case DbFileRecordingTypes.AesEncryptedFile:
              string encryptedStr = aes.AesEncrypt(defaultConnString);
              File.WriteAllText(systemDbFileName, encryptedStr);
              break;
            default:
              break;
          }
          result.Description += "Dosya içeriği varsayılan değerler ile oluşturuldu\n";

          result.Message += "Veritabanı bağlantı dosyası oluşturuldu, lütfen düzenleyip programı yeniden açınız\n";
          result.Message += $"Dosya: {systemDbFileName}\n";

          result.ResultStatus = ResultStatus.Error;
          return;
        }


        // Dosya ilk okuma veya oluşturma tamamlandı
        switch (dbFileRecordingType)
        {
          case DbFileRecordingTypes.TextFile:
            conDbStr = readDbFile;
            break;
          case DbFileRecordingTypes.JsonFile:
            break;
          case DbFileRecordingTypes.AesEncryptedFile:
            string decrytedStr = aes.AesDecrypt(readDbFile);
            conDbStr = decrytedStr;
            break;
          default:
            break;
        }
        result.Description += "Dosya içeriği veri bağlantısı aktarıldı\n";

        //if (DbConnection.SetDBConn(decrytedStr) != "OK")
        //{
        //  MessageBox.Show("Veritabanı ayarları hatalı, bağlantı kurulamadı, lütfen düzenleyip programı yeniden açınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //  Application.Exit();
        //  return;
        //}
        if (conDB == null) conDB = new SqlConnection(conDbStr);

        try
        {
          if (conDB.State == ConnectionState.Closed) conDB.Open();
        }
        catch (Exception ex)
        {
          result.Message = "Veritabanı bağlantı hatası, bağlantı dosyanızı veya cümlenizi kontrol ediniz";

          result.Description += ex.Message + Environment.NewLine;

          result.ResultStatus = ResultStatus.Error;
          return;
        }

        result.ResultStatus = ResultStatus.Success;
        result.Message = "Bağlantı Kuruldu";
      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = "Veritabanı bağlantı işlem hatası";
        result.Description = ex.Message;
        return;
      }
    }


  }
}
