using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler.Projeler.Algoritma.Asansor
{
  public partial class Asansor2 : Form
  {
    public Asansor2()
    {
      InitializeComponent();
    }

    int asansorBulunduguKat = 0;
    int hareketYonu = 0; // 1 = Yukarı | 2 = Aşağı
    int hareketKatYukseklik = 65;
    int hareketSayac = 0;
    int hareketSayacMaks = 0;

    private void Asansor1_Load(object sender, EventArgs e)
    {
      pictureBoxAsansor.BackColor = Color.Yellow;

      CagriButonlariHazir();
      asansorBulunduguKat = 5;
    }

    void CagriButonlariHazir()
    {
      btnKat0.BackColor = Color.DodgerBlue;
      btnKat1.BackColor = Color.DodgerBlue;
      btnKat2.BackColor = Color.DodgerBlue;
      btnKat3.BackColor = Color.DodgerBlue;
      btnKat4.BackColor = Color.DodgerBlue;
      btnKat5.BackColor = Color.DodgerBlue;
    }

    void KatDongu(int cagriKat)
    {
      if (cagriKat > asansorBulunduguKat)
      {
        hareketSayacMaks = (cagriKat - asansorBulunduguKat) * hareketKatYukseklik;
        hareketYonu = 1;
      }
      else
      {
        hareketSayacMaks = (asansorBulunduguKat - cagriKat) * hareketKatYukseklik;
        hareketYonu = 2;
      }

    }


    private void btnKat0_Click(object sender, EventArgs e)
    {
      CagriButonlariHazir();
      btnKat0.BackColor = Color.OrangeRed;
      KatDongu(0);
      timerAsansorHareket.Start();
      asansorBulunduguKat = 0;
    }

    private void btnKat1_Click(object sender, EventArgs e)
    {
      CagriButonlariHazir();
      btnKat1.BackColor = Color.OrangeRed;
      KatDongu(1);
      timerAsansorHareket.Start();
      asansorBulunduguKat = 1;
    }

    private void btnKat2_Click(object sender, EventArgs e)
    {
      CagriButonlariHazir();
      btnKat2.BackColor = Color.OrangeRed;
      KatDongu(2);
      timerAsansorHareket.Start();
      asansorBulunduguKat = 2;
    }

    private void btnKat3_Click(object sender, EventArgs e)
    {
      CagriButonlariHazir();
      btnKat3.BackColor = Color.OrangeRed;
      KatDongu(3);
      timerAsansorHareket.Start();
      asansorBulunduguKat = 3;
    }

    private void btnKat4_Click(object sender, EventArgs e)
    {
      CagriButonlariHazir();
      btnKat4.BackColor = Color.OrangeRed;
      KatDongu(4);
      timerAsansorHareket.Start();
      asansorBulunduguKat = 4;
    }

    private void btnKat5_Click(object sender, EventArgs e)
    {
      CagriButonlariHazir();
      btnKat5.BackColor = Color.OrangeRed;
      KatDongu(5);
      timerAsansorHareket.Start();
      asansorBulunduguKat = 5;
    }

    private void timerAsansorHareket_Tick(object sender, EventArgs e)
    {
      hareketSayac++;

      if (hareketYonu == 1)
      {
        panelAsansor.Location = new Point(panelAsansor.Location.X, panelAsansor.Location.Y - 1);
      }
      else
      {
        panelAsansor.Location = new Point(panelAsansor.Location.X, panelAsansor.Location.Y + 1);
      }

      if (hareketSayac >= hareketSayacMaks)
      {
        timerAsansorHareket.Stop();
        hareketSayac = 0;
      }
    }
  }
}
