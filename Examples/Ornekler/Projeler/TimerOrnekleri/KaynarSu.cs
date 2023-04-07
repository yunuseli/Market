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
  public partial class KaynarSu : Form
  {
    public KaynarSu()
    {
      InitializeComponent();
    }

    private ProgressBar progressBar2;

    int kaynamanoktasi = 0;
    int ayar = 0;
    private void KaynarSu_Load(object sender, EventArgs e)
    {
      lblAyar.Text = "";
      lblKaynama.Text = "";
      pictureBox1.BackColor= Color.Green;
      pictureBox1.Width = 0;
      progressBar1.ForeColor = Color.Green;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      kaynamanoktasi += ayar;
      lblAyar.Text = ayar.ToString();
      lblKaynama.Text = kaynamanoktasi.ToString();

      if (kaynamanoktasi>=100)
      {
        kaynamanoktasi = 100; 
        timer1.Stop();
      }

      progressBar1.Value = kaynamanoktasi;

      pictureBox1.Width = kaynamanoktasi;
      if (kaynamanoktasi>33)
      {
        pictureBox1.BackColor = Color.Yellow;
        progressBar1.ForeColor = Color.Yellow;
      }
      if (kaynamanoktasi > 66)
      {
        pictureBox1.BackColor = Color.Red;
        progressBar1.ForeColor = Color.Red;
      }

    }

    private void btnDusuk_Click(object sender, EventArgs e)
    {
      timer1.Start();
      ayar = 1;
    }
    private void btnOrta_Click(object sender, EventArgs e)
    {
      timer1.Start();
      ayar = 2;
    }
    private void btnYuksek_Click(object sender, EventArgs e)
    {
      timer1.Start();
      ayar = 3;
    }
  }
}
