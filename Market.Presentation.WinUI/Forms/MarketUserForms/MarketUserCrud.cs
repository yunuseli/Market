using Market.Business.Classes.MarketUserManagers;
using Market.Entity.Classes.DbClasses.UserClasses;
using Market.Entity.Classes.ResponseClasses;
using Market.Entity.Enums;
using Market.Presentation.WinUI.Classes.HelperClasses;
using Market.Presentation.WinUI.Classes.ProgramClasses;
using System.Reflection;

namespace Market.Presentation.WinUI.Forms.MarketUserForms
{
  public partial class MarketUserCrud : Form
  {
    public MarketUserCrud()
    {
      InitializeComponent();
    }

    byte[] ImageBytes = null;
    string ImageType = string.Empty;

    // Business katmanı sınıf
    private MarketUserManager marketUserManager = new MarketUserManager();

    // Form çağrıldığında gönderilecek bilgilecek
    public MarketUser user { get; set; }
    public CrudOperations operation { get; set; }

    // Form işlemi tamamlandığında geri dönülecek cevap
    public ResultObject result = new ResultObject();

    private void MarketUserCrud_Load(object sender, EventArgs e)
    {
      StartSettings();
    }
    void StartSettings()
    {
      switch (operation)
      {
        case CrudOperations.Insert:
          txtEmail.Text = string.Empty;
          txtName.Text = string.Empty;
          txtPassword.Text = string.Empty;
          txtSurName.Text = string.Empty;
          rbActive.Checked = true;
          dtBirthDate.Value = DateTime.Now;

          btnSave.Text = "Ekle";
          lblIslem.Text = "Ekle";
          this.BackColor = Color.PaleTurquoise;
          break;
        case CrudOperations.Update:
          txtEmail.Text = user.EMail;
          txtName.Text = user.Name;
          txtPassword.Text = user.Password;
          txtSurName.Text = user.SurName;
          rbActive.Checked = user.IsActive;
          dtBirthDate.Value = user.BirthDate;

          btnSave.Text = "Kaydet";
          lblIslem.Text = "Düzenle";
          this.BackColor = Color.SkyBlue;
          break;
        case CrudOperations.Delete:
          txtEmail.Text = user.EMail;
          txtName.Text = user.Name;
          txtPassword.Text = user.Password;
          txtSurName.Text = user.SurName;
          rbActive.Checked = user.IsActive;
          dtBirthDate.Value = user.BirthDate;

          txtEmail.ReadOnly = true;
          txtName.ReadOnly = true;
          txtPassword.ReadOnly = true;
          txtSurName.ReadOnly = true;
          rbActive.Enabled = false;
          rbPassive.Enabled = false;
          dtBirthDate.Enabled = false;

          btnSave.Text = "Sil";
          lblIslem.Text = "Sil";
          this.BackColor = Color.PaleVioletRed;
          break;
        default:
          this.Close();
          break;
      }
    }

    //    if (dataSet.Tables[0].Rows.Count == 1)
    //{
    //    Byte[] data = new Byte[0];
    //    data = (Byte[]) (dataSet.Tables[0].Rows[0]["pic"]);
    //    MemoryStream mem = new MemoryStream(data);
    //    yourPictureBox.Image= Image.FromStream(mem);
    //}

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }
    private void MarketUserCrud_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (this.DialogResult != DialogResult.OK)
        this.DialogResult = DialogResult.Cancel;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      switch (operation)
      {
        case CrudOperations.Delete:
          DeleteData();
          break;
        case CrudOperations.Insert:
          InsertData();
          break;
        case CrudOperations.Update:
          UpdateData();
          break;
      }
    }

    bool DataControls()
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Veri Kontrol";
      result.ResultStatus = ResultStatus.Error;

      try
      {
        string name = txtName.Text;
        if (String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name) || name.Length < 2 || name.Length > 20)
        {
          result.Message = $"Ad bilgisi hatalı";
          ShowMessage.MesajGoster(result);
          return false;
        }

        string surname = txtSurName.Text;
        if (String.IsNullOrEmpty(surname) || String.IsNullOrWhiteSpace(surname) || surname.Length < 2 || surname.Length > 20)
        {
          result.Message = $"Soyad bilgisi hatalı";
          ShowMessage.MesajGoster(result);
          return false;
        }

        string email = txtEmail.Text;
        if (String.IsNullOrEmpty(email) || String.IsNullOrWhiteSpace(email) || email.Length < 4 || email.Length > 20 || !email.Contains("@"))
        {
          result.Message = $"Email bilgisi hatalı";
          ShowMessage.MesajGoster(result);
          return false;
        }

        string password = txtPassword.Text;
        if (String.IsNullOrEmpty(password) || String.IsNullOrWhiteSpace(password) || password.Length < 1 || password.Length > 20)
        {
          result.Message = $"Şifre bilgisi hatalı";
          ShowMessage.MesajGoster(result);
          return false;
        }

        // Bilgiler doğru, verileri doldur
        user.Name = name;
        user.SurName = surname;
        user.EMail = email;
        user.Password = password;
        user.BirthDate = dtBirthDate.Value;

        if (ImageBytes != null)
        {
          user.ImageBytes = ImageBytes;
          user.ImageType = ImageType;
        }

        user.IsActive = false;
        if (rbActive.Checked)
          user.IsActive = true;

        //user.IsDeleted = false;

        return true;
      }
      catch (Exception ex)
      {
        result.Message = $"İşlem Hatası";
        result.Description = ex.Message;
        ShowMessage.MesajGoster(result);
        return false;
      }
    }

    void ReturnResult()
    {
      if (result.ResultStatus != ResultStatus.Success)
      {
        ShowMessage.MesajGoster(result);
        return;
      }

      this.DialogResult = DialogResult.OK;
    }

    void DeleteData()
    {
      marketUserManager.DeleteMarketUser(out result, user.Id, CrudOperations.Delete, ProgramInfo.Session.CurrenUser);
      ReturnResult();
    }
    void InsertData()
    {
      if (!DataControls()) return;
      marketUserManager.InsertMarketUser(out result, user, ProgramInfo.Session.CurrenUser);
      ReturnResult();
    }
    void UpdateData()
    {
      if (!DataControls()) return;
      marketUserManager.UpdateMarketUser(out result, user, ProgramInfo.Session.CurrenUser);
      ReturnResult();
    }

    private void btnAddPhto_Click(object sender, EventArgs e)
    {
      AddPhoto();
    }
    bool AddPhoto()
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Resim Yükleme";
      result.ResultStatus = ResultStatus.Error;

      try
      {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Multiselect = false;
        if (ofd.ShowDialog() == DialogResult.OK)
        {
          string fileName = ofd.FileName;
          var fi = new FileInfo(ofd.FileName);

          lblFileInfo.Text = fileName;
          lblPhotoInfo.Text = $"{(fi.Length / 1024).ToString("0:0.0")} KB";

          string ext = Path.GetExtension(ofd.FileName);
          if (!ext.Contains("jpg") && !ext.Contains("jpeg") && !ext.Contains("png"))
          {
            result.Message = $"Resim formatı uygun değil, jpeg yada png olmalı";
            ShowMessage.MesajGoster(result);
            pbImage.Image = null;
            return false;
          }
          if (fi.Length > 500000)
          {
            result.Message = $"Seçilen dosya boyutu uygun değil (Maks : 500 KB)";
            ShowMessage.MesajGoster(result);
            pbImage.Image = null;
            return false;
          }

          ImageBytes = GetImageBytes(ofd.FileName);
          if (ImageBytes.Length == 0 || ImageBytes == null)
          {
            result.Message = $"Resim dosyası çevrilemedi";
            ShowMessage.MesajGoster(result);
            pbImage.Image = null;
            return false;
          }

          ImageType = ext.Replace(".", "");

          pbImage.Image = Image.FromStream(new MemoryStream(ImageBytes));
          pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

          lblPhotoInfo.Text = $"{(ImageBytes.Length / 1024).ToString("0:0.0")} KB / w: {pbImage.Image.Size.Width} h: {pbImage.Image.Size.Height}";
        }

        return true;
      }
      catch (Exception ex)
      {
        result.Message = $"İşlem Hatası";
        result.Description = ex.Message;
        ShowMessage.MesajGoster(result);

        pbImage.Image = null;
        ImageBytes = null;

        return false;
      }
    }

    private byte[] GetImageBytes(string filePath)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Resim Çevrim İşlemi";
      try
      {
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
          using (BinaryReader br = new BinaryReader(fs))
          {
            return br.ReadBytes((int)fs.Length);
          }
        }
      }
      catch (Exception ex)
      {
        result.Message = $"İşlem Hatası";
        result.Description = ex.Message;
        ShowMessage.MesajGoster(result);
        return null;
      }
    }



  } // EOF
}
