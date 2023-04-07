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
    public partial class Siramatik : Form
    {
        public Siramatik()
        {
            InitializeComponent();
        }
        Queue<int> kuyruk = new Queue<int>();
        int sira = 0;

        private void Siramatik_Load(object sender, EventArgs e)
        {

        }

        private void btnSiraAl_Click(object sender, EventArgs e)
        {
            kuyruk.Enqueue(++sira);
            lstSira.DataSource = kuyruk.ToList();
        }

        private void btnTemsilci1_Click(object sender, EventArgs e)
        {
            if (kuyruk.Count == 0)
            {
                MessageBox.Show("Sırada Müşteri yok");
                return;
            }

            int siradaki = kuyruk.Dequeue();
            lstTemsilci1.Items.Add(siradaki);
            lstSira.DataSource = kuyruk.ToList();
        }

        private void btnTemsilci2_Click(object sender, EventArgs e)
        {
            if (kuyruk.Count == 0)
            {
                MessageBox.Show("Sırada Müşteri yok");
                return;
            }

            int siradaki = kuyruk.Dequeue();
            lstTemsilci2.Items.Add(siradaki);
            lstSira.DataSource = kuyruk.ToList();

        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            kuyruk.Clear();
            lstSira.DataSource = kuyruk.ToList();
            lstTemsilci1.Items.Clear();
            lstTemsilci2.Items.Clear();
        }
    }
}
