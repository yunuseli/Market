using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
  public partial class Menu : Form
  {
    public Menu()
    {
      InitializeComponent();
    }

    private void Menu_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      HesapIsleri hesapIsleriFormu = new HesapIsleri();
      hesapIsleriFormu.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      // Başka bir projeji referans etmek için, projemize sağ tıklayıp
      // add - project reference seçip, açılan pencereden ilgili projeyi ekleyebiliriz
      Program2.Islemler islemlerFormu = new Program2.Islemler(); 
      islemlerFormu.Show();
    }
  }
}
