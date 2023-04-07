using DBTest.DataClasses.FileOperations;
using DBTest.DataModels.BaseModels;
using DBTest.SystemClasses.DbClasses;
using DBTest.SystemClasses.Enums;
using DBTest.SystemClasses.ProgramClasses;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection;
using System.Text;
using static DBTest.SystemClasses.ProgramClasses.ProgramInfo;

namespace DBTest.UserInterface.SystemSettings
{
  public partial class DbSettings : Form
  {
    public DbSettings()
    {
      InitializeComponent();
    }

    public string sql { get; set; }

    string _server = string.Empty, _database = string.Empty, _user = string.Empty, _password = string.Empty;

    private void DbSettings_Load(object sender, EventArgs e)
    {
      pageStart();
      buttonSave.Enabled = false;
    }
    void pageStart()
    {
      string cn = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      try
      {
        if (!String.IsNullOrEmpty(sql))
        {
          richTextBoxSql.Text = sql;
          setData();
        }
        else
        {
          string readDbFile = string.Empty;
          if (!File.Exists(ProgramInfo.DataBase.systemDbFileName))
          {
            MessageBox.Show(ProgramInfo.classMessage("Veritabanı ayar dosyası bulunamadı, yeni oluşturulacak", cn), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            File.WriteAllText(ProgramInfo.DataBase.systemDbFileName, ProgramInfo.DataBase.defaultDbConnStr);

            using (StreamReader str = new StreamReader(ProgramInfo.DataBase.systemDbFileName, Encoding.UTF8))
              readDbFile = str.ReadToEnd();

            if (String.IsNullOrEmpty(readDbFile))
            {
              MessageBox.Show(ProgramInfo.classMessage("Veritabanı dosyası boş, manual oluşturmayı deneyin", cn), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
            }
          }

          MessageBox.Show(ProgramInfo.classMessage("Veritabanı ayarlanmadan program başlatılamaz", cn), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ProgramInfo.classMessage(ex.Message, cn), "İşlem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    void setData()
    {
      string cn = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      try
      {
        //$"Data Source=\"YOURSERVER\";Initial Catalog=\"YOURDB\";Persist Security Info=True;User ID=\"YOURUSER\";Password=\"YOURPASSWORD\"";

        string[] dbConnStr = sql.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string item in dbConnStr)
        {
          if (item.Contains("Data Source"))
          {
            string[] itemStr = item.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            if (itemStr.Length > 1)
              _server = itemStr[1];
          }
          if (item.Contains("Initial Catalog"))
          {
            string[] itemStr = item.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            if (itemStr.Length > 1)
              _database = itemStr[1];
          }
          if (item.Contains("User ID"))
          {
            string[] itemStr = item.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            if (itemStr.Length > 1)
              _user = itemStr[1];
          }
          if (item.Contains("Password"))
          {
            string[] itemStr = item.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            if (itemStr.Length > 1)
              _password = itemStr[1];
          }
        }

        if (String.IsNullOrEmpty(_server))
        {
          MessageBox.Show("Server bilgisi hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        textBoxServer.Text = _server.Replace("\"", "");

        if (String.IsNullOrEmpty(_database))
        {
          MessageBox.Show("Veritabanı bilgisi hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        textBoxDatabase.Text = _database.Replace("\"", "");

        if (String.IsNullOrEmpty(_user))
        {
          MessageBox.Show("Kullanıcı bilgisi hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        textBoxUser.Text = _user.Replace("\"", "");

        if (String.IsNullOrEmpty(_password))
        {
          MessageBox.Show("Şifre bilgisi hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        textBoxPassword.Text = _password.Replace("\"", "");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, ProgramInfo.classMessage("İşlem Hatası", cn), MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonPrepare_Click(object sender, EventArgs e)
    {
      string svr = textBoxServer.Text;
      if (String.IsNullOrEmpty(svr) || svr.Length < 3 || svr.Length > 50)
      {
        MessageBox.Show("Server bilgisi hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      _server = svr;

      string db = textBoxDatabase.Text;
      if (String.IsNullOrEmpty(db) || db.Length < 3 || db.Length > 50)
      {
        MessageBox.Show("Veritabanı bilgisi hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      _database = db;

      string usr = textBoxUser.Text;
      if (String.IsNullOrEmpty(usr) || usr.Length < 3 || usr.Length > 50)
      {
        MessageBox.Show("Kullanıcı bilgisi hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      _user = usr;

      string pass = textBoxPassword.Text;
      if (String.IsNullOrEmpty(pass) || pass.Length < 3 || pass.Length > 50)
      {
        MessageBox.Show("Şifre bilgisi hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      _password = pass;


      string connStrTemp = $"Data Source=\"{_server}\";Initial Catalog=\"{_database}\";Persist Security Info=True;User ID=\"{_user}\";Password=\"{_password}\"";
      richTextBoxSql.Text = connStrTemp;  
      buttonSave.Enabled = true;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      try
      {
        FileOperation fileOperation = new FileOperation();
        ResultObject result = new ResultObject();
        fileOperation.dbFileWrite(out result, richTextBoxSql.Text);
        if (result.Status != ResultStatus.Success)
        {
          MessageBox.Show("Ayarlar kaydedilemedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        this.DialogResult = DialogResult.OK;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
