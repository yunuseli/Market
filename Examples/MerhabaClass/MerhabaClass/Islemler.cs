using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerhabaClass
{
  public class Islemler
  {
    public int Sayi1 { get; set; }
    public int Sayi2 { get; set; }

    public int Toplam { get { return Sayi1 + Sayi2; } }

    public string toplama(string s1, string s2)
    {
      try
      {
        int Sayi1 = Convert.ToInt32(s1);
        int Sayi2 = Convert.ToInt32(s2);
        return (Sayi1 + Sayi2).ToString();
      }
      catch (Exception ex)
      {
        return $"Hata : {ex.Message}";
      }
    }
  }
}
