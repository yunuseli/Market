using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerhabaClass
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }
    Islemler islemler = new Islemler();
    private void button4_Click(object sender, EventArgs e)
    {
      MessageBox.Show(islemler.toplama(textBox1.Text, textBox2.Text));
    }
  }
}
