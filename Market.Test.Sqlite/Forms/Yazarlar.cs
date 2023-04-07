
using Market.Test.Sqlite.Classes;
using Market.Test.Sqlite.Helpers;
using Market.Test.Sqlite.Models;
using System.Reflection;

namespace Market.Test.Sqlite.Forms
{
  public partial class Yazarlar : Form
  {
    public Yazarlar()
    {
      InitializeComponent();
    }

    YazarIslemleri yazarIslemleri = new YazarIslemleri();
    ResultObject result = new ResultObject();

    private void Yazarlar_Load(object sender, EventArgs e)
    {
      Listele();
    }

    private void btnListele_Click(object sender, EventArgs e)
    {
      Listele();
    }
    void Listele()
    {
      string opc = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      string title = "Yazar Listele";

      try
      {
        List<Yazar> yazaListesi = yazarIslemleri.Liste(out result, false);
        if (result.ResultStatus != Enums.ResultStatus.Success)
        {
          result.Title = title;
          result.OriginProcess += $"{opc}\n{result.OriginProcess}";
          ShowMessage.MesajGoster(result);
          return;
        }

        BindingSource bs = new BindingSource();
        //bs.DataSource = ProgramInfo.context.Yazarlar.Local.ToBindingList();
        bs.DataSource = yazarIslemleri.Liste(out result, false);
        gvListe.DataSource = bs;

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void gvListe_SelectionChanged(object sender, EventArgs e)
    {
      if (gvListe.RowCount == 0 || gvListe.SelectedRows.Count == 0 || gvListe.SelectedRows[0].Index < 0)
        return;

      txtAd.Text = gvListe.SelectedRows[0].Cells["Ad"].Value.ToString();
      txtSoyad.Text = gvListe.SelectedRows[0].Cells["Soyad"].Value.ToString();

    }

    Yazar SeciliSatirYazar()
    {
      return ProgramInfo.context.Yazarlar.Find(Convert.ToInt32(gvListe.SelectedRows[0].Cells["Id"].Value.ToString()));

      //Yazar yazar = new Yazar();

      //yazar.Id = Convert.ToInt32(gvListe.SelectedRows[0].Cells["Id"].Value.ToString());
      //yazar.IsActive = Convert.ToBoolean(gvListe.SelectedRows[0].Cells["IsActive"].Value.ToString());
      //yazar.IsDeleted = Convert.ToBoolean(gvListe.SelectedRows[0].Cells["IsDeleted"].Value.ToString());
      //yazar.CreatedOn = Convert.ToDateTime(gvListe.SelectedRows[0].Cells["CreatedOn"].Value.ToString());
      //yazar.CreatedBy = gvListe.SelectedRows[0].Cells["CreatedBy"].Value.ToString();
      //yazar.LastModifiedOn = Convert.ToDateTime(gvListe.SelectedRows[0].Cells["LastModifiedOn"].Value.ToString());
      //yazar.LastModifiedBy = gvListe.SelectedRows[0].Cells["LastModifiedBy"].Value.ToString();

      //yazar.Ad = gvListe.SelectedRows[0].Cells["Ad"].Value.ToString();
      //yazar.Soyad = gvListe.SelectedRows[0].Cells["Soyad"].Value.ToString();

      // return yazar;
    }

    private void btnIslem_Click(object sender, EventArgs e)
    {
      DbIslem();
    }
    void DbIslem()
    {
      string opc = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      string title = "Yazar Ekle Düzenle Sil";

      Yazar yazar;

      if (radioButtonEkle.Checked)
      {
        yazar = new Yazar();
        yazar.Id = 0;
        yazar.IsActive = true;
        yazar.IsDeleted = false;
        yazar.CreatedOn = DateTime.Now;
        yazar.CreatedBy = "Admin";
        yazar.LastModifiedOn = DateTime.Now;
        yazar.LastModifiedBy = "Admin";

        yazar.Ad = txtAd.Text;
        yazar.Soyad = txtSoyad.Text;

        yazarIslemleri.Ekle(out result, yazar);
      }
      else if (radioButtonDuzenle.Checked)
      {
        if (gvListe.RowCount == 0 || gvListe.SelectedRows.Count == 0 || gvListe.SelectedRows[0].Index < 0)
          return;

        yazar = SeciliSatirYazar();
        yazar.Ad = txtAd.Text;
        yazar.Soyad = txtSoyad.Text;
        yazarIslemleri.Duzenle(out result, yazar);
      }
      else if (radioButtonSil.Checked)
      {
        if (gvListe.RowCount == 0 || gvListe.SelectedRows.Count == 0 || gvListe.SelectedRows[0].Index < 0)
          return;

        yazar = SeciliSatirYazar();
        yazarIslemleri.Sil(out result, yazar);
      }

      if (result.ResultStatus != Enums.ResultStatus.Success)
      {
        result.Title = title;
        result.OriginProcess += $"{opc}\n{result.OriginProcess}";
        ShowMessage.MesajGoster(result);
        return;
      }

      Listele();
    }
  }


}