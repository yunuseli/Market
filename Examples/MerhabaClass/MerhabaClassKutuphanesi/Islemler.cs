using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerhabaClassKutuphanesi
{
  public class Islemler
  {
    public string Toplama(string s1, string s2)
    {
      try
      {
        int Sayi1 = Convert.ToInt32(s1);
        int Sayi2 = Convert.ToInt32(s2);
        return (Sayi1 + Sayi2 + 10).ToString();
      }
      catch (Exception ex)
      {
        return $"Hata : {ex.Message}";
      }
    }
  }
}
