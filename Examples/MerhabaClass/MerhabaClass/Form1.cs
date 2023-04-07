using System;
using MerhabaClassKutuphanesi;

namespace MerhabaClass
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    Araba araba = new Araba();

    Islemler islemler = new Islemler();


    private void Form1_Load(object sender, EventArgs e)
    {

    }
    private void button1_Click(object sender, EventArgs e)
    {
      Araba araba = new Araba();
      araba.Marka = "Nissan";
      araba.Model = "ePower";
      araba.ModelYili = 2020;

      //string veri = $"{araba.Marka}/{araba.Model}/{araba.ModelYili}";
      //MessageBox.Show(veri);

      MessageBox.Show(araba.Veri);
    }

    private void button2_Click(object sender, EventArgs e)
    {

      araba.sabitSayi = 10;
      MessageBox.Show(araba.sabitSayi.ToString());
    }

    private void button3_Click(object sender, EventArgs e)
    {
      toplamIslemi();
    }

    void toplamIslemi()
    {
      try
      {
        islemler.Sayi1 = Convert.ToInt32(textBox1.Text);
        islemler.Sayi2 = Convert.ToInt32(textBox2.Text);
        MessageBox.Show(islemler.Toplam.ToString());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
    private void button4_Click(object sender, EventArgs e)
    {
      MessageBox.Show(islemler.toplama(textBox1.Text, textBox2.Text));
    }
    private void button5_Click(object sender, EventArgs e)
    {
      MerhabaClassKutuphanesi.Islemler islemler2 = new MerhabaClassKutuphanesi.Islemler();
      
      MessageBox.Show(islemler2.Toplama(textBox1.Text, textBox2.Text));


      MerhabaClassKutuphanesi.DiziIslemleri.Diziler diziler = new MerhabaClassKutuphanesi.DiziIslemleri.Diziler();
    }
  }
}