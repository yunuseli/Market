using Market.Entity.Classes.ResponseClasses;
using Market.Entity.Enums;
using Market.Presentation.WinUI.Classes.HelperClasses;
using Market.Presentation.WinUI.Classes.ProgramClasses;
using System.Reflection;

namespace Market.Presentation.WinUI.Forms.MainForms
{
  public partial class Main : Form
  {
    public Main()
    {
      InitializeComponent();
    }


    // Lokal Nesneler - Değişkenler
    ResultObject result;


    private void Main_Load(object sender, EventArgs e)
    {
      StartSettings();

      //Form form =  new ProductForms.CategoriesList() { Text = "Kategori Listesi" };
      //FormAc(form);
    }
    void StartSettings()
    {
      try
      {
        result = new ResultObject();


        this.Text = $"Market - ({ProgramInfo.Session.CurrenUser.FullName})";
        lblStripClientName.Text = $"Client:{ProgramInfo.Session.CurrentClient.ClientName}";
        lblStripClientIP.Text = $"IP:{ProgramInfo.Session.CurrentClient.ClientIp}";


      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void Main_FormClosed(object sender, FormClosedEventArgs e)
    {
      //Application.Exit();
      ((Login)Application.OpenForms["Login"]).ProgramiKapat();
    }

    private void ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
      string formName = menuItem.Tag.ToString();

      if (String.IsNullOrEmpty(formName) || String.IsNullOrWhiteSpace(formName))
        return;

      ToolStripMenuIslem(formName);
    }
    private void ToolStripMenuIslem(string formName)
    {
      Form form = new Form();
      switch (formName)
      {
        case "MarketUserList":
          //Forms.MarketUserForms.MarketUserList marketUserList = new MarketUserForms.MarketUserList() { Text = "Sistem Kullanıcı Listesi" };
          form = new MarketUserForms.MarketUserList() { Text = "Sistem Kullanıcı Listesi" };
          //FormAc(marketUserList);
          break;
        case "CategoriesList":
          form = new ProductForms.CategoriesList() { Text = "Ürün Kategori İşlemleri" };
          break;
        case "BrandModelList":
          form = new ProductForms.BrandModelList { Text = "Marka - Model İşlemleri" };
          break;
        case "WeatherInfo":
          form = new InfoForms.WeatherInfo() { Text = "Hava Durumu - Döviz Kurları" };
          break;
        case "MusteriListesi":
          form = new Forms.MusteriFormlari.MusteriListesi() { Text = "Müşteri Listesi" };
          break;
        default:
          break;
      }

      if (!String.IsNullOrEmpty(form.Text))
        FormAc(form);
    }
    private void FormAc(Form form)
    {
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Form durumu";

      try
      {
        bool status = false;
        foreach (var item in this.MdiChildren)
        {
          if (item.Text == form.Text)
          {
            status = true;
            item.Activate();
            break;
          }
        }
        if (!status)
        {
          form.MdiParent = this;
          form.ShowInTaskbar = false;
          form.WindowState = FormWindowState.Maximized;
          form.ShowIcon = false;
          form.Show();
        }
      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"İşlem hatası";
        result.Description = ex.Message;
        ShowMessage.MesajGoster(result);
      }
    }

  } // EOF
}
