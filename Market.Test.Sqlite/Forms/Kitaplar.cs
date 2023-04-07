using Market.Entity.Classes.DbClasses.ProductClasses;
using Market.Test.Sqlite.Classes;
using Market.Test.Sqlite.Contexts;
using Market.Test.Sqlite.Helpers;
using Market.Test.Sqlite.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Reflection;

namespace Market.Test.Sqlite.Forms
{
  public partial class Kitaplar : Form
  {
    public Kitaplar()
    {
      InitializeComponent();
    }

    //https://learn.microsoft.com/tr-tr/ef/core/providers/sqlite/?tabs=dotnet-core-cli

    KitapIslemleri kitapIslemleri = new KitapIslemleri();
    ResultObject result = new ResultObject();

    List<Kitap> kitapLisesi = new List<Kitap>();

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
    }

    protected override void OnClosing(CancelEventArgs e)
    {
      base.OnClosing(e);

      ProgramInfo.context?.Dispose();
      ProgramInfo.context = null;
    }

    private void Kitaplar_Load(object sender, EventArgs e)
    {
      Form_Init();
    }
    void Form_Init()
    {
      try
      {
        ProgramInfo SetProgramInfo = new ProgramInfo();

        string dbconn = $"Data Source={
          Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData)}\\DataHouse\\Db\\KitapListesi.db";

        ProgramInfo.context = new SqliteDbContext(dbconn);

        ProgramInfo.context.Database.EnsureCreated();

        //string dbconn = $"Data Source={Application.StartupPath}KitapListesi.db";



        //string dbconn = $"Data Source={Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\Dh\\KitapListesi.db";


        // Uncomment the line below to start fresh with a new database.
        // this.dbContext.Database.EnsureDeleted();



        //this.dbContext.Categories.Load();
        //this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();


        ////string dbconn = $"Data Source=C:\\DBbak\\TestDbs\\KitapListesi.db";
        //string dbconn = $"Data Source={Application.StartupPath}KitapListesi.db";
        //ProgramInfo.context = new SqliteDbContext(dbconn);

        //// Uncomment the line below to start fresh with a new database.
        //// this.dbContext.Database.EnsureDeleted();
        //ProgramInfo.context.Database.EnsureCreated();


        cmbYazar.DataSource = ProgramInfo.context.Yazarlar.Where(t => t.IsDeleted == false && t.IsActive == true).ToList();
        cmbYazar.DisplayMember = "Isim";
        cmbYazar.ValueMember = "Id";

        cmbYayinevi.DataSource = ProgramInfo.context.Yayinevleri.Where(t => t.IsDeleted == false && t.IsActive == true).ToList();
        cmbYayinevi.DisplayMember = "Tanim";
        cmbYayinevi.ValueMember = "Id";
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
    void Listele()
    {
      string opc = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      string title = "Kitap Listele";

      try
      {
        //List<Kitap> kitapListesi = kitapIslemleri.Liste(out result, false);
        //if (result.ResultStatus != Enums.ResultStatus.Success)
        //{
        //  result.Title = title;
        //  result.OriginProcess += $"{opc}\n{result.OriginProcess}";
        //  ShowMessage.MesajGoster(result);
        //  return;
        //}

        kitapLisesi = ProgramInfo.context.Kitaplar.Include(x => x.Yazar).Include(x => x.Yayinevi).Where(t => t.IsDeleted == false).ToList();


        //gvListe.DataSource = ProgramInfo.context.Kitaplar.Where(t => t.IsDeleted == false).ToList();
        gvListe.DataSource = kitapLisesi;



        gvListe.Columns["Yazar"].Visible = false;
        //gvListe.Columns["YazarId"].Visible = false;
        gvListe.Columns["Yayinevi"].Visible = false;
        //gvListe.Columns["YayineviId"].Visible = false;


      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnListele_Click(object sender, EventArgs e)
    {
      Listele();
    }

    private void btnYazarlar_Click(object sender, EventArgs e)
    {
      Forms.Yazarlar yazarlar = new Forms.Yazarlar();
      yazarlar.ShowDialog();

      cmbYazar.DataSource = ProgramInfo.context.Yazarlar.Where(t => t.IsDeleted == false && t.IsActive == true).ToList();
      //cmbYazar.DisplayMember = "Isim";
      //cmbYazar.ValueMember = "Id";
    }

    private void btnYayin_Click(object sender, EventArgs e)
    {
      Yayinevleri yayinevleri = new Yayinevleri();
      yayinevleri.ShowDialog();

      cmbYayinevi.DataSource = ProgramInfo.context.Yayinevleri.Where(t => t.IsDeleted == false && t.IsActive == true).ToList();
      //cmbYayinevi.DisplayMember = "Tanim";
      //cmbYayinevi.ValueMember = "Id";
    }

    private void gvListe_SelectionChanged(object sender, EventArgs e)
    {
      if (gvListe.RowCount == 0 || gvListe.SelectedRows.Count == 0 || gvListe.SelectedRows[0].Index < 0)
        return;

      Kitap kitap = SeciliSatirKitap();

      txtKitapAdi.Text = kitap.Adi;
      txtBarkod.Text = kitap.Barkod;
      txtBaskiYili.Text = kitap.BaskiYili.ToString();
      txtSayfa.Text = kitap.SayfaSayisi.ToString();
      txtAciklama.Text = kitap.Aciklama;


      //ProgramInfo.context.Entry(kitap).Collection(e => e.Yazar).Load();
      kitap.Yazar = ProgramInfo.context.Yazarlar.Single(t => t.Id == kitap.YazarId);
      kitap.Yayinevi = ProgramInfo.context.Yayinevleri.Single(t => t.Id == kitap.YayineviId);

      cmbYazar.SelectedIndex = cmbYazar.FindStringExact(kitap.Yazar.Isim);
      cmbYayinevi.SelectedIndex = cmbYayinevi.FindStringExact(kitap.Yayinevi.Tanim);



      //txtKitapAdi.Text = gvListe.SelectedRows[0].Cells["Adi"].Value.ToString();
      //txtBarkod.Text = gvListe.SelectedRows[0].Cells["Barkod"].Value.ToString();
      //txtBaskiYili.Text = gvListe.SelectedRows[0].Cells["BaskiYili"].Value.ToString();
      //txtSayfa.Text = gvListe.SelectedRows[0].Cells["SayfaSayisi"].Value.ToString();
      //txtAciklama.Text = gvListe.SelectedRows[0].Cells["Aciklama"].Value.ToString();

      //cmbYazar.SelectedIndex = cmbYazar.FindStringExact("test1");
      //cmbYazar.SelectedIndex = cmbYazar.Items.IndexOf("test1");
      //cmbYazar.SelectedItem = cmbYazar.Items.Equals("test1");


      //public Yazar Yazar { get; set; }
      ////public int YazarId { get; set; }
      //public Yayinevi Yayinevi { get; set; }

    }
    Kitap SeciliSatirKitap()
    {
      return ProgramInfo.context.Kitaplar.Find(Convert.ToInt32(gvListe.SelectedRows[0].Cells["Id"].Value.ToString()));
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      DbIslem();
    }
    void DbIslem()
    {
      string opc = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      string title = "Ekle Düzenle Sil";

      Kitap kitap;

      try
      {

        if (radioButtonEkle.Checked)
        {
          kitap = new Kitap();
          kitap.Id = 0;
          kitap.IsActive = true;
          kitap.IsDeleted = false;
          kitap.CreatedOn = DateTime.Now;
          kitap.CreatedBy = "Admin";
          kitap.LastModifiedOn = DateTime.Now;
          kitap.LastModifiedBy = "Admin";

          kitap.Adi = txtKitapAdi.Text;
          kitap.Barkod = txtBarkod.Text;
          kitap.BaskiYili = Convert.ToInt16(txtBaskiYili.Text);
          kitap.SayfaSayisi = Convert.ToInt16(txtSayfa.Text);
          kitap.Aciklama = txtAciklama.Text;

          //cmbYazar.SelectedIndex = cmbYazar.FindStringExact(kitap.Yazar.Isim);

          //string ccc = cmbYazar.Text;
          //string xxx = cmbYazar.ValueMember.ToString(); 
          //string sss = ((Yazar)cmbYazar.SelectedItem).Id.ToString();

          kitap.Yazar = (Yazar)cmbYazar.SelectedItem;
          kitap.YazarId = kitap.Yazar.Id;
          kitap.Yayinevi = (Yayinevi)cmbYayinevi.SelectedItem;
          kitap.YayineviId = kitap.Yayinevi.Id;

          ProgramInfo.context.Entry(kitap).State = Microsoft.EntityFrameworkCore.EntityState.Added;
          ProgramInfo.context.SaveChanges();
        }
        else if (radioButtonDuzenle.Checked)
        {
          if (gvListe.RowCount == 0 || gvListe.SelectedRows.Count == 0 || gvListe.SelectedRows[0].Index < 0)
            return;

          kitap = SeciliSatirKitap();
          kitap.LastModifiedOn = DateTime.Now;
          kitap.LastModifiedBy = "Admin";

          kitap.Adi = txtKitapAdi.Text;
          kitap.Barkod = txtBarkod.Text;
          kitap.BaskiYili = Convert.ToInt16(txtBaskiYili.Text);
          kitap.SayfaSayisi = Convert.ToInt16(txtSayfa.Text);
          kitap.Aciklama = txtAciklama.Text;

          kitap.Yazar = (Yazar)cmbYazar.SelectedItem;
          kitap.YazarId = kitap.Yazar.Id;
          kitap.Yayinevi = (Yayinevi)cmbYayinevi.SelectedItem;
          kitap.YayineviId = kitap.Yayinevi.Id;

          ProgramInfo.context.Entry(kitap).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
          ProgramInfo.context.SaveChanges();
        }
        else if (radioButtonSil.Checked)
        {
          if (gvListe.RowCount == 0 || gvListe.SelectedRows.Count == 0 || gvListe.SelectedRows[0].Index < 0)
            return;

          kitap = SeciliSatirKitap();

          ProgramInfo.context.Entry(kitap).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
          ProgramInfo.context.SaveChanges();
        }

        ListeModu();

        Listele();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnIptal_Click(object sender, EventArgs e)
    {
      ListeModu();
    }

    private void radioButtonEkle_Click(object sender, EventArgs e)
    {
      if (radioButtonEkle.Checked)
      {
        KayitModu();

        txtKitapAdi.Text = "";
        txtBarkod.Text = "";
        txtBaskiYili.Text = "";
        txtSayfa.Text = "";
        txtAciklama.Text = "";
        cmbYazar.SelectedIndex = 0;
        cmbYayinevi.SelectedIndex = 0;
      }
    }

    private void radioButtonDuzenle_Click(object sender, EventArgs e)
    {
      if (radioButtonDuzenle.Checked)
      {
        KayitModu();
      }
    }

    private void radioButtonSil_Click(object sender, EventArgs e)
    {
      if (radioButtonSil.Checked)
      {
        KayitModu();
      }
    }


    void KayitModu()
    {
      radioButtonDuzenle.Enabled = false;
      radioButtonEkle.Enabled = false;
      radioButtonSil.Enabled = false;

      btnListele.Enabled = false;

      btnKaydet.Enabled = true;
      btnIptal.Enabled = true;
    }
    void ListeModu()
    {
      radioButtonDuzenle.Checked = false;
      radioButtonEkle.Checked = false;
      radioButtonSil.Checked = false;

      radioButtonDuzenle.Enabled = true;
      radioButtonEkle.Enabled = true;
      radioButtonSil.Enabled = true;

      btnListele.Enabled = true;

      btnKaydet.Enabled = false;
      btnIptal.Enabled = false;
    }
  }
}


