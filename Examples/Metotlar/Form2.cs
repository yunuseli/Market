using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    Form1 form1 = new Form1();

    private void Form2_Load(object sender, EventArgs e)
    {
      Form1.publicStaticSayi = 0;
      Form1.publicStaticMethod();
      Form1.publicStaticMethodTopla(6, 9);


      form1.publicSayi = 1;
      form1.publicMethod();
    }


    private void button1_Click(object sender, EventArgs e)
    {
      form1.publicSayi++; 


      MessageBox.Show(Form1.publicStaticSayi.ToString());
      Form1.publicStaticSayi = 999;


      MessageBox.Show(form1.publicSayi.ToString());
      form1.publicSayi = 9999;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Form1.IntMinMaxGoster();

      int kelimesayisi = form1.KacKelimeVar("    Cumartesi günü kursa geldik, birazdan gidicez    ");
      MessageBox.Show($"Kelime sayısı = {kelimesayisi}");

    }
  }
}
