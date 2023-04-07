using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler.Projeler.PanelOrnekler
{
  public partial class AlanCevreHesap : Form
  {
    public AlanCevreHesap()
    {
      InitializeComponent();
    }

    private void AlanCevreHesap_Load(object sender, EventArgs e)
    {
      this.Height = 315;
      this.Width = 315;

      //panelKare.Visible = false;
      //panelDikdortgen.Visible = false;

      lblDikdortgeninAlanı.Text = string.Empty;
      lblDikdortgeninCevresi.Text = string.Empty;
      lblKareninAlanı.Text = string.Empty;
      lblKareninCevresi.Text = string.Empty;
    }

    private void btnKare_Click(object sender, EventArgs e)
    {
      panelDikdortgen.Visible = false;
      panelKare.Visible = true;
      panelKare.Dock = DockStyle.Fill;
    }

    private void btnDikdortgen_Click(object sender, EventArgs e)
    {
      panelKare.Visible = false;
      panelDikdortgen.Visible = true;
      panelDikdortgen.Dock = DockStyle.Fill;
    }

    private void btnKareHesapla_Click(object sender, EventArgs e)
    {
      int kareBilgi = Convert.ToInt32(txtKare.Text);
      int kareAlanı = kareBilgi * kareBilgi;
      int kareCevre = kareBilgi * 4;
      lblKareninAlanı.Text = kareAlanı.ToString();
      lblKareninCevresi.Text = kareCevre.ToString();
    }

    private void btnDikdortgenHesapla_Click(object sender, EventArgs e)
    {
      int DikdortgenKısaBilgi = Convert.ToInt32(txtKısaKenar.Text);
      int DikdortgenUzunBilgi = Convert.ToInt32(txtUzunKenar.Text);
      int DikdortgenAlanı = DikdortgenKısaBilgi * DikdortgenUzunBilgi;
      int DikdortgenCevre = (DikdortgenKısaBilgi * 2) + (DikdortgenUzunBilgi * 2);
      lblDikdortgeninAlanı.Text = DikdortgenAlanı.ToString();
      lblDikdortgeninCevresi.Text = DikdortgenCevre.ToString();
    }
  }
}
