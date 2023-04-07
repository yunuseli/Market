using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler.Projeler.MouseOrnekler
{
  public partial class BeniYakala : Form
  {
    public BeniYakala()
    {
      InitializeComponent();
    }

    Random rnd = new Random();
    int butonBoyut = 50;

    private void BeniYakala_Load(object sender, EventArgs e)
    {
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.MinimumSize = new System.Drawing.Size(100, 100);
      
      btnYakala.Top = rnd.Next(0, this.Height - 40 - butonBoyut);
      btnYakala.Left = rnd.Next(0, this.Width - 15 - butonBoyut);
      btnYakala.Width = butonBoyut;
      btnYakala.Height = butonBoyut;
    }

    private void btnYakala_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Tebrikler");
      butonBoyut = 50;
      btnYakala.Top = rnd.Next(0, this.Height - 40 - butonBoyut);
      btnYakala.Left = rnd.Next(0, this.Width - 15 - butonBoyut);
      btnYakala.Width = butonBoyut;
      btnYakala.Height = butonBoyut;
    }

    private void BeniYakala_SizeChanged(object sender, EventArgs e)
    {
      int h = this.Height - 40 - butonBoyut;
      int w = this.Width - 15 - butonBoyut;
      if (h < 0 || w < 0)
      {
        if (h < w)
          butonBoyut += h;
        else
          butonBoyut += w;
      }

      btnYakala.Top = rnd.Next(0, this.Height - 40 - butonBoyut);
      btnYakala.Left = rnd.Next(0, this.Width - 15 - butonBoyut);
      btnYakala.Width = butonBoyut;
      btnYakala.Height = butonBoyut;
    }

    private void btnYakala_MouseHover(object sender, EventArgs e)
    {
      if (this.Height - 40 - butonBoyut - 5 > 0 && this.Width - 15 - butonBoyut - 5 > 0)
        butonBoyut += 5;

      btnYakala.Top = rnd.Next(0, this.Height - 40 - butonBoyut);
      btnYakala.Left = rnd.Next(0, this.Width - 15 - butonBoyut);
      btnYakala.Width = butonBoyut;
      btnYakala.Height = butonBoyut;
    }

    private void btnYakala_MouseClick(object sender, MouseEventArgs e)
    {

    }

    private void btnYakala_MouseEnter(object sender, EventArgs e)
    {

    }
  }
}
