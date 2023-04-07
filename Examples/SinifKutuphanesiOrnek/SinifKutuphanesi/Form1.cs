using Kutuphane2;
using Diziler;

namespace SinifKutuphanesi
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    BenimKutuphanem.Hesaplamalar hesaplamalar = new BenimKutuphanem.Hesaplamalar();

    Diziler.StackSinifi stackSinifi = new StackSinifi();
    Diziler.QueueSinifi queueSinifi = new QueueSinifi();

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      double sonuc = hesaplamalar.Toplama(textBox1.Text, textBox2.Text);
      if (double.IsNaN(sonuc))
      {

        MessageBox.Show("Sayýlar hatalý");
      }
      else
      {
        label1.Text = sonuc.ToString();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Kutuphane2.Test test = new Kutuphane2.Test();


      MessageBox.Show(test.KareBul(textBox3.Text).ToString());
    }

    private void buttonStackEkle_Click(object sender, EventArgs e)
    {
      stackSinifi.Ekle(textBoxYigin.Text);

      listBox2.DataSource = stackSinifi.Liste();
    }

    private void buttonStackGetir_Click(object sender, EventArgs e)
    {
      listBox1.Items.Add(stackSinifi.Getir());

      listBox2.DataSource = stackSinifi.Liste();
    }

    private void buttonQEkle_Click(object sender, EventArgs e)
    {
      queueSinifi.Ekle(textBoxYigin.Text);

      listBox2.DataSource = queueSinifi.Liste();
    }

    private void buttonQGetir_Click(object sender, EventArgs e)
    {
      listBox1.Items.Add(queueSinifi.Getir());

      listBox2.DataSource = queueSinifi.Liste();
    }

    private void buttonTemizle1_Click(object sender, EventArgs e)
    {
      listBox1.Items.Clear();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Araba araba = new Araba();
      araba.Marka = "BMW";
      araba.Model = "320";
      araba.Yil = 2015;

      MessageBox.Show($"Marka: {araba.Marka},Model: {araba.Model}, Yýl: {araba.Yil}");
      MessageBox.Show(araba.Veri());
      MessageBox.Show(araba.Data);
    }
  }
}




//< Project Sdk = "Microsoft.NET.Sdk.WindowsDesktop" >


//  < PropertyGroup >

//    < TargetFramework > net6.0 </ TargetFramework >

//    < ImplicitUsings > enable </ ImplicitUsings >

//    < Nullable > enable </ Nullable >

//    < UseWindowsForms > true </ UseWindowsForms >

//    < OutputType > Library </ OutputType >

//  </ PropertyGroup >

//</ Project >