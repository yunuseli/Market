using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSinifOrnekleri
{
  internal class Degiskenler
  {
    public Degiskenler()
    {
      // Örnekler

      //Not: Değişken isimleri çok fazla tanımlama yaoılacağı için anlamsız verilmiştir

      // Değişken tanımlama

      bool b1 = true;
      char a = 'g';
      int b = 5;
      string c = "deneme";

      var d = 10; // Implicitly typed. -- türü derleyici belirler
      int e = 10; // Explicitly typed. -- yerleşik basit tür


      object f = 10; // object türüne her türden veri atanabilir
      object g = 'k';
      object h = "metin";
      object i = 12.9f;

      object isim;
      isim = "DataHouse";
      isim = 10;
      isim = true;

      int aa, ba, ia; // Aynı satırda birden fazla değişken tanımla
      double xa, ya;

      int ab = 5, bb = 23, cb = 56; // Aynı satırda birden fazla değişkeni değerleri ile tanımla
      double xb = 2.34, yb = 3.02;
      string sb = "Datahouse", ssb = "C# Eğitimi";


      int ac = int.MinValue; // Default / max / min ile tanımla ** Sytem kütüphanesinin türler için sağladığı özelliklerden
      int bc = default;
      int cc = int.MaxValue;
      Console.WriteLine(ac + " / " + bc + " / " + cc);
      uint xc = uint.MinValue;
      uint yc = default;
      uint zc = uint.MaxValue;
      Console.WriteLine(xc + " / " + yc + " / " + zc);



      //Tür dönüşümleri

      // Bilinçsiz dönüşümler : Küçük tipten büyüğe doğru olacağından özel bir işlem gerektirmez

      sbyte bd = -15; // imzalı (negatif değer alabilen) tamsayı tipler
      short sd = bd;
      int id = sd;
      long ld = id;

      byte ubd = 45; // imzasız (pozitif) tamsayı tipler
      ushort usd = ubd;
      uint uid = usd;
      ulong uld = uid;

      float fd = 1258.63f; // ondalıklı tipler
      double dd = fd;


      // Bilinçli dönüşümler : büyükten küçüğe veya ondalıklıdan tamsayıya gibi kontrollü dönüşümler


      // cast
      int ce = 52;
      byte de = (byte)ce;

      float fe = 1265.52f; // bu örnekte ondalıklı kısım int değişkenine atanamayacak ve tam sayıya çevrilecektir
      int ge = (int)fe;

      // parse  (sytem türleri sınıfının sağladığı işlemler)
      string he = "256";
      int je = int.Parse(he);

      // convert (convert sınıfının sağladdığı işlemler)
      string ne = "2596354444,7895";
      double oe = Convert.ToDouble(ne);

      char iee = 'b';
      Console.WriteLine(Convert.ToInt32(iee));

      // tryparse
      string ke = "589";
      short le = 0;
      bool me = short.TryParse(ke, out le); /* tryparse işlemi dönüşümü kontrol ederek işlem sonucunu doğru veya yanlış olarak 
                                         bu sayede programın hata vermeden ilerlemesini sağlarız. 
                                         bu örnekte me değişkenine işlem sonucu atanır
                                         daha önceden tanımladığımız le değişkenine ise işlem başarılı ise dönüşen veri atanır
                                         metod parametrelerndeki out deyimi sayesinde atama yapılırKDS
                                       */


      // ToString  -> bu metot ile string türüne dönüşüm yapılır
      object ae = "5";
      string be = ae.ToString();

      long pe = 89986545654;
      string re = pe.ToString();
    }
  }
}
