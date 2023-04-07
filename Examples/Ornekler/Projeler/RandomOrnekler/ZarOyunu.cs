using Ornekler.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler.Projeler.RandomOrnekler
{
  public partial class ZarOyunu : Form
  {
    public ZarOyunu()
    {
      InitializeComponent();
    }

    Random rnd = new Random();
    int sayi = 1;
    int timerSayac = 1;

    private void ZarOyunu_Load(object sender, EventArgs e)
    {

    }

    private void zar(int sayi)
    {
      Console.Beep();
      switch (sayi)
      {
        case 1:
          pictureBoxZar.Image = Resources.zar1;
          break;
        case 2:
          pictureBoxZar.Image = Resources.zar2;
          break;
        case 3:
          pictureBoxZar.Image = Resources.zar3;
          break;
        case 4:
          pictureBoxZar.Image = Resources.zar4;
          break;
        case 5:
          pictureBoxZar.Image = Resources.zar5;
          break;
        case 6:
          pictureBoxZar.Image = Resources.zar6;
          break;
        default:
          break;
      }
    }
    void butonlarPasif()
    {
      btnZarAt.Enabled = false;
      btnZarAtThread.Enabled = false;
      btnZarAtTimer.Enabled = false;
    }
    void butonlarAktif()
    {
      btnZarAt.Enabled = true;
      btnZarAtThread.Enabled = true;
      btnZarAtTimer.Enabled = true;
    }

    private void btnZarAt_Click(object sender, EventArgs e)
    {
      butonlarPasif();
      sayi = rnd.Next(1, 7);
      zar(sayi);
      butonlarAktif();
    }

    private void btnZarAtThread_Click(object sender, EventArgs e)
    {
      butonlarPasif();
      for (int i = 0; i < 6; i++)
      {
        sayi = rnd.Next(1, 7);
        zar(sayi);
        Application.DoEvents();
        Thread.Sleep(200);
      }
      butonlarAktif();
    }

    private void btnZarAtTimer_Click(object sender, EventArgs e)
    {
      butonlarPasif();
      timerZar.Start();
      butonlarAktif();
    }
    private void timerZar_Tick(object sender, EventArgs e)
    {

      sayi = rnd.Next(1, 7);
      zar(sayi);
      timerSayac++;
      if (timerSayac == 7)
      {
        timerZar.Stop();
        timerSayac = 1;
      }
    }
  }
}
