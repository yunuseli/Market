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
    public partial class MukemmelSayiyiBulma : Form
    {
        public MukemmelSayiyiBulma()
        {
            InitializeComponent();
        }

        private void MukemmelSayiyiBulma_Load(object sender, EventArgs e)
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

                int sayac = 2;
                int top = 1;
            dnz:
                if (sayi % sayac == 0)
                {
                    top = top + sayac;
                    sayac++;
                }
                else
                {
                    sayac++;
                }
                if (sayac > sayi / 2)
                {
                    if (top == sayi)
                        MessageBox.Show("Mükemmeldir");
                    else
                        MessageBox.Show("Mükemmel degildir");
                }
                else
                {
                    goto dnz;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
}
