using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkProje
{
  public partial class Ders1 : Form
  {
    public Ders1()
    {
      InitializeComponent();
    }

    private void Ders1_Load(object sender, EventArgs e)
    {

    }

    private void btnMesaj_Click(object sender, EventArgs e)
    {
      MessageBox.Show(txtMesaj.Text);
    }

    private void btnTopla_Click(object sender, EventArgs e)
    {
      txtOperator.Text = btnTopla.Text;
    }
    private void btnCikart_Click(object sender, EventArgs e)
    {
      txtOperator.Text = btnCikart.Text;
    }
    private void btnCarp_Click(object sender, EventArgs e)
    {
      txtOperator.Text = btnCarp.Text;
    }
    private void btnBol_Click(object sender, EventArgs e)
    {
      txtOperator.Text = btnBol.Text;
    }

    private void btnHesapla_Click(object sender, EventArgs e)
    {
      int sonuc = 0;
      string opr = txtOperator.Text;
      switch (opr)
      {
        case "+":
          sonuc = int.Parse(txtSayi1.Text) + int.Parse(txtSayi2.Text);
          break;
        case "-":
          sonuc = int.Parse(txtSayi1.Text) - int.Parse(txtSayi2.Text);
          break;
        case "*":
          sonuc = int.Parse(txtSayi1.Text) * int.Parse(txtSayi2.Text);
          break;
        case "/":
          sonuc = int.Parse(txtSayi1.Text) / int.Parse(txtSayi2.Text);
          break;
        default:
          //MessageBox.Show($"Operatör Hatalı : {opr}");
          test();
          break;
      }

      txtSonuc.Text = sonuc.ToString();
    }

    private void btnMetotTest_Click(object sender, EventArgs e)
    {
      test();
    }
    private void test()
    {
      MessageBox.Show("Hata");
    }
  }
}
