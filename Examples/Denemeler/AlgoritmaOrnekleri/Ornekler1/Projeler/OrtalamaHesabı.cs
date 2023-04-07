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
    public partial class OrtalamaHesabı : Form
    {
        public OrtalamaHesabı()
        {
            InitializeComponent();
        }

        private void OrtalamaHesabı_Load(object sender, EventArgs e)
        {

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

                int sayi1 = 0,sayi2 =0;

                if (int.TryParse(txtSayi1.Text, out sayi1) == false)
                {
                    MessageBox.Show("Hata: Sayı1 girişi yanlış");
                    return;
                }

                if (int.TryParse(txtSayi2.Text, out sayi2) == false)
                {
                    MessageBox.Show("Hata: Sayı2 girişi yanlış");
                    return;
                }

                int enk, enb, ort, fark, b;
                int temp;
                int i;
                int a;
                a = Convert.ToInt32(txtSayi1.Text);
                enk = a; enb = a; temp = a;
                i = 2;
                for (i = 1; i < 10; i++)
                {
                    a = Convert.ToInt32(txtSayi2.Text);
                    if (enk > a)
                    {
                        enk = a;
                    }
                    if (enb < a)
                    {
                        enb = a;
                    }
                    temp = temp + a;
                }
                b = (enb + enk) / 2;
                ort = temp / 10;
                fark = ort - b;
                lblSonuc.Text = fark.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}");
            }

        }
    }
}
