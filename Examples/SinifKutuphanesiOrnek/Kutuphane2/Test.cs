using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane2
{
  public class Test
  {

    public double KareBul(string s)
    {
      try
      {
        int sayi = int.Parse(s);
        double kare = Math.Pow(sayi, 2);
        return kare;
      }
      catch (Exception)
      {
        return 0;
      }
    }

  }
}
