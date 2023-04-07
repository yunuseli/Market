using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void btnAc_Click(object sender, EventArgs e)
        {
            if (lstProjeler.Items.Count == 0)
                return;

            if (lstProjeler.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Lütfen seçim yapınız");
                return;
            }
            string secim = lstProjeler.SelectedItems[0].ToString();

            if (secim.StartsWith("1."))
            {
                Projeler.CarpmaOperatorsuzCarpma carpmaOperatorsuzCarpma = new Projeler.CarpmaOperatorsuzCarpma();
                carpmaOperatorsuzCarpma.ShowDialog();
            }

            if (secim.StartsWith("2."))
            {
                Projeler.SayininKacBasamaklıOldugunuBulma sayininKacBasamaklıOldugunuBulma = new Projeler.SayininKacBasamaklıOldugunuBulma();
                sayininKacBasamaklıOldugunuBulma.ShowDialog();
            }

            if (secim.StartsWith("3."))
            {
                Projeler.MukemmelSayiyiBulma mukemmelSayiyiBulma = new Projeler.MukemmelSayiyiBulma();
                mukemmelSayiyiBulma.ShowDialog();
            }

            if (secim.StartsWith("4."))
            {
                Projeler.OrtalamaHesabı ortalamaHesabı = new Projeler.OrtalamaHesabı();
                ortalamaHesabı.ShowDialog();
            }

            if (secim.StartsWith("5."))
            {
                Projeler.GirilenKelimeyiTerstenYazma girilenKelimeyiTerstenYazma = new Projeler.GirilenKelimeyiTerstenYazma();
                girilenKelimeyiTerstenYazma.ShowDialog();
            }

            if (secim.StartsWith("6."))
            {
                Projeler.KelimeninHarfleriniSagaAtma kelimeninHarfleriniSagaAtma = new Projeler.KelimeninHarfleriniSagaAtma();
                kelimeninHarfleriniSagaAtma.ShowDialog();
            }

            if (secim.StartsWith("7."))
            {
                Projeler.PolindromKontrolu polindromKontrolu = new Projeler.PolindromKontrolu();
                polindromKontrolu.ShowDialog();
            }

            if (secim.StartsWith("8."))
            {
                Projeler.OgrenciNotOrtalama ogrenciNotOrtalama = new Projeler.OgrenciNotOrtalama();
                ogrenciNotOrtalama.ShowDialog();
            }

            if (secim.StartsWith("9."))
            {
                Projeler.KDVEkleme kDVEkleme = new Projeler.KDVEkleme();
                kDVEkleme.ShowDialog();
            }

            if (secim.StartsWith("10."))
            {
                Projeler.Siramatik siramatik = new Projeler.Siramatik();
                siramatik.ShowDialog();
            }
        }


    }
}
