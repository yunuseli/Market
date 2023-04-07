using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimKutuphanem
{
  public class Hesaplamalar
  {
    public string DortIslemIkiSayi(string s1, string s2, string opr)
    {
      try
      {
        double giris1 = 0, giris2 = 0;
        if (double.TryParse(s1, out giris1) == false)
        {
          return "Hata : Sayı 1 girişi hatalı";
        }
        if (double.TryParse(s2, out giris2) == false)
        {
          return "Hata : Sayı 2 girişi hatalı";
        }

        switch (opr)
        {
          case "+":
            return (giris1 + giris2).ToString();
          case "-":
            return (giris1 - giris2).ToString();
          case "*":
            return (giris1 * giris2).ToString();
          case "/":
            return (giris1 / giris2).ToString();
          default:
            return "Hata : Hatalı operatör";
        }
      }
      catch (Exception ex)
      {
        return $"Hata : {ex.Message}";
      }
    }



  }
}
