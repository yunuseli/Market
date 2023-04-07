using Market.Entity.Classes.ResponseClasses;
using Market.Entity.Enums;
using Market.Presentation.WinUI.Classes.HelperClasses;
using System.Reflection;

namespace Market.Presentation.WinUI.Forms.HelperForms
{
  public partial class ImageFromFileForm : Form
  {
    public ImageFromFileForm()
    {
      InitializeComponent();
    }

    public byte[] ImageBytes { get; set; }
    public string ImageType { get; set; }

    // Form işlemi tamamlandığında geri dönülecek cevap
    public ResultObject result = new ResultObject();

    private void MarketUserCrud_Load(object sender, EventArgs e)
    {
      btnSave.Enabled = false;
    }
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
      this.DialogResult = DialogResult.OK;
    }

    private void btnAddPhto_Click(object sender, EventArgs e)
    {
      if (AddPhoto())
        btnSave.Enabled = true;
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
