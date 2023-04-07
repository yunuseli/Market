using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
  public class Ogrenci
  {
    public enum DurumGectiKaldi
    {
      Kaldi = 0,
      Gecti = 1
    }


    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Sinif { get; set; }
    public string Sube { get; set; }
    public int Numara { get; set; }
    public double Not1 { get; set; }
    public double Not2 { get; set; }
    public double Not3 { get; set; }
    public double Ortalama { get; set; }

    public DurumGectiKaldi Durum { get; set; }

    public void OgrenciOlustur(string adi, string soyad, int numara, double ortalama)
    {
      this.Ad = adi;
      this.Soyad = soyad;
      this.Numara = numara;
      this.Ortalama = ortalama;
    }

    public bool OgrenciGectiMi()
    {
      if (this.Ortalama < 50)
        return false;
      else
        return true;
    }

  }
}
