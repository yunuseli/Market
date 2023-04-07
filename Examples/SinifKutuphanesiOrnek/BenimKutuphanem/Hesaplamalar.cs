using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimKutuphanem
{
  public class Hesaplamalar
  {

    public double Toplama(string sayi1, string sayi2)
    {
      try
      {
        double s1 = double.Parse(sayi1);
        double s2 = double.Parse(sayi2);
        double sonuc = s1 + s2;
        return sonuc;
      }
      catch (Exception)
      {
        return double.NaN;
      }
    }


  }
}
