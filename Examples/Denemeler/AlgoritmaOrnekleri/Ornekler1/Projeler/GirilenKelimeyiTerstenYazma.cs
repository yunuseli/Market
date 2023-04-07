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
    public partial class GirilenKelimeyiTerstenYazma : Form
    {
        public GirilenKelimeyiTerstenYazma()
        {
            InitializeComponent();
        }
        private void GirilenKelimeyiTerstenYazma_Load(object sender, EventArgs e)
        {
            lblSonuc.Text = string.Empty;
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtKelime.Text) || String.IsNullOrWhiteSpace(txtKelime.Text))
                {
                    MessageBox.Show("Hata: Hatalı yazı giriniz");
                    return;
                }

                lblSonuc.Text = string.Empty;
                string metin = txtKelime.Text;

                for (int i = (metin.Length - 1); i > -1; i--)
                {
                    lblSonuc.Text += metin[i].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }


        }

    }
}
