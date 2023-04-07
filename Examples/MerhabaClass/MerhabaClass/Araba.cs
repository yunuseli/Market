using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerhabaClass
{
  public class Araba
  {
    private int sayac;
    public int sabitSayi
    {
      get { return sayac; }
      set { sayac = value + sayac; }
    }
    public string Marka { get; set; }
    public string Model { get; set; }
    public int ModelYili { get; set; }

    public string Veri
    {
      get { return $"{Marka}/{Model}/{ModelYili}"; }
    }
  }
}
