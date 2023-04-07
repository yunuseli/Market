using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMak
{
  public partial class HesapMakinasi : Form
  {
    public HesapMakinasi()
    {
      InitializeComponent();
    }

    private void HesapMakinasi_Load(object sender, EventArgs e)
    {
      labelSonuc.Text = string.Empty;
    }

    private void button_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      //Matematik matematik = new Matematik();
      //labelSonuc.Text = matematik.hesapla(textBoxSayi1.Text, textBoxSayi2.Text, btn.Text);
      labelSonuc.Text = Matematik.hesapla(textBoxSayi1.Text, textBoxSayi2.Text, btn.Text);
    }

    //void hesapla(string s1, string s2, string opr)
    //{
    //  try
    //  {
    //    int sayi1 = int.Parse(s1);
    //    int sayi2 = int.Parse(s2);
    //    switch (opr)
    //    {
    //      case "+":
    //        labelSonuc.Text = (sayi1 + sayi2).ToString();
    //        break;
    //      case "-":
    //        labelSonuc.Text = (sayi1 - sayi2).ToString();
    //        break;
    //      case "*":
    //        labelSonuc.Text = (sayi1 * sayi2).ToString();
    //        break;
    //      case "/":
    //        labelSonuc.Text = (sayi1 / sayi2).ToString();
    //        break;
    //      default:
    //        break;
    //    }
    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //  }
    //}
  }
}
