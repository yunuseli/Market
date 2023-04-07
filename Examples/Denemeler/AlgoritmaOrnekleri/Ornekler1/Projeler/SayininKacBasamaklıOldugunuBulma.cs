using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler1.Projeler
{
    public partial class SayininKacBasamaklıOldugunuBulma : Form
    {
        public SayininKacBasamaklıOldugunuBulma()
        {
            InitializeComponent();
        }

        private void SayininKacBasamaklıOldugunuBulma_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrEmpty(txtSayi.Text) || String.IsNullOrWhiteSpace(txtSayi.Text))
                {
                    MessageBox.Show("Hata: İnteger tam sayı giriniz");
                    return;
                }

                int sayi = 0;
                if (int.TryParse(txtSayi.Text, out sayi) == false)
                {
                    MessageBox.Show("Hata: İnteger tam sayı girişi yapılmalı");
                    return;
                }

                if (sayi<0)
                {
                    sayi = sayi * -1;
                }

                hesaplaWhileDongusu(sayi);
                hesaplaToString(sayi);
                hesaplaLog10( sayi);
                hesaplaIfChain(sayi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        void hesaplaWhileDongusu(int sayi)
        {
            int i = 1;
            while (sayi > 9)
            {
                sayi = sayi / 10;
                i++;
            }
            lblBasamakWhile.Text = (i.ToString());
        }

        void hesaplaToString(int sayi)
        {
            lblBasamakString.Text = (sayi.ToString().Length.ToString());
        }

        void hesaplaLog10(int sayi)
        {
            int i = 0;
            do
            {
                sayi = sayi / 10;
                i++;
            }
            while (Math.Abs(sayi) >= 1);
            lblBasamakLog10.Text = (i.ToString());
        }


        void hesaplaIfChain(int sayi)
        {
            int basamak = 0;
            if (sayi >= 0)
            {
                if (sayi < 10) basamak= 1;
                else if (sayi < 100) basamak = 2;
                else if (sayi < 1000) basamak = 3;
                else if (sayi < 10000) basamak = 4;
                else if(sayi < 100000) basamak = 5;
                else if (sayi < 1000000) basamak = 6;
                else if (sayi < 10000000) basamak = 7;
                else if (sayi < 100000000) basamak = 8;
                else if (sayi < 1000000000) basamak = 9;
            }
            else
            {
                 if (sayi > -10) basamak = 2;
                else if (sayi > -100) basamak = 3;
                else if (sayi > -1000) basamak = 4;
                else if (sayi > -10000) basamak = 5;
                else if (sayi > -100000) basamak = 6;
                else if (sayi > -1000000) basamak = 7;
                else if (sayi > -10000000) basamak = 8;
                else if (sayi > -100000000) basamak = 9;
            }

            lblBasamakIfChain.Text = basamak.ToString();
        }

    }
}
