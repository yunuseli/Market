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
    public partial class KelimeninHarfleriniSagaAtma : Form
    {
        public KelimeninHarfleriniSagaAtma()
        {
            InitializeComponent();
        }

        private void KelimeninHarfleriniSagaAtma_Load(object sender, EventArgs e)
        {
            lblKelime.Text = string.Empty;
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            try
            {
                lblKelime.Text = string.Empty;
                char[] dizi = new char[10];
                dizi[0] = 'B'; dizi[1] = 'I';
                dizi[2] = 'L'; dizi[3] = 'G';
                dizi[4] = 'I'; dizi[5] = 'S';
                dizi[6] = 'A'; dizi[7] = 'Y';
                dizi[8] = 'A'; dizi[9] = 'R';
                int i = 0; int j = 0;
                int k = 0;
            dmg:
                for (i = j; i <= 9; i++)
                {
                    lblKelime.Text += (dizi[i]);
                }
                i = j;
                while (k < j)
                {
                    lblKelime.Text += (dizi[k]);
                    k++;
                }
                j++;
                k = 0;
                if (i < 10)
                {
                    lblKelime.Text += "\n";
                    goto dmg;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }


        void yontem2()
        {
            try
            {
                char[] dizi = { 'B', 'İ', 'L', 'G', 'İ', 'S', 'A', 'Y', 'A', 'R' };
                lblKelime.Text = new string( dizi) + "\n";
                for (int i = 0; i < dizi.Length; i++)
                {
                    char first = dizi[0];
                    for (int j = 0; j < dizi.Length - 1; j++)
                        dizi[j] = dizi[j + 1];
                    dizi[dizi.Length - 1] = first;
                    lblKelime.Text += new string(dizi) + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void buttonY2_Click(object sender, EventArgs e)
        {
            yontem2();
        }


        void yontem3()
        {
            try
            {
                char[] dizi = { 'B', 'İ', 'L', 'G', 'İ', 'S', 'A', 'Y', 'A', 'R' };
                lblKelime.Text = new string(dizi) + "\n";
                for (int i = 0; i < dizi.Length; i++)
                {
                    char[] dizi2 = new char[dizi.Length];
                    Array.Copy(dizi, 1, dizi2, 0, dizi.Length - 1);
                    dizi2[dizi2.Length - 1] = dizi[0];
                    lblKelime.Text += new string(dizi2) + "\n";
                    dizi = dizi2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void buttonY3_Click(object sender, EventArgs e)
        {
            yontem3();
        }
    }
}
