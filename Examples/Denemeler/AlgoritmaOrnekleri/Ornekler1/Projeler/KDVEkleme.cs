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
    public partial class KDVEkleme : Form
    {
        public KDVEkleme()
        {
            InitializeComponent();
        }

        private void KDVEkleme_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            try
            {
                if (String.IsNullOrEmpty(txtFiyat.Text) || String.IsNullOrWhiteSpace(txtFiyat.Text))
                {
                    MessageBox.Show("Hata: Değer Girmediniz");
                    return;
                }

                float fiyat = 0;
                if (float.TryParse(txtFiyat.Text, out fiyat) == false)
                {
                    MessageBox.Show("Hata: Fiyat girişi yapılmalı");
                    return;
                }

                float ilkFiyat = fiyat;
                fiyat *= 0.18F;
                float kdvliFiyat = ilkFiyat + fiyat;

                lstUrunFiyati.Items.Add(ilkFiyat);
                lstKDVliFiyati.Items.Add(kdvliFiyat);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
}
