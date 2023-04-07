using Market.Test.Sqlite.Helpers;
using Market.Test.Sqlite.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;

namespace Market.Test.Sqlite.Forms
{

  //https://stackoverflow.com/questions/65286867/save-changes-in-binded-datagridview-with-filter-active

  public partial class Yayinevleri : Form
  {
    public Yayinevleri()
    {
      InitializeComponent();
    }

    //https://learn.microsoft.com/tr-tr/ef/core/get-started/winforms

    //List<Yayinevi> yayineviListesi = new List<Yayinevi>();
    //BindingSource bs = new BindingSource();

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      ProgramInfo.context.Yayinevleri.Load();

      yayineviBindingSource.DataSource = ProgramInfo.context.Yayinevleri.Local.ToBindingList();
    }
    private void Yayinevleri_Load(object sender, EventArgs e)
    {
      //ProgramInfo.context.Yayinevleri.Where(t => t.IsDeleted == false).Load();
      ////yayineviBindingSource.DataSource = ProgramInfo.context.Yayinevleri.Where(t => t.IsDeleted == false).ToBindingList();
      //yayineviBindingSource.DataSource = ProgramInfo.context.Yayinevleri.Local.Where(t => t.IsDeleted == false).ToList();
      // //yayineviBindingSource.DataSource = ProgramInfo.context.Yayinevleri.Where(t=>t.IsDeleted == false).ToList();
      // gvListe.Refresh();

      //gvListe.DataSource = ProgramInfo.context.Yayinevleri.Where(t => t.IsDeleted == false).ToList();

      //yayineviListesi = ProgramInfo.context.Yayinevleri.Where(t => t.IsDeleted == false).ToList();
      //bs.DataSource = yayineviListesi;
      //gvListe.DataSource = yayineviListesi;

      //ProgramInfo.context.Yayinevleri.Load();

      // gvListe.DataSource = bs;

      Listele();
    }
    void Listele()
    {
      //ProgramInfo.context.Yayinevleri.Load();
      ////bs.DataSource = ProgramInfo.context.Yayinevleri.ToList();
      //// gvListe.Refresh();

      //// yayineviListesi = ProgramInfo.context.Yayinevleri.Where(t => t.IsDeleted == false).ToList();
      //// bs.DataSource = yayineviListesi;
      //// gvListe.DataSource = yayineviListesi;

      ////string dbconn = $"Data Source={Application.StartupPath}KitapListesi.db";
      ////Contexts.SqliteDbContext sqliteDbContext = new Contexts.SqliteDbContext(dbconn);

      ////ProgramInfo.context.Yayinevleri.Where(t => t.IsDeleted == false).Load();
      ////BindingList<Yayinevi>  yayineviBs = ProgramInfo.context.Yayinevleri;

      //yayineviBindingSource.DataSource = ProgramInfo.context.Yayinevleri.Local.ToBindingList();
      //yayineviBindingSource.DataSource = ProgramInfo.context.Yayinevleri.Local.ToBindingList();

    }

    private void gvListe_SelectionChanged(object sender, EventArgs e)
    {
      //if (ProgramInfo.context != null)
      //{
      //  var category = (Category)this.gvListe.CurrentRow.DataBoundItem;

      //  if (category != null)
      //  {
      //    ProgramInfo.context.Entry(category).Collection(e => e.Products).Load();
      //  }
      //}
    }

    private void btnIslem_Click(object sender, EventArgs e)
    {
      ProgramInfo.context.SaveChanges();

      gvListe.Refresh();
    }

    private void btnListele_Click(object sender, EventArgs e)
    {
      Listele();
    }
  }
}
