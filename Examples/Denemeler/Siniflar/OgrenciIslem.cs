using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar
{
  public partial class OgrenciIslem : Form
  {
    public OgrenciIslem()
    {
      InitializeComponent();
    }

    bool islemVar = false;

    bool islemModuEkle = false;

    DataTable dt = new DataTable();

    private void OgrenciIslem_Load(object sender, EventArgs e)
    {
      //Form başlangıç işlemleri
      toolTipInfo.SetToolTip(btnEkle, "Ekle");
      toolTipInfo.SetToolTip(btnGuncelle, "Güncelle");
      toolTipInfo.SetToolTip(btnSil, "Sil");
      toolTipInfo.SetToolTip(btnKaydet, "Kaydet");
      toolTipInfo.SetToolTip(btnIptal, "İptal");
      pnlIslem.Enabled = false;
      this.WindowState = FormWindowState.Maximized;
      gvListe.EditMode = DataGridViewEditMode.EditProgrammatically;
      gvListe.ReadOnly = true;
      gvListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      gvListe.AllowUserToAddRows = false;


      // Veriyi oluştur
      Ogrenci ogrenci = new Ogrenci();
      ogrenci.Ad = "Mahsun";
      ogrenci.Soyad = "Kırmızıgül";
      ogrenci.Sinif = "4";
      ogrenci.Sube = "B";
      ogrenci.Numara = 1258;
      ogrenci.Not1 = 36;
      ogrenci.Not2 = 85;
      ogrenci.Not3 = 96;
      ogrenci.Ortalama = (ogrenci.Not1 + ogrenci.Not2 + ogrenci.Not3) / 3;
      if (ogrenci.Ortalama > 50)
        ogrenci.Durum = Ogrenci.DurumGectiKaldi.Gecti;
      else
        ogrenci.Durum = Ogrenci.DurumGectiKaldi.Kaldi;

      //Veriyi kullan
      txtAd.Text = ogrenci.Ad;
      txtSoyad.Text = ogrenci.Soyad;
      txtSinif.Text = ogrenci.Sinif;
      txtSube.Text = ogrenci.Sube;
      txtNumara.Text = ogrenci.Numara.ToString();
      txtNot1.Text = ogrenci.Not1.ToString();
      txtNot2.Text = ogrenci.Not2.ToString();
      txtNot3.Text = ogrenci.Not3.ToString();
      lblOrtalama.Text = ogrenci.Ortalama.ToString();
      if (ogrenci.Durum == Ogrenci.DurumGectiKaldi.Gecti)
        lblDurum.Text = "Geçti";
      else
        lblDurum.Text = "Kaldı";

      // Tabloyu oluştur
      dt.Columns.Add("Ad");
      dt.Columns.Add("Soyad");
      dt.Columns.Add("Sinif");
      dt.Columns.Add("Sube");
      dt.Columns.Add("Numara");
      dt.Columns.Add("Not1");
      dt.Columns.Add("Not2");
      dt.Columns.Add("Not3");
      dt.Columns.Add("Ortalama");
      dt.Columns.Add("Durum");





      //Veriyi tabloya yükle

      string durum = "";
      if (ogrenci.Durum == Ogrenci.DurumGectiKaldi.Gecti)
        durum = "Geçti";
      else
        durum = "Kaldı";
      dt.Rows.Add(
      ogrenci.Ad,
      ogrenci.Soyad,
      ogrenci.Sinif,
      ogrenci.Sube,
      ogrenci.Numara,
      ogrenci.Not1,
      ogrenci.Not2,
      ogrenci.Not3,
      ogrenci.Ortalama.ToString("#.##"),
      durum
        );

      // Data gridte göster
      gvListe.DataSource = dt;













      //gvListe.EditMode = DataGridViewEditMode.EditProgrammatically;
      //gvListe.ReadOnly = true;
      //gvListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      //gvListe.AllowUserToAddRows = false;

      //VarsayilanVeri();

    }

    void VarsayilanVeri()
    {
      Ogrenci ogrenci1 = new Ogrenci();
      ogrenci1.Ad = "Fuat";
      ogrenci1.Soyad = "AŞIK";
      ogrenci1.Sinif = "5";
      ogrenci1.Sube = "A";
      ogrenci1.Numara = 123;
      ogrenci1.Not1 = 50;
      ogrenci1.Not2 = 60;
      ogrenci1.Not3 = 90;
      ogrenci1.Ortalama = (ogrenci1.Not1 + ogrenci1.Not2 + ogrenci1.Not3) / 3;
      ogrenci1.Durum = Ogrenci.DurumGectiKaldi.Gecti;

      Ogrenci ogrenci2 = new Ogrenci();
      ogrenci2.Ad = "Kağan";
      ogrenci2.Soyad = "AZAR";
      ogrenci2.Sinif = "5";
      ogrenci2.Sube = "A";
      ogrenci2.Numara = 321;
      ogrenci2.Not1 = 100;
      ogrenci2.Not2 = 100;
      ogrenci2.Not3 = 100;
      ogrenci2.Ortalama = (ogrenci2.Not1 + ogrenci2.Not2 + ogrenci2.Not3) / 3;
      ogrenci2.Durum = Ogrenci.DurumGectiKaldi.Gecti;

      islemVar = true;

      DataTable dt = new DataTable();
      dt.Columns.Add("Ad", typeof(string));
      dt.Columns.Add("Soyad", typeof(string));
      dt.Columns.Add("Sinif", typeof(string));
      dt.Columns.Add("Sube", typeof(string));
      dt.Columns.Add("Numara", typeof(int));
      dt.Columns.Add("Not1", typeof(double));
      dt.Columns.Add("Not2", typeof(double));
      dt.Columns.Add("Not3", typeof(double));
      dt.Columns.Add("Ortalama", typeof(double));
      dt.Columns.Add("Durum", typeof(bool));

      dt.Rows.Add(
      ogrenci1.Ad,
      ogrenci1.Soyad,
      ogrenci1.Sinif,
      ogrenci1.Sube,
      ogrenci1.Numara,
      ogrenci1.Not1,
      ogrenci1.Not2,
      ogrenci1.Not3,
      ogrenci1.Ortalama,
      ogrenci1.Durum
        );
      dt.Rows.Add(
      ogrenci2.Ad,
      ogrenci2.Soyad,
      ogrenci2.Sinif,
      ogrenci2.Sube,
      ogrenci2.Numara,
      ogrenci2.Not1,
      ogrenci2.Not2,
      ogrenci2.Not3,
      ogrenci2.Ortalama,
      ogrenci2.Durum
        );

      gvListe.DataSource = dt;
      islemVar = false;

      if (gvListe.Rows.Count > 0)
      {
        gvListe.Rows[0].Selected = true;
        veriDoldur();
      }
      // gvListe_SelectionChanged(null, null);

    }

    private void gvListe_SelectionChanged2(object sender, EventArgs e)
    {
      if (islemVar) return;
      if (gvListe.SelectedRows.Count < 1)
        return;
      if (gvListe.CurrentCell == null)
        return;

      veriDoldur();
    }
    void veriDoldur()
    {
      txtAd.Text = gvListe.SelectedRows[0].Cells["Ad"].Value.ToString();
      txtAd.Text = gvListe.SelectedRows[0].Cells["Ad"].Value.ToString();
      txtSoyad.Text = gvListe.SelectedRows[0].Cells["Soyad"].Value.ToString();
      txtSinif.Text = gvListe.SelectedRows[0].Cells["Sinif"].Value.ToString();
      txtSube.Text = gvListe.SelectedRows[0].Cells["Sube"].Value.ToString();
      txtNumara.Text = gvListe.SelectedRows[0].Cells["Numara"].Value.ToString();
      txtNot1.Text = gvListe.SelectedRows[0].Cells["Not1"].Value.ToString();
      txtNot2.Text = gvListe.SelectedRows[0].Cells["Not2"].Value.ToString();
      txtNot3.Text = gvListe.SelectedRows[0].Cells["Not3"].Value.ToString();
      lblOrtalama.Text = Convert.ToDouble(gvListe.SelectedRows[0].Cells["Ortalama"].Value).ToString("#.##");

      int durum = Convert.ToInt32(gvListe.SelectedRows[0].Cells["Durum"].Value);
      Ogrenci.DurumGectiKaldi durumGectiKaldi = (Ogrenci.DurumGectiKaldi)durum;
      if (durumGectiKaldi == Ogrenci.DurumGectiKaldi.Gecti)
        lblDurum.Text = "Geçti";
      else
        lblDurum.Text = "Kaldı";
    }

    void KayitModuYeni()
    {
      pnlIslem.Enabled = true;
      pnlUst.Enabled = false;
      txtAd.Text = string.Empty;
      txtSoyad.Text = string.Empty;
      txtSinif.Text = string.Empty;
      txtSube.Text = string.Empty;
      txtNumara.Text = string.Empty;
      txtNot1.Text = string.Empty;
      txtNot2.Text = string.Empty;
      txtNot3.Text = string.Empty;

      islemModuEkle = true;
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
      KayitModuYeni();
    }

    void KayitModuListe()
    {
      pnlIslem.Enabled = false;
      pnlUst.Enabled = true;
    }
    private void btnIptal_Click(object sender, EventArgs e)
    {
      KayitModuListe();
    }

    void IslemEkle()
    {
      try
      {
        //ön kontroller yapılacak
        double not1 = 0;
        if (double.TryParse(txtNot1.Text, out not1) == false)
        {
          MessageBox.Show("Not1 hatalı");
        }


        Ogrenci yeniOgrenci = new Ogrenci();
        yeniOgrenci.Ad = txtAd.Text;
        yeniOgrenci.Soyad = txtSoyad.Text;
        yeniOgrenci.Sinif = txtSinif.Text;
        yeniOgrenci.Sube = txtSube.Text;
        yeniOgrenci.Numara = Convert.ToInt32(txtNumara.Text);
        yeniOgrenci.Not1 = Convert.ToDouble(txtNot1.Text);
        yeniOgrenci.Not2 = Convert.ToDouble(txtNot2.Text);
        yeniOgrenci.Not3 = Convert.ToDouble(txtNot3.Text);
        yeniOgrenci.Ortalama = (yeniOgrenci.Not1 + yeniOgrenci.Not2 + yeniOgrenci.Not3) / 3;
        if (yeniOgrenci.Ortalama > 50)
          yeniOgrenci.Durum = Ogrenci.DurumGectiKaldi.Gecti;
        else
          yeniOgrenci.Durum = Ogrenci.DurumGectiKaldi.Kaldi;

        //// Veriyi tabloda güncelle
        //foreach (DataRow row in dt.Rows)
        //{
        //  if (
        //    row["Sinif"].ToString() == gvListe.SelectedRows[0].Cells["Sinif"].Value.ToString() &&
        //    row["Sube"].ToString() == gvListe.SelectedRows[0].Cells["Sube"].Value.ToString() &&
        //    row["Numara"].ToString() == gvListe.SelectedRows[0].Cells["Numara"].Value.ToString() 
        //    )
        //  {
        //    row["Ad"] = yeniOgrenci.Ad;
        //    row["Ad"] = yeniOgrenci.Ad;
        //    row["Ad"] = yeniOgrenci.Ad;

        //  }

        //}


        //Veriyi tabloya yükle
        string durum = "";
        if (yeniOgrenci.Durum == Ogrenci.DurumGectiKaldi.Gecti)
          durum = "Geçti";
        else
          durum = "Kaldı";
        dt.Rows.Add(
        yeniOgrenci.Ad,
        yeniOgrenci.Soyad,
        yeniOgrenci.Sinif,
        yeniOgrenci.Sube,
        yeniOgrenci.Numara,
        yeniOgrenci.Not1,
        yeniOgrenci.Not2,
        yeniOgrenci.Not3,
        yeniOgrenci.Ortalama.ToString("#.##"),
        durum
          );

        // Data gridte göster
        gvListe.DataSource = dt;


        KayitModuListe();


      }
      catch (Exception ex)
      {
        MessageBox.Show("Hata Oluştu : " + ex.Message);
      }

    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      if (islemModuEkle)
        IslemEkle();
      //else
      //  IslemDuzenle();
    }

    void KayitModuDuzenle()
    {
      pnlIslem.Enabled = true;
      pnlUst.Enabled = false;
      txtAd.Text = gvListe.SelectedRows[0].Cells["Ad"].Value.ToString();
      txtSoyad.Text = gvListe.SelectedRows[0].Cells["Soyad"].Value.ToString();
      txtSinif.Text = gvListe.SelectedRows[0].Cells["Sinif"].Value.ToString();
      txtSube.Text = gvListe.SelectedRows[0].Cells["Sube"].Value.ToString();
      txtNumara.Text = gvListe.SelectedRows[0].Cells["Numara"].Value.ToString();
      txtNot1.Text = gvListe.SelectedRows[0].Cells["Not1"].Value.ToString();
      txtNot2.Text = gvListe.SelectedRows[0].Cells["Not2"].Value.ToString();
      txtNot3.Text = gvListe.SelectedRows[0].Cells["Not3"].Value.ToString();

      islemModuEkle = false;
    }
    private void btnGuncelle_Click(object sender, EventArgs e)
    {
      KayitModuDuzenle();
    }
  }
}
