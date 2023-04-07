using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler.Projeler.DigerOrnekler
{
  public partial class RenkSecimi : Form
  {
    public RenkSecimi()
    {
      InitializeComponent();
    }

    ColorDialog renk = new ColorDialog();

    Button btnOK = new Button();
    TextBox txt = new TextBox();  

    private void RenkSecimi_Load(object sender, EventArgs e)
    {
      lblPA.Text = "";
      lblYA.Text = "";
      lblYO.Text = "";

      btnOK.Visible = true;
      btnOK.Width= 100;
      btnOK.Height= 100;
      btnOK.Name= "OK";
      btnOK.Text= "OK";
      pnlRenkTest.Controls.Add(btnOK);  
    }

    private void btnPa_Click(object sender, EventArgs e)
    {

      renk.ShowDialog();
      pnlRenkTest.BackColor = renk.Color;
      renk.Color.ToKnownColor();
      lblPA.Text = renk.Color.Name;
    }

    private void btnYa_Click(object sender, EventArgs e)
    {
      renk.ShowDialog();
      lblEtiket.BackColor = renk.Color;
      renk.Color.ToKnownColor();
      lblYA.Text = renk.Color.Name;
    }

    private void btnYO_Click(object sender, EventArgs e)
    {
      renk.ShowDialog();
      lblEtiket.ForeColor = renk.Color;
      renk.Color.ToKnownColor();
      lblYO.Text = renk.Color.Name;
    }
  }
}
