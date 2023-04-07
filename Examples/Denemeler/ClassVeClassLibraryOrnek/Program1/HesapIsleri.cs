using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenimKutuphanem; //************ yaptığımız kütüphaneyi using alanına ekleyebiliriz


namespace Program1
{
  public partial class HesapIsleri : Form
  {
    public HesapIsleri()
    {
      InitializeComponent();
    }

    HesapClass hesapClass = new HesapClass(); // Program1 içi class
    BenimKutuphanem.Hesaplamalar hesaplamalar = new Hesaplamalar();  // ClassLibrary

    private void HesapIsleri_Load(object sender, EventArgs e)
    {
      radioButtonTopla.Checked = true;
      lblSonuc.Text = string.Empty;
    }

    private void buttonIslem1_Click(object sender, EventArgs e)
    {
      double sayi1 = double.Parse(txtSayi1.Text);
      double sayi2 = Convert.ToDouble(txtSayi2.Text);
      string opr = "";
      if (radioButtonTopla.Checked)
        lblSonuc.Text = (sayi1 + sayi2).ToString();
      else if (radioButtonCikar.Checked)
        lblSonuc.Text = (sayi1 - sayi2).ToString();
      else if (radioButtonCarp.Checked)
        lblSonuc.Text = (sayi1 * sayi2).ToString();
      else if (radioButtonBol.Checked)
        lblSonuc.Text = (sayi1 / sayi2).ToString();
    }

    private void buttonIslem2_Click(object sender, EventArgs e)
    {
      HesapYap();
    }
    void HesapYap()
    {
      try
      {
        double giris1 = double.Parse(txtSayi1.Text);
        double giris2 = double.Parse(txtSayi2.Text);

        switch (OperatorBul())
        {
          case "+":
            lblSonuc.Text = (giris1 + giris2).ToString();
            break;
          case "-":
            lblSonuc.Text = (giris1 - giris2).ToString();
            break;
          case "*":
            lblSonuc.Text = (giris1 * giris2).ToString();
            break;
          case "/":
            lblSonuc.Text = (giris1 / giris2).ToString();
            break;
          default:
            break;

        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Hata oluştu : {ex.Message}");
      }
    }
    string OperatorBul()
    {
      // bu metot ile panel içindeki radiobuttonlar içinde dönüp, radioButton nesnesine atayıp,
      // işaretli olanı buluyoruz ve tag içine yazılan operatör bilgisini geri dönüyoruz
      string opr = "";
      foreach (var control in panelIslemSec.Controls)
      {
        //if (control is RadioButton)
        //{
        RadioButton radio = control as RadioButton;
        if (radio != null && radio.Checked)
          opr = radio.Tag.ToString();
        //}
      }
      return opr;
    }

    private void buttonIslem3_Click(object sender, EventArgs e)
    {
      // Program1 içindeki sınıfa tanımlanan özellikler üzerinden işlem
      try
      {
        hesapClass.sayi1 = double.Parse(txtSayi1.Text);
        hesapClass.sayi2 = double.Parse(txtSayi2.Text);

        switch (OperatorBul())
        {
          case "+":
            lblSonuc.Text = hesapClass.Toplam.ToString();
            break;
          case "-":
            lblSonuc.Text = hesapClass.Fark.ToString();
            break;
          case "*":
            lblSonuc.Text = hesapClass.Carpim.ToString();
            break;
          case "/":
            lblSonuc.Text = hesapClass.Bolum.ToString();
            break;
          default:
            break;

        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Hata oluştu : {ex.Message}");
      }
    }

    private void buttonIslem3m_Click(object sender, EventArgs e)
    {
      // Program1 içindeki sınıfa tanımlanan metot üzerinden işlem
      string sonuc = hesapClass.Islem(txtSayi1.Text, txtSayi2.Text, OperatorBul());
      if (sonuc.StartsWith("Hata"))
        MessageBox.Show(sonuc);
      else
        lblSonuc.Text = sonuc;
    }

    private void buttonIslem4_Click(object sender, EventArgs e)
    {
      // ClassLibrary içindeki sınıfa tanımlanan metot üzerinden işlem
      string sonuc = hesaplamalar.DortIslemIkiSayi(txtSayi1.Text, txtSayi2.Text, OperatorBul());
      if (sonuc.StartsWith("Hata"))
        MessageBox.Show(sonuc);
      else
        lblSonuc.Text = sonuc;
    }


  }
}
