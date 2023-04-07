using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler.Projeler.ChekOrnekler
{
  public partial class CheckOrnek1 : Form
  {
    public CheckOrnek1()
    {
      InitializeComponent();
    }

    private void CheckOrnek1_Load(object sender, EventArgs e)
    {
      label4.Text = string.Empty;
    }


    // bir işlem devam ederken diğerini engelleme
    bool islemvar = false;
    private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (islemvar)
        return;

      islemvar = true;

      int indeks = checkedListBox1.SelectedIndex;

      for (int i = 0; i < checkedListBox1.Items.Count; i++)
      {
        if (i == indeks)
          continue;

        checkedListBox1.SetItemChecked(i, false);
      }

      islemvar = false;
    }

    private void btnBilgi_Click(object sender, EventArgs e)
    {
      #region Ön Kontroller
      if (String.IsNullOrEmpty(txtAd.Text) || String.IsNullOrEmpty(txtSoyad.Text))
      {
        MessageBox.Show("İsim Giriniz");
        return;
      }
      if (checkBoxFizik.CheckState == CheckState.Unchecked &&
      checkBoxKimya.CheckState == CheckState.Unchecked &&
      checkBoxMatematik.CheckState == CheckState.Unchecked)
      {
        MessageBox.Show("Ders Seçiniz");
        return;
      }
      if (checkedListBox1.CheckedItems.Count == 0)
      {
        MessageBox.Show("Okul Seçiniz");
        return;
      }

      //if (radioButtonErkek.Checked == false && radioButtonKadın.Checked == false)
      if (!radioButtonErkek.Checked && !radioButtonKadın.Checked)
      {
        MessageBox.Show("Cinsiyet Seçiniz");
        return;
      }
      #endregion

      string ad, soyad, cinsiyet = "", dersler = "", okul = "";

      ad = txtAd.Text;
      soyad = txtSoyad.Text;

      if (radioButtonErkek.Checked == true)
        cinsiyet = "Erkek";
      else if (radioButtonKadın.Checked)
        cinsiyet = "Kadın";

      if (checkBoxMatematik.Checked == true)
      {
        if (String.IsNullOrEmpty(dersler))
          dersler += "Matematik";
        else
          dersler += ", Matematik";
      }
      if (checkBoxFizik.Checked)
      {
        if (String.IsNullOrEmpty(dersler))
          dersler = dersler + "Fizik";
        else
          dersler += ", Fizik";
      }
      if (checkBoxKimya.Checked == true)
      {
        if (String.IsNullOrEmpty(dersler))
          dersler += checkBoxKimya.Text;
        else
          dersler += ", " + checkBoxKimya.Text;
      }

      okul = checkedListBox1.CheckedItems[0].ToString();

      label4.Text = $"İsim: {ad} {soyad}\nCinsiyet: {cinsiyet}\nDersler: {dersler}\nOkul :{okul}";
    }

  }
}
