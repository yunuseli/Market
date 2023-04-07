using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifKutuphanesi
{
  public class Araba
  {
    public string Marka { get; set; }
    public string Model { get; set; }
    public int Yil { get; set; }

    public string Veri()
    {
      return $"Marka: {Marka},Model: {Model}, Yıl: {Yil}";
    }

    public string Data
    {
      get { return $"Marka: {Marka},Model: {Model}, Yıl: {Yil}"; }
    }
  }
}
