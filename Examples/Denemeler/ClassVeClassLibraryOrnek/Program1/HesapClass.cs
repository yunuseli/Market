using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//** En altta açıklamayı inceleyebilirsiniz, linkten Microsoft Learn kaynağını inceleyebilirsiniz
//https://learn.microsoft.com/tr-tr/dotnet/csharp/fundamentals/tutorials/classes

namespace Program1
{
  public class HesapClass
  {


    // Sınıf içinde verileri tutabilmek için tanımlanan özellikler
    // get değeri almak, set değeri değiştirmek için
    public double sayi1 { get; set; }
    public double sayi2 { get; set; }

    // Constructor (Yapıcı) Metot, nesne oluştuğunda otomatik çalışan metot
    // Örneğin özelliklere ilk değerlerini atamak için kullanılabilir
    public HesapClass()
    {
      sayi1 = -1;
      sayi2 = 3.14;
    }

    // get erişimcisi ile hesaplanan değerleri döndürmek
    public double Toplam { get { return sayi1 + sayi2; } }
    public double Fark { get { return sayi1 - sayi2; } }
    public double Carpim { get { return sayi1 * sayi2; } }
    public double Bolum { get { return sayi1 / sayi2; } }

    // metot tanımlayarak işlem yapmak ** metodun içinde sınıfın özellikleride kullanılmıştır.
    // özellikler double tipinde, kullanmak için program içinden uygun tipte veri gönderilmeli
    // ama aşağıdaki metot sayesinde tüm girişleri direk string tipinde alıp, dönüşüde aynı
    // şekilde string tipinde verebilir ve tüm hata ayıklama işlemlerini halledebiliriz.
    public string Islem(string s1, string s2, string opr)
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

        sayi1 = giris1;
        sayi2 = giris2;

        switch (opr)
        {
          case "+":
            return Toplam.ToString();
          case "-":
            return Fark.ToString();
          case "*":
            return Carpim.ToString();
          case "/":
            return Bolum.ToString();
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


/*
  Microsoft'un geliştirdiği programlama dilleri arasında en popüleri C# olmuştur. 
  C# programlama dilinin öne çıkmasının en önemli nedeni, daha önce geliştirilen 
  Nesne Yönelimli (OOP:Object Oriented Programming) programlama dillerinin güzel 
  özelliklerini bünyesinde barındırmasıdır. Özellikle yapı olarak C++ ve Java 
  programlama dillerine çok benzeyen sınıf(class) yapısı sayesinde geniş kitlelerce 
  hemen benimsenmiş ve popüler bir dil haline gelmiştir. Artık sınıf yapısı kullanmayan 
  programlama dili neredeyse kalmadı diyebiliriz, profesyonel geliştiriciler de 
  nesne yönelimli olmayan dilleri artık tercih etmemektedir, hatta nesne yönelimli 
  yapısı zayıf olan diller de ortadan kalkmaktadır. Örneğin yine VB.NET'in sınıf yapısı 
  programcılara göre çok farklı geldiği için giderek kullanımı azalmıştır. 

  Nesne Yönelimli programlama dilleri kullanmanın en önemli avantajı 
  tekrar kullanılabilirlik(reusability) dir. Başladığınız her projede aynı kodları 
  defalarca yazıyorsanız ve sizin yazdığınız kodları yazılım ekibi içerisindeki diğer 
  yazılımcılar geliştirip kullanamıyorsa, hem zaman hem maliyet açısından verimsiz bir 
  durum söz konusudur. 

  Nesne Yönelimli programlamanın diğer bir avantajı sürdürülebilirlik(maintainability) 
  özelliğidir. Kaynak kodların kolayca  okunabilmesi, anlaşılabilmesi gibi avantajları 
  yanında kolayca hata bulma, optimize etme işlemleri de pratik bir şekilde yapılabilir.  

  Genişleyebilirlik(Extensibility) de  nesne yönelimli programlamanın diğer bir avantajıdır. 
  Kodlarınıza kolayca yeni özellikler ekleyip genişletmenize olanak tanır. 

  Sınıfları şablonlar gibi düşünebiliriz, şablonları kullanarak nesnelerimizi oluşturuyoruz. 
  Örneğin nesne yönelimli programlama anlatılırken kullanılan klasik bir örnek olarak 
  Hayvan sınıfını verebiliriz. Hayvan sınıfının bir örneği olarak kedi, kuş ve rakun nesnelerini 
  örnek verebiliriz. Yine Kamyon sınıfının örnekleri olarak Mercedes, MAN nesnelerini, 
  Çiçek sınıfının nesneleri olarak Gül, Nilüfer, Karanfil'i verebiliriz. 
  Ayrıca hepimiz insan sınıfının bir örneğiyiz, bu sınıfın bir nesnesiyiz. 
  Bu örnekleri çoğaltmak mümkün. 

  Bir de sınıflarımızın yaptıkları eylemler(metodlar) vardır. Örneğin hayvan sınıfının 
  eylemleri Yeme(), İçme() sayılabilir. Kamyon sınıfının eylemleri YükTasima(), 
  çiçek sınıfının eylemleri Buyume(), Kuruma(),  Kokma() olabilir. 
  İnsan sınıfının metotları Yeme(), İçme(), Düşünme(), Giyinme() olabilir. 
  Burada özellik ve metotlara sınıfın üyeleri olarak adlandırabiliriz. 
  Bir sınıfın içinde hiçbir metot tanımlamadan da kullanılabilir ama sınıf kullanmanın 
  en büyük artısı bir nesneyi özellik ve metotlarıyla beraber tanımlayabilmektir. 

*/
