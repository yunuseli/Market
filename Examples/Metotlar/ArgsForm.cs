using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
  public partial class ArgsForm : Form
  {
    public ArgsForm()
    {
      InitializeComponent();
    }

    //C:\SınıfProjeleri\Metotlar\Metotlar\bin\Debug\net7.0-windows\Metotlar.exe /123 /456 /789

    //Debug - Test için
    // Project properties | Debug | open debug launch profiles UI | Command line arguments

    private void ArgsForm_Load(object sender, EventArgs e)
    {
      string[] args = Environment.GetCommandLineArgs();
      if (args.Length > 0)
      {
        foreach (var item in args)
        {
          if (item.ToString().Contains(".dll"))
            continue;

          MessageBox.Show(item);
        }
      }

    }
  }
}
