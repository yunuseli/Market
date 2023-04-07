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
    public partial class PolindromKontrolu : Form
    {
        public PolindromKontrolu()
        {
            InitializeComponent();
        }

        private void PolindromKontrolu_Load(object sender, EventArgs e)
        {

        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtKelime.Text) || String.IsNullOrWhiteSpace(txtKelime.Text))
                {
                    MessageBox.Show("Hata: İnteger tam sayı giriniz");
                    return;
                }

                Console.Write("Bir kelime giriniz: ");
                string kelime = txtKelime.Text;
                string kelime_ters = "";
                for (int i = kelime.Length - 1; i >= 0; i--)
                {
                    kelime_ters += kelime[i];
                }
                if (kelime_ters == kelime)
                {
                    MessageBox.Show("\nGirilen kelime Polindrom bir kelimedir.");
                }
                else
                {
                    MessageBox.Show("\nGirilen kelime Polindrom bir kelime değildir.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
}
