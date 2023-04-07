using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler
{
  public partial class Menu : Form
  {
    public Menu()
    {
      InitializeComponent();
    }

    private void Menu_Load(object sender, EventArgs e)
    {
      menuStrip1.AllowMerge = false;
    }

    private void Menu_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void ToolStripMenuItem_yasHesaplama_Click(object sender, EventArgs e)
    {
      Projeler.DatetimeOrnekler.YasHesaplama yasHesaplama = new Projeler.DatetimeOrnekler.YasHesaplama();
      yasHesaplama.MdiParent = this;
      //yasHesaplama.Dock = DockStyle.Fill;      
      yasHesaplama.Show();
    }

    private void ToolStripMenuItem_zarOyunu_Click(object sender, EventArgs e)
    {
      Projeler.RandomOrnekler.ZarOyunu zarOyunu = new Projeler.RandomOrnekler.ZarOyunu();
      zarOyunu.MdiParent = this;
      zarOyunu.Show();
    }

    private void kronometreToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Projeler.TimerOrnekleri.Kronometre kronometre = new Projeler.TimerOrnekleri.Kronometre();
      kronometre.MdiParent = this;
      kronometre.Show();
    }

    private void asanssor1ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Projeler.Algoritma.Asansor.Asansor1 asansor = new Projeler.Algoritma.Asansor.Asansor1();
      asansor.MdiParent = this; ;
      asansor.Show();
    }

    private void asansor2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Projeler.Algoritma.Asansor.Asansor2 asansor = new Projeler.Algoritma.Asansor.Asansor2();
      asansor.MdiParent = this;
      asansor.Show();
    }

    private void beniYakalaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Projeler.MouseOrnekler.BeniYakala beniYakala = new Projeler.MouseOrnekler.BeniYakala();
      beniYakala.MdiParent = this;
      beniYakala.Show();
    }

    private void renkSecimiToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Projeler.DigerOrnekler.RenkSecimi renkSecimi = new Projeler.DigerOrnekler.RenkSecimi();
      renkSecimi.MdiParent = this;
      renkSecimi.Show();
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Projeler.ComboboxOrnekler.MarkaModel markaModel = new Projeler.ComboboxOrnekler.MarkaModel();
      markaModel.MdiParent = this;
      markaModel.Show();
    }

    private void listBoxornek1ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Projeler.ListBoxOrnekler.ListBoxOrnek1 listBoxOrnek1 = new Projeler.ListBoxOrnekler.ListBoxOrnek1();
      listBoxOrnek1.MdiParent = this;
      listBoxOrnek1.Show();
    }

    private void suKaynatToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Projeler.TimerOrnekleri.KaynarSu kaynarSu = new Projeler.TimerOrnekleri.KaynarSu();
      kaynarSu.MdiParent = this;
      kaynarSu.Show();
    }

    private void kelimeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Projeler.DigerOrnekler.Kelime kelime = new Projeler.DigerOrnekler.Kelime();
      kelime.MdiParent = this;
      kelime.Show();
    }

    private void alanCevreHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Projeler.PanelOrnekler.AlanCevreHesap alanCevreHesap = new Projeler.PanelOrnekler.AlanCevreHesap();
      alanCevreHesap.MdiParent = this;
      alanCevreHesap.Show();
    }

    private void dortislemToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Projeler.RadiobuttonOrnekler.DortIslem dortIslem = new Projeler.RadiobuttonOrnekler.DortIslem();
      dortIslem.MdiParent = this; 
      dortIslem.Show();
    }

    private void checkBoxOrnek1ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Projeler.ChekOrnekler.CheckOrnek1 checkOrnek1 = new Projeler.ChekOrnekler.CheckOrnek1();
      checkOrnek1.MdiParent = this;
      checkOrnek1.Show();
    }
  }
}
