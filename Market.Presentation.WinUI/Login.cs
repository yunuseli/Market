using Market.Business.Classes.MarketUserManagers;
using Market.DataAccess.Contexts;
using Market.Entity.Classes.DbClasses.UserClasses;
using Market.Entity.Classes.DtoClasses;
using Market.Entity.Classes.ResponseClasses;
using Market.Entity.Enums;
using Market.Helper.Classes.System;
using Market.Presentation.WinUI.Classes.HelperClasses;
using Market.Presentation.WinUI.Classes.ProgramClasses;
using Market.Presentation.WinUI.Forms.MainForms;
using System.Data.SqlClient;
using System.Reflection;

namespace Market.Presentation.WinUI
{
  public partial class Login : Form
  {
    public Login()
    {
      InitializeComponent();
    }

    //**** static settings
    MarketDbContext SetDataContext;
    ProgramInfo SetProgramInfo;
    //**** static settings

    // Lokal Nesneler - Değişkenler
    ResultObject result;
    MarketUserManager marketUserManager;


    public void ProgramiKapat()
    {
      this.Close();
      //Application.Exit();
    }

    private void Form_Load(object sender, EventArgs e)
    {
      StartSettings();

      MarketLogin();
    }
    void StartSettings()
    {
      try
      {
        result = new ResultObject();
        marketUserManager = new MarketUserManager();

        // DB bağlantısı ayarla
        SetDataContext = new MarketDbContext();
        ///MarketDbContext.SetDBConn(out result, Application.StartupPath, DbFileRecordingTypes.TextFile);
        //if (result.ResultStatus != ResultStatus.Success)
        //{
        //  ShowMessage.MesajGoster(result);
        //  Application.Exit();
        //}

        // Program Bilgileri Ayarla
        SetProgramInfo = new ProgramInfo();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
      ProgramiKapat();
    }


    void ConnectDatabase()
    {
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Veritabanı bağlantı durumu";

      try
      {
        SqlConnection con = MarketDbContext.GetDBConn();
        if (con.State == System.Data.ConnectionState.Open)
        {
          result.ResultStatus = ResultStatus.Success;
          result.Message = $"Bağlantı sağlandı : {MarketDbContext.GetDBConn().ServerVersion}";
          ShowMessage.MesajGoster(result);
        }
      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"! Bağlantı hatası";
        result.Description = ex.Message;
        ShowMessage.MesajGoster(result);
      }
    }
    private void buttonLogin_Click(object sender, EventArgs e)
    {
      //ConnectDatabase();
      MarketLogin();
    }
    void MarketLogin()
    {
      string resultOrigin = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";

      textBoxEmail.Text = "admin@system.com";
      textBoxPassword.Text = "1";

      try
      {
        // Login DTO oluştur
        LoginDto loginDto = new LoginDto { EMail = textBoxEmail.Text, Password = textBoxPassword.Text };

        // Login işlemi - Business katmanı
        MarketUser user = marketUserManager.LoginMarketUser(out result, loginDto);
        // Sonuç başarılı değilse mesaj ver ve işleme devam etme
        if (result.ResultStatus != ResultStatus.Success)
        {
          result.OriginProcess += $"\n{resultOrigin}";
          ShowMessage.MesajGoster(result);
          return;
        }

        ////Giriş Başarılı
        //result.Title = "Kullanıcı Girişi";
        //result.ResultStatus = ResultStatus.Success;
        //result.Message = $"Hoşgeldiniz {user.FullName}";
        //result.OriginProcess = resultOrigin;
        //ShowMessage.MesajGoster(result);  


        // Program Data Settings
        ProgramInfo.Session.CurrenUser = user;

        ClientHelper clientHelper = new ClientHelper();
        ProgramInfo.Session.CurrentClient = clientHelper.GetClientInfo(out result);

        //var ticks = DateTime.Now.Ticks;
        //var guid = Guid.NewGuid().ToString();
        //var uniqueSessionId = ticks.ToString() + '-' + guid; //guid created by combining ticks
        ProgramInfo.Session.sGuid = Guid.NewGuid();


        Main main = new Main();
        this.Hide();
        main.ShowDialog();    
      }
      catch (Exception ex)
      {
        result.Title = "Kullanıcı Girişi";
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"İşlem hatası";
        result.Description = ex.Message;
        ShowMessage.MesajGoster(result);
      }
    }






  }
}
