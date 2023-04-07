using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinasi
{
  public partial class Menu1 : Form
  {
    public Menu1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Hesaplayici hesaplayici = new Hesaplayici();
      hesaplayici.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Hesaplayici2 hesaplayici2 = new Hesaplayici2();
      hesaplayici2.Show();
    }
  }
}
