using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler.Projeler.RadiobuttonOrnekler
{
  public partial class DortIslem : Form
  {
    public DortIslem()
    {
      InitializeComponent();
    }

    private void DortIslem_Load(object sender, EventArgs e)
    {
      lblSonuc.Visible = false;
    }

    private void btnHesapla_Click(object sender, EventArgs e)
    {
      double sayi1, sayi2, sonuc;
      sayi1 = Convert.ToDouble(txtSayi1.Text);
      sayi2 = Convert.ToDouble(txtSayi2.Text);
      lblSonuc.Visible = true;

      if (rbTopla.Checked)
      {
        sonuc = sayi1 + sayi2;
        lblSonuc.Text = sonuc.ToString();
      }
      else if (rbCikar.Checked)
      {
        sonuc = sayi1 - sayi2;
        lblSonuc.Text = sonuc.ToString();
      }
      else if (rbCarp.Checked)
      {
        sonuc = sayi1 * sayi2;
        lblSonuc.Text = sonuc.ToString();
      }
      else if (rbBol.Checked)
      {
        sonuc = sayi1 / sayi2;
        lblSonuc.Text = sonuc.ToString();
      }
      else
      {
        MessageBox.Show("Bir İşlem Seçin");
        return;
      }
    }
  }
}
