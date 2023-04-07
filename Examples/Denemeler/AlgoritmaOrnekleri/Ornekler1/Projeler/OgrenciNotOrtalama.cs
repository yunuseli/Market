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
    public partial class OgrenciNotOrtalama : Form
    {
        public OgrenciNotOrtalama()
        {
            InitializeComponent();
        }
        private void OgrenciNotOrtalama_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtOgrenciAdi.Text) || String.IsNullOrWhiteSpace(txtOgrenciAdi.Text))
                {
                    MessageBox.Show("Hata: Yazı giriniz");
                    return;
                }

                if (String.IsNullOrEmpty(txtVize.Text) || String.IsNullOrWhiteSpace(txtVize.Text))
                {
                    MessageBox.Show("Hata: İnteger tam sayı giriniz");
                    return;
                }

                if (String.IsNullOrEmpty(txtFinal.Text) || String.IsNullOrWhiteSpace(txtFinal.Text))
                {
                    MessageBox.Show("Hata: İnteger tam sayı giriniz");
                    return;
                }

                float vize = 0;
                if (float.TryParse(txtVize.Text, out vize) == false)
                {
                    MessageBox.Show("Hata: Not girişi yapılmalı");
                    return;
                }

                if (vize > 100 || vize < 0)
                {
                    MessageBox.Show("Vize notu 100 den büyük yada 0 dan küçük olamaz");
                    return;
                }

                float final = 0;
                if (float.TryParse(txtFinal.Text, out final) == false)
                {
                    MessageBox.Show("Hata:Not girişi yapılmalı");
                    return;
                }

                if (final>100|| final<0 )
                {
                    MessageBox.Show("Final notu 100 den büyük yada 0 dan küçük olamaz");
                    return;
                }

                string Ad = txtOgrenciAdi.Text ;
                vize *= 0.3F;
                final *= 0.7F;
                float ort = vize + final;

                lstAd.Items.Add(Ad);
                lstVize.Items.Add(txtVize.Text);
                lstFinal.Items.Add(txtFinal.Text);
                lstOrtalama.Items.Add(ort);   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }


    }
}
