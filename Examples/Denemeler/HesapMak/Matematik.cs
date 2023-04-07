using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMak
{
  public class Matematik
  {

    public static string hesapla(string s1, string s2, string opr)
    {
      string sonuc = "";
      try
      {
        int sayi1 = int.Parse(s1);
        int sayi2 = int.Parse(s2);
        switch (opr)
        {
          case "+":
            sonuc = (sayi1 + sayi2).ToString();
            break;
          case "-":
            sonuc = (sayi1 - sayi2).ToString();
            break;
          case "*":
            sonuc = (sayi1 * sayi2).ToString();
            break;
          case "/":
            sonuc = (sayi1 / sayi2).ToString();
            break;
          default:
            break;
        }
      }
      catch (Exception ex)
      {
        sonuc = "Hata : " + ex.Message;
      }

      return sonuc;
    }

  }
}
