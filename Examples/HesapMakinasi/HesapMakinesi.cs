using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinasi
{
  public class HesapMakinesi
  {
    private double oncekiDeger { get; set; }
    private string oncekiOperator { get; set; }
    private double yeniDeger { get; set; }
    private string yeniOperator { get; set; }
    private bool sonBasilanOperator { get; set; }

    public string islemLabelDegeri { get; set; }
    public string girisTextboxDegeri { get; set; }


    public HesapMakinesi()
    {
      Sifirla();
    }

    public void Sifirla()
    {
      oncekiDeger = 0;
      oncekiOperator = "";
      yeniDeger = 0;
      yeniOperator = "";
      sonBasilanOperator = false;
    }

    public void veriGirisi(string deger)
    {
      string giris = girisTextboxDegeri;
      switch (deger)
      {
        case "0":
        case "1":
        case "2":
        case "3":
        case "4":
        case "5":
        case "6":
        case "7":
        case "8":
        case "9":
          if (sonBasilanOperator)
          {
            sonBasilanOperator = false;
            giris = string.Empty;
          }
          giris += deger;
          break;

        case ",":
          if (sonBasilanOperator)
          {
            sonBasilanOperator = false;
            giris = string.Empty;
          }
          if (!giris.Contains(","))
            giris += deger;
          break;

        case "«": // Son sayıyı sil
          if (giris.Length > 0)
            giris = giris.Remove(giris.Length - 1, 1);
          break;

        case "C": // Tümünü temizle
          giris = string.Empty;
          Sifirla();
          islemLabelDegeri = string.Empty;
          break;
        case "CE": // Son girişi temizle
          giris = string.Empty;
          break;

        case "+":
        case "-":
        case "x":
        case "/":
          if (sonBasilanOperator)
          {
            if (islemLabelDegeri.Substring(islemLabelDegeri.Length - 1, 1) == "=")
              islemLabelDegeri = $"{oncekiDeger} {oncekiOperator}";
            islemLabelDegeri = islemLabelDegeri.Remove(islemLabelDegeri.Length - 1, 1) + deger;
            oncekiOperator = deger;
            return;
          }
          if (giris.Length == 0)
            return;
          yeniDeger = Convert.ToDouble(giris);
          yeniOperator = deger;
          Hesap();
          sonBasilanOperator = true;
          return;

        case "=":

          if (giris.Length == 0)
            return;
          yeniDeger = Convert.ToDouble(giris);
          double hesap = HesapIslem();
          islemLabelDegeri = $"{oncekiDeger} {oncekiOperator} {yeniDeger} =";
          girisTextboxDegeri = hesap.ToString();
          oncekiDeger = hesap;
          sonBasilanOperator = true;
          return;

        case "±":
          if (giris.StartsWith("-"))
            giris = giris.Remove(0, 1);
          else
            giris = "-" + giris;
          break;

        default:
          break;
      }

      // Virgülle başladı ise 0, yap
      if (giris.StartsWith(",") && giris.Length == 1)
        giris = $"0{giris}";

      // Sıfırla başladı ise, arkadan gelen virgül değilse, baştaki sıfırı sil
      if (giris.StartsWith("0") && giris.Length > 1 && giris[1].ToString() != ",")
        giris = giris.Remove(0, 1);

      if (giris == string.Empty)
        giris = "0";
      girisTextboxDegeri = giris;
    }

    private void Hesap()
    {
      double hesap = HesapIslem();
      oncekiDeger = hesap;
      oncekiOperator = yeniOperator;
      islemLabelDegeri = $"{hesap} {yeniOperator}";
      girisTextboxDegeri = hesap.ToString();

    }
    private double HesapIslem()
    {
      double hesap = 0;
      if (oncekiOperator == "")
      {
        hesap = yeniDeger;
      }
      else
      {
        switch (oncekiOperator)
        {
          case "+":
            hesap = oncekiDeger + yeniDeger;
            break;
          case "-":
            hesap = oncekiDeger - yeniDeger;
            break;
          case "x":
            hesap = oncekiDeger * yeniDeger;
            break;
          case "/":
            hesap = oncekiDeger / yeniDeger;
            break;

          default:
            break;
        }
      }
      return hesap;
    }


  }
}
