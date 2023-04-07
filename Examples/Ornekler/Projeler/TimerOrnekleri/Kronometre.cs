using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler.Projeler.TimerOrnekleri
{
  public partial class Kronometre : Form
  {
    public Kronometre()
    {
      InitializeComponent();
    }
    int dakika = 0, saniye = 0, salise = 0;   
    
    private void Kronometre_Load(object sender, EventArgs e)
    {
      this.BackColor = System.Drawing.Color.Azure;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Kronometre";
    }

    private void btnBaslat_Click(object sender, EventArgs e)
    {
      this.BackColor = System.Drawing.Color.Yellow;
      tmrKronometre.Start();
      btnDurdur.Text = "DURDUR";
    }

    private void btnDurdur_Click(object sender, EventArgs e)
    {
      if (btnDurdur.Text == "DURDUR")
      {
        this.BackColor = System.Drawing.Color.Green;
        btnDurdur.Text = "SIFIRLA";
        tmrKronometre.Stop();
      }
      else
      {
        this.BackColor = System.Drawing.Color.Azure;
        btnDurdur.Text = "DURDUR";
        dakika = 0;
        saniye = 0;
        salise = 0;
        lblDakika.Text = String.Format("{0:D2}", dakika);
        lblSaniye.Text = String.Format("{0:D2}", saniye);
        lblSalise.Text = String.Format("{0:D2}", salise);
      }

    }

    private void tmrKronometre_Tick(object sender, EventArgs e)
    {
      salise++;
      if (salise == 100)
      {
        salise = 0;
        saniye++;
        if (saniye == 60)
        {
          saniye = 0;
          dakika++;
        }
      }
      lblDakika.Text = String.Format("{0:D2}", dakika);
      lblSaniye.Text = String.Format("{0:D2}", saniye);
      lblSalise.Text = String.Format("{0:D2}", salise);
    }
  }
}
