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
    public partial class CarpmaOperatorsuzCarpma : Form
    {
        public CarpmaOperatorsuzCarpma()
        {
            InitializeComponent();
        }

        private void CarpmaOperatorsuzCarpma_Load(object sender, EventArgs e)
        {
            lblSonuc.Text = string.Empty;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtSayi1.Text) || String.IsNullOrWhiteSpace(txtSayi1.Text))
                {
                    MessageBox.Show("Hata: Sayı1 giriniz");
                    return;
                }

                if (String.IsNullOrEmpty(txtSayi2.Text) || String.IsNullOrWhiteSpace(txtSayi2.Text))
                {
                    MessageBox.Show("Hata: Sayı2 giriniz");
                    return;
                }


                int sayi1 = 0, sayi2 = 0, sonuc = 0;

                if (int.TryParse(txtSayi1.Text , out sayi1)== false)
                {
                    MessageBox.Show("Hata: Sayı1 girişi yanlış");
                    return;
                }
                if (int.TryParse(txtSayi2.Text, out sayi2) == false)
                {
                    MessageBox.Show("Hata: Sayı2 girişi yanlış");
                    return;
                }

                //Döngü sayısını kısaltmak için küçük olan kadar döngü kurarız
                if (sayi1 < sayi2)
                {
                    for (int i = 0; i < sayi1; i++)
                    {
                        sonuc += sayi2;
                    }
                }
                else
                {
                    for (int i = 0; i < sayi2; i++)
                    {
                        sonuc += sayi1;
                    }
                }

                lblSonuc.Text = sonuc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
}
