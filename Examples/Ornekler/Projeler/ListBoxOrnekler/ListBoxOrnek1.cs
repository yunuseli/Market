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

namespace Ornekler.Projeler.ListBoxOrnekler
{
  public partial class ListBoxOrnek1 : Form
  {
    public ListBoxOrnek1()
    {
      InitializeComponent();
    }

    private void ListBoxOrnek1_Load(object sender, EventArgs e)
    {
      listBoxSol.SelectionMode = SelectionMode.MultiSimple;
      listBoxSol.Items.Add("AAA");
      listBoxSol.Items.Add("BBB");
      listBoxSol.Items.Add("CCC");
      listBoxSol.Items.Add("DDD");
      listBoxSol.Items.Add("EEE");
    }

    #region Sol Taraf İşlemler

    private void btnSolaEkle_Click(object sender, EventArgs e)
    {
      string giris = txtSolVeri.Text;
      // null, boş veya tamamaen boşluk karakterlerinden oluşuyorsa hata ver
      if (String.IsNullOrEmpty(giris) || String.IsNullOrWhiteSpace(giris))
      {
        MessageBox.Show("Veri Giriniz");
        return;
      }

      ListeyeEkle(true, giris);
    }
    private void btnSolaEkle0_Click(object sender, EventArgs e)
    {
      string giris = txtSolVeri.Text.Trim();
      // trim metdu ile boşluk karakterlerini kaldırıp kontrol
      if (String.IsNullOrEmpty(giris))
      {
        MessageBox.Show("Veri Giriniz");
        return;
      }

      ListeyeEkle(true, giris);
    }
    private void ListeyeEkle(bool basaekle, string veri)
    {
      // Giriş 10 karakter kontrolü
      if (cbSolGirisLimit10.Checked && veri.Length > 10)
      {
        MessageBox.Show("Giriş 10 karakterden uzun olamaz");
        return;
      }

      // Giriş 10 karakter kontrolü
      if (cbSolListeLimit10.Checked && listBoxSol.Items.Count >= 10)
      {
        MessageBox.Show("Listeye 10'dan fazla veri eklenemz");
        return;
      }

      // Giriş 10 karakter kontrolü
      if (cbSolAyniEklenmesin.Checked)
      {
        foreach (var item in listBoxSol.Items)
        {
          //Büyük küçük harf duyarlı olması için :  if (item.ToString() == veri)
          if (item.ToString().ToLower() == veri.ToLower())
          {
            MessageBox.Show("Listeye aynı veri eklenemez");
            return;
          }
        }
      }

      if (basaekle)
        listBoxSol.Items.Insert(0, txtSolVeri.Text);
      else
        listBoxSol.Items.Add(txtSolVeri.Text);
    }

    private void buttonSolSil_Click(object sender, EventArgs e)
    {
      if (listBoxSol.SelectedItem == null)
      {
        MessageBox.Show("Seçim yapınız");
        return;
      }
      else
      {
        //listBoxSol.Items.Remove(listBoxSol.SelectedItem);
        listBoxSol.Items.RemoveAt(listBoxSol.SelectedIndex);
      }
    }
    private void btnSolEnUsteTasi_Click(object sender, EventArgs e)
    {
      // satır seçimi kontrolü
      if (listBoxSol.Items.Count == 0 || listBoxSol.SelectedItem == null || listBoxSol.SelectedIndex < 0)
        return;

      // En Yukarı taşımak için index sıfırdan büyük olmalı
      if (listBoxSol.SelectedIndex < 1)
        return;

      // en başa seçili satırın aynısını ekliyoruz
      listBoxSol.Items.Insert(0, listBoxSol.SelectedItem);

      // eski satırı siliyoruz
      listBoxSol.Items.RemoveAt(listBoxSol.SelectedIndex);

      listBoxSol.SelectedIndex = 0;
    }
    private void btnSolYukariTasi_Click(object sender, EventArgs e)
    {
      // satır seçimi kontrolü
      if (listBoxSol.Items.Count == 0 || listBoxSol.SelectedItem == null || listBoxSol.SelectedIndex < 0)
        return;

      // Yukarı taşımak için index sıfırdan büyük olmalı
      if (listBoxSol.SelectedIndex < 1)
        return;

      if (listBoxSol.SelectedItems.Count == 1)
      {
        // bir önceki indekse seçili satırın aynısını ekliyoruz ve seçiyoruz
        listBoxSol.Items.Insert(listBoxSol.SelectedIndex - 1, listBoxSol.SelectedItem);
        int yenisecim = listBoxSol.SelectedIndex - 2;

        // eski satırı siliyoruz
        listBoxSol.Items.RemoveAt(listBoxSol.SelectedIndex);

        listBoxSol.SetSelected(yenisecim, true);
        return;
      }

      // çoklu seçim
      ListBox gecici = new ListBox();
      for (int i = 0; i < listBoxSol.SelectedItems.Count; i++)
      {
        gecici.Items.Add(listBoxSol.SelectedItems[i]);
      }
      for (int i = 0; i < gecici.Items.Count; i++)
      {
        for (int j = 0; j < listBoxSol.Items.Count; j++)
        {
          if (gecici.Items[i] == listBoxSol.Items[j])
          {
            listBoxSol.Items.Insert(j - 1, gecici.Items[i]);
            listBoxSol.Items.RemoveAt(j + 1);
            break;
          }
        }
      }
      for (int i = 0; i < gecici.Items.Count; i++)
      {
        for (int j = 0; j < listBoxSol.Items.Count; j++)
        {
          if (gecici.Items[i] == listBoxSol.Items[j])
          {
            listBoxSol.SetSelected(j, true);
            break;
          }
        }
      }
    }
    private void btnSolAsagiTasi_Click(object sender, EventArgs e)
    {
      // satır seçimi kontrolü
      if (listBoxSol.Items.Count == 0 || listBoxSol.SelectedItem == null || listBoxSol.SelectedIndex < 0)
        return;

      if (listBoxSol.SelectedItems.Count == 1)
      {
        // Aşağı taşımak için seçili indeks, liste son indeksten küçük olmalı
        if (listBoxSol.SelectedIndex == listBoxSol.Items.Count - 1)
          return;

        // bir önceki indekse seçili satırın aynısını ekliyoruz ve seçiyoruz
        listBoxSol.Items.Insert(listBoxSol.SelectedIndex + 2, listBoxSol.SelectedItem);
        int yenisecim = listBoxSol.SelectedIndex + 1;

        // eski satırı siliyoruz
        listBoxSol.Items.RemoveAt(listBoxSol.SelectedIndex);

        listBoxSol.SetSelected(yenisecim, true);
        return;
      }

      // Aşağı taşımak için seçili son indeks, liste son indeksten küçük olmalı
      int sonindeks = 0;
      for (int i = 0; i < listBoxSol.Items.Count; i++)
      {
        if (listBoxSol.Items[i] == listBoxSol.SelectedItems[listBoxSol.SelectedItems.Count - 1])
        {
          sonindeks = i;
          break;
        }
      }
      if (sonindeks == listBoxSol.Items.Count - 1)
        return;

      ListBox gecici = new ListBox();
      for (int i = 0; i < listBoxSol.SelectedItems.Count; i++)
      {
        gecici.Items.Add(listBoxSol.SelectedItems[i]);
      }
      for (int i = 0; i < gecici.Items.Count; i++)
      {
        for (int j = 0; j < listBoxSol.Items.Count; j++)
        {
          if (gecici.Items[i] == listBoxSol.Items[j])
          {
            listBoxSol.Items.Insert(j - 1, gecici.Items[i]);
            listBoxSol.Items.RemoveAt(j);
            break;
          }
        }
      }
      for (int i = 0; i < gecici.Items.Count; i++)
      {
        for (int j = 0; j < listBoxSol.Items.Count; j++)
        {
          if (gecici.Items[i] == listBoxSol.Items[j])
          {
            listBoxSol.SetSelected(j, true);
            break;
          }
        }
      }
    }
    private void btnSolEnAltaTasi_Click(object sender, EventArgs e)
    {
      // satır seçimi kontrolü
      if (listBoxSol.Items.Count == 0 || listBoxSol.SelectedItem == null || listBoxSol.SelectedIndex < 0)
        return;

      // en sona taşımak için index son indeksten küçük olmalı
      if (listBoxSol.SelectedIndex == listBoxSol.Items.Count - 1)
        return;

      // en sona seçili satırın aynısını ekliyoruz
      listBoxSol.Items.Add(listBoxSol.SelectedItem);

      // eski satırı siliyoruz
      listBoxSol.Items.RemoveAt(listBoxSol.SelectedIndex);

      listBoxSol.SelectedIndex = listBoxSol.Items.Count - 1;
    }
    private void btnSolSecimiTemizle_Click(object sender, EventArgs e)
    {
      listBoxSol.SelectedIndex = -1;
    }
    private void btnSolDigerleriniSec_Click(object sender, EventArgs e)
    {
      // seçili olanlar için geçici liste oluştur
      ListBox gecici = new ListBox();
      for (int i = 0; i < listBoxSol.SelectedItems.Count; i++)
      {
        gecici.Items.Add(listBoxSol.SelectedItems[i]);
      }
      // tümünü seç
      for (int i = 0; i < listBoxSol.Items.Count; i++)
      {
        listBoxSol.SetSelected(i, true);
      }
      // geçici listede  daha önce seçilenleri selected=false işaretle
      for (int i = 0; i < gecici.Items.Count; i++)
      {
        for (int j = 0; j < listBoxSol.Items.Count; j++)
        {
          if (gecici.Items[i] == listBoxSol.Items[j])
          {
            listBoxSol.SetSelected(j, false);
            break;
          }
        }
      }
    }
    private void txtSolVeri_TextChanged(object sender, EventArgs e)
    {
      if (listBoxSol.Items.Count == 0)
        return;

      string arama = txtSolVeri.Text.ToLower();
      if (String.IsNullOrEmpty(arama))
      {
        listBoxSol.SelectedIndex = -1;
        return;
      }

      for (int i = 0; i < listBoxSol.Items.Count; i++)
      {
        if (listBoxSol.Items[i].ToString().ToLower().Contains(arama))
          listBoxSol.SetSelected(i, true);
        else
          listBoxSol.SetSelected(i, false);
      }
    }
    private void btnSolSiralaAZ_Click(object sender, EventArgs e)
    {
      ArrayList geciciliste = new ArrayList();
      foreach (object o in listBoxSol.Items)
        geciciliste.Add(o);

      geciciliste.Sort();

      listBoxSol.Items.Clear();
      foreach (object o in geciciliste)
        listBoxSol.Items.Add(o);
    }
    private void btnSolSiralaZA_Click(object sender, EventArgs e)
    {
      ArrayList geciciliste = new ArrayList();
      foreach (object o in listBoxSol.Items)
        geciciliste.Add(o);

      geciciliste.Sort();
      geciciliste.Reverse();

      listBoxSol.Items.Clear();
      foreach (object o in geciciliste)
        listBoxSol.Items.Add(o);
    }
    private void cbSolSirali_CheckedChanged(object sender, EventArgs e)
    {
      if (cbSolSirali.Checked)
      {
        btnSolSiralaAZ.Enabled = false;
        btnSolSiralaZA.Enabled = false;
        listBoxSol.Sorted = true;
      }
      else
      {
        btnSolSiralaAZ.Enabled = true;
        btnSolSiralaZA.Enabled = true;
        listBoxSol.Sorted = false;
      }
    }
    private void btnSolAynilariSil_Click(object sender, EventArgs e)
    {
      if (listBoxSol.Items.Count < 1)
        return;

      ListBox gecici = new ListBox();
      for (int i = 0; i < listBoxSol.Items.Count; i++)
      {
        gecici.Items.Add(listBoxSol.Items[i]);
      }

      // geçici listede  daha önce seçilenleri selected=false işaretle
      for (int i = 0; i < gecici.Items.Count; i++)
      {
        bool ilkTur = true;

        for (int j = 0; j < listBoxSol.Items.Count; j++)
        {
          if (gecici.Items[i].ToString() == listBoxSol.Items[j].ToString())
          {
            if (ilkTur)
            {
              ilkTur = false;
            }
            else
            {
              listBoxSol.Items.RemoveAt(j);
            }
          }
        }
      }
    }
    private void btnSolTumunuSil_Click(object sender, EventArgs e)
    {
      listBoxSol.Items.Clear();
    }
    #endregion

    #region Sağ Taraf İşlemler

    #endregion

    #region Ara İşlemler
    private void btnOrtaSagaEkle_Click(object sender, EventArgs e)
    {
      if (listBoxSol.SelectedItems.Count < 1)
        return;

      foreach (object item in listBoxSol.SelectedItems)
      {
        listBoxSag.Items.Add(item);
      }
    }
    private void btnOrtaSolaEkle_Click(object sender, EventArgs e)
    {
      if (listBoxSag.SelectedItems.Count < 1)
        return;

      foreach (object item in listBoxSag.SelectedItems)
        listBoxSol.Items.Add(item);
    }
    private void btnOrtaSagaTasi_Click(object sender, EventArgs e)
    {
      if (listBoxSol.SelectedItems.Count < 1)
        return;

      ListBox gecici = new ListBox();
      for (int i = 0; i < listBoxSol.SelectedItems.Count; i++)
      {
        gecici.Items.Add(listBoxSol.SelectedItems[i]);
      }

      // geçici listede  daha önce seçilenleri selected=false işaretle
      for (int i = 0; i < gecici.Items.Count; i++)
      {
        listBoxSag.Items.Add(gecici.Items[i]);

        for (int j = 0; j < listBoxSol.Items.Count; j++)
        {
          if (gecici.Items[i] == listBoxSol.Items[j])
          {
            listBoxSol.Items.RemoveAt(j);
            break;
          }
        }
      }
    }

    private void btnOrtaSolaTasi_Click(object sender, EventArgs e)
    {
      if (listBoxSag.SelectedItems.Count < 1)
        return;

      ArrayList gecici = new ArrayList();
      gecici.AddRange(listBoxSag.SelectedItems);

      foreach (var item in gecici)
      {
        listBoxSol.Items.Add(item);
        listBoxSag.Items.Remove(item);
      }
    }
    private void btnOrtaTumuSaga_Click(object sender, EventArgs e)
    {
      listBoxSag.Items.AddRange(listBoxSol.Items);
      listBoxSol.Items.Clear();
    }
    private void btnOrtaTumuSola_Click(object sender, EventArgs e)
    {
      listBoxSol.Items.AddRange(listBoxSag.Items);
      listBoxSag.Items.Clear();
    }



    //private void gonder(ListBox lst1, ListBox lst2)
    //{
    //  try
    //  {
    //    ArrayList secilenler = new ArrayList();
    //    secilenler.AddRange(lst1.SelectedItems);
    //    foreach (var item in secilenler)
    //    {
    //      lst2.Items.Add(item);
    //      lst1.Items.Remove(item);
    //    }

    //  }
    //  catch (Exception b)
    //  {
    //    MessageBox.Show("Seçim yapmalısınız. " + b.Message);
    //  }
    //}



    #endregion

    private void listBoxSol_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


  }
}
