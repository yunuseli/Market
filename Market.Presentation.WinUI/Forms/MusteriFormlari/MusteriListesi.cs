using Market.Business.Classes.MusteriYonetimi;
using Market.Entity.Classes.DbClasses.MusteriSiniflari;
using Market.Entity.Classes.ResponseClasses;
using Market.Presentation.WinUI.Classes.ProgramClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Presentation.WinUI.Forms.MusteriFormlari
{
  public partial class MusteriListesi : Form
  {
    public MusteriListesi()
    {
      InitializeComponent();
    }

    ResultObject result = new ResultObject();
    MusteriSinifi musteriSinifi = new MusteriSinifi();
    bool veriYukleniyor = false;
    private void MusteriListesi_Load(object sender, EventArgs e)
    {
      gvListe.EditMode = DataGridViewEditMode.EditProgrammatically;
      gvListe.ReadOnly = true;
      gvListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      gvListe.AllowUserToAddRows = false;
    }

    private void btnListele_Click(object sender, EventArgs e)
    {
      Listele();
    }
    void Listele()
    {
      veriYukleniyor = true;
      List<Musteri> musteriler = musteriSinifi.MusteriListesi(out result, false);
      gvListe.DataSource = musteriler;
      veriYukleniyor = false;
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
      Ekle();
    }
    void Ekle()
    {
      Musteri yeniMusteri = new Musteri();
      yeniMusteri.Ad = txtAd.Text;
      yeniMusteri.Soyad = txtSoyad.Text;
      yeniMusteri.Telefon = txtTelefon.Text;
      yeniMusteri.IsDeleted = false;
      yeniMusteri.IsActive = true;

      musteriSinifi.MusteriEkle(out result, yeniMusteri, ProgramInfo.Session.CurrenUser);
      Listele();
    }

    private void gvListe_SelectionChanged(object sender, EventArgs e)
    {
      if (veriYukleniyor) return;
      txtAd.Text = gvListe.SelectedRows[0].Cells["Ad"].Value.ToString();
      txtSoyad.Text = gvListe.SelectedRows[0].Cells["Soyad"].Value.ToString();
      txtTelefon.Text = gvListe.SelectedRows[0].Cells["Telefon"].Value.ToString();
    }

    private void btnDosyadan_Click(object sender, EventArgs e)
    {
      DosyadanVeriAl();
    }
    void DosyadanVeriAl()
    {
      try
      {
        OpenFileDialog ofd = new OpenFileDialog();
        if (ofd.ShowDialog() != DialogResult.OK)
        {
          return;
        }

        //List<Musteri> musteriler = new List<Musteri>();

        string[] satirlar = File.ReadAllLines(ofd.FileName);

        bool ilksatir = true;
        foreach (string satir in satirlar)
        {
          if (ilksatir)
          {
            ilksatir = false;
            continue;
          }

          string[] kolonlar = satir.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

          Musteri musteri = new Musteri();
          musteri.Ad = kolonlar[0];
          musteri.Soyad = kolonlar[1];
          musteri.Telefon = kolonlar[2];
          musteri.IsActive = true;
          musteri.IsDeleted = false;

          musteriSinifi.MusteriEkle(out result, musteri, ProgramInfo.Session.CurrenUser);

          // musteriler.Add(musteri);
        }
        Listele();

        //veriYukleniyor = true;
        //gvListe.DataSource = musteriler;
        //veriYukleniyor = false;



      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
