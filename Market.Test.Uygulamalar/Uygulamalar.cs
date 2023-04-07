using Market.Entity.Classes.TestClasses;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;
//using static Market.Test.Uygulamalar.Uygulamalar;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Market.Test.Uygulamalar
{
  public partial class Uygulamalar : Form
  {
    public Uygulamalar()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      WebbServiceTcKimlik webbServiceTcKimlik = new WebbServiceTcKimlik();
      webbServiceTcKimlik.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      EmailTest emailTest = new EmailTest();
      emailTest.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      // JSON (JavaScript Object Notation) - JavaScript Nesne Gösterimi
      // basit veri yapılarını temsil etmek için tasarlanmış bağımsız bir veri değişim formatıdır.
      // JSON programlama dilinden bağımsız olarak farklı platformlar arasında veri alışverişi için kullanılır.

      // https://www.oracle.com/tr/database/what-is-json/
      // https://blog.turhost.com/json-nedir-ve-ne-icin-kullanilir/

      // {"adi":"Deneme"}

      /*
        {"kisiler": [
          { "sira": "1", "adi": "Yusuf", "soyadi": "SEZER" },
          { "sira": "2", "adi": "Ramazan", "soyadi": "SEZER" },
          { "sira": "3", "adi": "Sinan", "soyadi": "SEZER" },
          { "sira": "4", "adi": "Mehmet", "soyadi": "SEZER" }
        ]}
      */

      JsonTest jsonTest = new JsonTest();
      jsonTest.ShowDialog();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      /*
       ternary operatörü, bir koşulu değerlendirir ve koşul doğruysa 
       bir değer döndürür; aksi takdirde başka bir değeri döndürür. 
       Bu operatör genellikle if-else ifadelerinin kısaltılmış 
       bir versiyonu olarak kullanılır.
      */

      int sayi = -5;
      string durum = (sayi >= 0) ? "Pozitif" : "Negatif";
      MessageBox.Show("Sayının durumu: " + durum);
      //Yukarıdaki kod, sayının 0'dan büyük veya eşit olup olmadığını kontrol eder.
      //Eğer koşul doğruysa, durum değişkenine "Pozitif" değerini atar,
      //aksi takdirde "Negatif" değerini atar. 

      sayi = 15;
      durum = (sayi % 3 == 0 && sayi % 5 == 0) ? "Sayı 3 ve 5'e tam bölünebilir." : 
        (sayi % 3 == 0) ? "Sayı sadece 3'e tam bölünebilir." : 
        (sayi % 5 == 0) ? "Sayı sadece 5'e tam bölünebilir." : 
        "Sayı 3 veya 5'e tam bölünebilmez.";
      MessageBox.Show(durum);
      //Yukarıdaki kod, öncelikle sayının 3 ve 5'e tam bölünebilir olup olmadığını kontrol eder.
      //Eğer koşul doğruysa, sonuc değişkenine "Sayı 3 ve 5'e tam bölünebilir." değerini atar.

      sayi = 0;
      durum = (sayi > 0) ? "Pozitif" : (sayi < 0) ? "Negatif" : "Sıfır";
      MessageBox.Show("Sayının durumu: " + durum);
      //Yukarıdaki kodda, nested ternary operatörü, ilk önce sayının
      //pozitif olup olmadığını kontrol eder. Eğer koşul doğruysa,
      //"Pozitif" değeri atanır. Eğer koşul yanlışsa, ikinci ternary
      //operatör çalışır. Bu ternary operatörü, sayının negatif olup
      //olmadığını kontrol eder. Eğer koşul doğruysa, "Negatif" değeri atanır.
      //Eğer koşul yanlışsa, üçüncü ternary operatörü çalışır ve "Sıfır" değeri atanır.
      //Ancak, bu durumda kodun okunabilirliği azalabilir ve karışık hale gelebilir.
    }

    private void button5_Click(object sender, EventArgs e)
    {
      /*
      Tuple veri türü, bir veya daha fazla farklı veri türüne 
      sahip birden fazla değeri tek bir değişkende tutmak için kullanılır. 
      Tuple'lar özellikle bir fonksiyondan birden fazla değer 
      döndürmek istediğinizde kullanışlıdır.
      */

      Tuple<string, int> person = new Tuple<string, int>("John", 35);
      MessageBox.Show($"{person.Item1} - {person.Item2}");

    }

    private void button6_Click(object sender, EventArgs e)
    {
      /*
      "dynamic" anahtar kelimesi, çalışma zamanında tür belirlemeyi 
      sağlayan bir veri türüdür. Bu, değişkenlerin türü derleme zamanında 
      belirlenmek yerine çalışma zamanında belirlenir. Bu, C# dilinin 
      tip güvenliği özelliğinden ödün verirken, bazı senaryolarda kullanışlı olabilir.
      */

      dynamic value = "hello";
      MessageBox.Show(value);
      //Bu, "value" adlı bir dynamic değişkenidir ve başlangıçta "hello"
      //adlı bir string içerir. Dynamic değişkenler, C# dilinde herhangi
      //bir tipe sahip olabilirler ve değişkenin türü, çalışma zamanında belirlenir.


      //Dynamic değişkenler, özellikle veri kaynakları gibi dinamik yapılarda
      //kullanışlı olabilir. Örneğin, aşağıdaki gibi bir JSON nesnesini
      //dinamik bir değişken olarak kullanabilirsiniz:
      dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject("{ \"name\":\"John\", \"age\":35 }");
      MessageBox.Show(Newtonsoft.Json.JsonConvert.SerializeObject(json));


      //Dynamic değişkenler ayrıca C# dilinde dinamik tiplerle çalışmak için kullanılabilirler.
      //Örneğin, aşağıdaki gibi bir "dynamic" değişkeni kullanarak LINQ sorgularını oluşturabilirsiniz
      List<Arkadas> arkadaslar = new List<Arkadas>();
      arkadaslar.Add(new Arkadas { Ad = "Ali", Soyad = "Alkan", Telefon = "111111" });
      arkadaslar.Add(new Arkadas { Ad = "Ahmet", Soyad = "Soykan", Telefon = "22222" });
      dynamic query =
        from c in arkadaslar
        where c.Ad == "Ali"
        select c;
      foreach (dynamic arkadas in query)
      {
        MessageBox.Show(arkadas.Ad);
      }


      //Dynamic değişkenler, bazı senaryolarda kullanışlı olabilen esnek bir veri türüdür.
      //Ancak, tip güvenliği özelliğinden ödün vermekle birlikte, performansı olumsuz
      //etkileyebilirler ve uygun kullanılmadığında hatalara neden olabilirler.

    }

    class MyClass
    {
      public int MyProperty1 { get; set; }
      public string MyProperty2 { get; set; }
    }
    private void button7_Click(object sender, EventArgs e)
    {
      /*
      "Reflection", çalışma zamanında bir programın kendi yapılarını 
      (örneğin, sınıflar, metodlar, özellikler vb.) ve diğer programların 
      yapılarını inceleme ve bunlarla etkileşim kurma yeteneğidir. 
      Reflection, C# dilinin dinamik programlama özelliklerini kullanarak kodun 
      esnekliğini artırır ve bazı durumlarda gereklidir. 
      */

      Type type = typeof(MyClass);
      Debug.WriteLine(type.Name);

      PropertyInfo[] properties = type.GetProperties();
      foreach (PropertyInfo property in properties)
      {
        Debug.WriteLine(property.Name + " - " + property.PropertyType.ToString());
      }

      //Bu, "MyClass" adlı bir sınıfı tanımlayan ve Reflection'ı kullanarak
      //sınıfın özelliklerini yazdıran bir örnek kod parçasıdır.
      //"Type" adlı bir C# veri türü kullanılarak "MyClass" sınıfının
      //tipi alınır ve "GetProperties" metodu kullanılarak sınıfın
      //özellikleri alınır. Daha sonra, "foreach" döngüsü kullanılarak
      //her özellik için "Name" özelliği kullanılarak özelliğin adı yazdırılır.

      //Reflection, C# dilinde çok çeşitli senaryolarda kullanılabilir.
      //Ancak, kullanımı, bazı durumlarda güvenlik risklerine neden
      //olabilir ve performansı olumsuz etkileyebilir. Bu nedenle,
      //Reflection'ın kullanımını uygun şekilde anlamak ve kullanmak önemlidir.
    }


    private void button8_Click(object sender, EventArgs e)
    {
      /*
      "Boxing" ve "Unboxing", değer tipleri ile referans tipleri 
      arasında dönüşüm yapmak için kullanılan işlemlerdir.

      Değer tipleri, bellek alanlarında doğrudan değerleri saklayan tiplerdir. 
      Örneğin, int, float ve bool değer tiplerine örnek verilebilir. 
      Referans tipleri ise, bellek alanlarında nesne referanslarını 
      (yani, adresleri) saklayan tiplerdir. Örneğin, sınıflar, 
      diziler ve arayüzler referans tiplerine örnek verilebilir.

      Boxing, değer tipini Object türüne dönüştürme işlemidir. 
      Bu işlem, değer tipinin bellekteki değerini bir nesne olarak paketler.
      */

      int myInt = 10;
      object myObject = myInt; // Boxing

      int myInt2 = (int)myObject; // Unboxing


    }

    private void button13_Click(object sender, EventArgs e)
    {
      /*
      readonly anahtar kelimesi, değiştirilemez (immutable) 
      bir alan tanımlamak için kullanılır. Bir alan readonly olarak 
      işaretlendiğinde, bu alana sadece sınıfın kurucu metodu veya 
      başka bir static metodu tarafından değer atanabilir.
      */

 
      ReadonlyOrnek readonlyOrnek = new ReadonlyOrnek("Deneme");
      readonlyOrnek.ModifyValues();
      // Yukarıdaki sınıfa bağlı örnekte, myConstant ve myString alanları readonly olarak işaretlenmiştir. 
      // myConstant alanına sadece tanımlandığı yerde değer atanabilir, myString alanı ise
      // sınıfın kurucu metodu aracılığıyla atanabilir. ModifyValues() metodu ise bu
      // alanları değiştirmeye çalıştığında hata alır.

      /*
      readonly anahtar kelimesi, sınıflarda sabitler (constants) ile benzerlik gösterir. 
      Ancak, sabitler compile-time sabitlerdir ve sadece derleme zamanında 
      değiştirilebilirken, readonly alanlar runtime sabitlerdir ve sadece 
      sınıfın kurucu metodu veya static metotları tarafından değiştirilebilirler.
      */

    }

    public const int myConstantNumber = 5;
    public const string myConstantString = "hello world";
    private void button12_Click(object sender, EventArgs e)
    {
      /*
      const anahtar kelimesi, değiştirilemez (immutable) bir sabit 
      tanımlamak için kullanılır. Bir alan const olarak işaretlendiğinde, 
      bu alana sadece tanımlandığı yerde değer atanabilir ve daha sonra değiştirilemez.
      */


     //myConstantNumber = 10; // Bu satır hata verecektir, çünkü myConstant değiştirilemez bir sabittir.
      //myConstantString = "new value"; // Bu satır hata verecektir, çünkü myString değiştirilemez bir sabittir.


      /*
      const anahtar kelimesi, readonly anahtar kelimesi ile benzerlik gösterir. Ancak, const 
      sabitleri compile-time sabitlerdir ve sadece tanımlandıkları yerde değer atanabilirken, 
      readonly alanları runtime sabitlerdir ve sadece sınıfın kurucu metodu veya 
      static metotları tarafından değiştirilebilirler.
      */
    }


    public struct PointTest_Struct
    {
      public int X;
      public int Y;

      public PointTest_Struct(int x, int y)
      {
        X = x;
        Y = y;
      }

      public void Move(int deltaX, int deltaY)
      {
        X += deltaX;
        Y += deltaY;
      }
    }
    struct ProductTest_Struct
    {
      public string Name;
      public decimal Price;
      public DateTime ManufacturedDate;
      public DateTime ExpiryDate;

      public bool IsExpired()
      {
        return ExpiryDate < DateTime.Now;
      }
    }
    private void button11_Click(object sender, EventArgs e)
    {
      /*
      struct anahtar kelimesi, değer tipi (value type) veri tiplerini 
      tanımlamak için kullanılır. Struct'lar, sınıflara benzer şekilde veri alanları 
      ve fonksiyonlar içerebilirler, ancak bir struct tanımlamak, sınıf tanımlamak 
      kadar kapsamlı bir işlem değildir.

      Struct'lar, sınıfların aksine değer tipi olarak tutulurlar. Bu nedenle, 
      bir struct değişkeni yaratıldığında, bellekte ayrı bir alan oluşur ve 
      struct değişkenine atanan değer direkt olarak bu alanda tutulur. Bu, sınıflardan 
      farklı olarak, struct'ların referans tipleri olan sınıfların aksine stack 
      bellek üzerinde tutulmasını sağlar ve performansı artırabilir.
      */


      PointTest_Struct p = new PointTest_Struct();
      p.Move(33, 66);
      MessageBox.Show($"x={p.X} , y={p.Y}");
      //Yukarıdaki örnekte, Point isimli bir struct tanımlanmıştır.
      //Bu struct iki adet int tipinde X ve Y alanlarına sahiptir.
      //Ayrıca, bir kurucu metot ve Move isimli bir fonksiyon da bulunmaktadır.


      ProductTest_Struct pr = new ProductTest_Struct();
      pr.ExpiryDate = DateTime.Now.AddDays(-1);
      MessageBox.Show(pr.IsExpired() ? "Son kullanma tarihi geçmiş" : "Kullanılabilir");
      // Yukarıdaki örnekte, Product isimli bir struct tanımlanmıştır.
      // Bu struct, bir ürünün adını, fiyatını, üretim tarihini ve son kullanma tarihini içerir.
      // Ayrıca, IsExpired fonksiyonu, ürünün son kullanma tarihine göre geçerlilik durumunu kontrol eder.
      // ************
      // Bu struct, bir ürün veritabanında veya bir alışveriş sepetinde tutulabilir.
      // Ürünlerin yapısı ve özellikleri sınırlı olduğu için, struct yapısı kullanmak
      // hem bellek yönetimi hem de performans açısından daha iyi olabilir.
      // ************


      /*
      Struct'lar, genellikle küçük ve hafif verileri taşımak için kullanılır. 
      Örneğin, Point struct'ı gibi koordinatlar veya DateTime struct'ı gibi 
      tarih/saat bilgileri tutmak için kullanılabilirler.

      Struct'lar, sınıflar gibi erişim belirleyiciler (access modifiers), 
      construct'lar (constructors), fonksiyonlar (methods), alanlar (fields) ve 
      özellikler (properties) içerebilirler. Ancak, struct'lar inheritance (kalıtım) 
      yapamazlar ve sadece diğer struct'lar veya Object sınıfından miras alabilirler. 
      Struct'ların yaratılması ve kullanımı, sınıfların yaratılması ve kullanımından 
      farklı değildir, ancak performans artışı sağlayabilirler.
      */



      // enum - struct fark
      /*
      Struct ve enum, C# programlama dilinde farklı amaçlar için kullanılan iki farklı veri tipidir.

      Struct, bir veri tipi olup, özel bir nesne oluşturulmasına olanak sağlar. 
      Değer tipi olarak kullanılan struct nesneleri, stack bellekte depolanır ve 
      heap bellek kullanımından kaçınarak performans açısından avantaj sağlarlar. 
      Struct'lar, içinde veri saklamak için kullanılırlar.

      Enum ise, bir tamsayı veri tipi olup, sıralı sabit değerler listesini temsil eder. 
      Enum, programcıların belirli bir değeri önceden tanımlamalarına ve daha sonra bu değere referans vermelerine olanak sağlar. 
      Enum, kodun okunabilirliğini arttırmak için kullanılır ve sık kullanılan sabitlerin tutulması amacıyla tercih edilir.

      Özetle, struct, veri saklamak için kullanılan bir veri tipi iken, enum sabit değerlerin listesini temsil eder. 
      Struct'lar nesne olarak tanımlanır ve stack'ta depolanırken, 
      enum'lar tamsayı değerlerinden oluşur ve değerleri varsayılan olarak 0'dan başlayarak sırayla arttırılır.
      */
    }

    public class BankAccount_Encapsulation
    {
      private decimal balance;

      public decimal GetBalance()
      {
        return balance;
      }

      public void Deposit(decimal amount)
      {
        balance += amount;
      }

      public void Withdraw(decimal amount)
      {
        if (amount <= balance)
        {
          balance -= amount;
        }
      }
    }
    private void button10_Click(object sender, EventArgs e)
    {
      /*
      "Encapsulation", nesne yönelimli programlama prensiplerinden biridir. 
      Encapsulation, bir sınıfın içindeki verilerin ve fonksiyonların dışarıdan erişilmesini 
      kontrol etmek anlamına gelir. Yani, sınıfın içindeki veriler ve fonksiyonlar, 
      sadece sınıfın kendisi tarafından kullanılabilir ve diğer sınıflar tarafından 
      erişilemez hale getirilir.

      Encapsulation'ın temel amacı, kodun sadece doğru şekilde çalışmasını sağlamakla kalmaz, 
      aynı zamanda kodun bakımını ve yeniden kullanılabilirliğini kolaylaştırır. 
      Encapsulation, aynı zamanda, sınıfın iç yapısını ve verilerini diğer kod parçalarından gizleyerek, 
      kodun güvenliğini de arttırır.

      Encapsulation, C# dilinde birkaç farklı yolla sağlanabilir. Bunlar arasında:
      * Access Modifiers: C# dilinde, erişim belirteçleri (access modifiers) kullanarak, 
          sınıfın içindeki verilere ve fonksiyonlara erişimin kontrol edilmesi sağlanabilir. 
          Access modifiers, "public", "private", "protected", "internal" ve "protected internal" 
          olarak beş farklı seçenek sunar. "public" erişim belirteci, sınıfın herhangi bir yerinde 
          erişilebilir olmasını sağlarken, "private" erişim belirteci, sadece sınıfın içindeki 
          fonksiyonlar tarafından erişilebilir olmasını sağlar.
      * Properties: C# dilinde, properties kullanarak, sınıfın içindeki verilerin dışarıdan 
          erişilmesi kontrol edilebilir. Bir property, bir get ve set metodu içerir ve bu 
          metotlar sayesinde, sınıfın dışında veri okunabilir veya değiştirilebilir.
      * Methods: C# dilinde, sınıfın içindeki fonksiyonların, sadece belirli bir amaç için 
          kullanılması sağlanabilir. Fonksiyonların adı, parametreleri ve dönüş değerleri, 
          sınıfın dışında kullanılmayacak şekilde tasarlanabilir.
      */


      BankAccount_Encapsulation bae = new BankAccount_Encapsulation();
      bae.Deposit(150);
      bae.Withdraw(100);
      MessageBox.Show(bae.GetBalance().ToString());
      // Bu örnekte, "balance" adlı bir private değişken kullanılarak, hesap bakiyesi saklanır.
      // "GetBalance", "Deposit" ve "Withdraw" adlı public fonksiyonlar kullanılarak,
      // hesap bakiyesi ile ilgili işlemler gerçekleştirilir. "GetBalance" fonksiyonu,
      // sadece hesap bakiyesini döndürürken, "Deposit" ve "Withdraw" fonksiyonları,
      // hesap bakiyesi üzerinde değişiklik yapar
    }

    public class Shape_VirtualOverride
    {
      public virtual double GetArea()
      {
        return 0;
      }
    }
    public class Circle_VirtualOverride : Shape_VirtualOverride
    {
      private double radius;

      public Circle_VirtualOverride(double r)
      {
        radius = r;
      }
      public override double GetArea()
      {
        return Math.PI * radius * radius;
      }
    }
    private void button14_Click(object sender, EventArgs e)
    {
      /*
      virtual ve override anahtar kelimeleri, C# programlama dilinde nesne yönelimli 
      programlama için kullanılan iki önemli anahtar kelimedir.

      virtual anahtar kelimesi, bir sınıfın veya sınıfın üyesinin alt sınıflar tarafından 
      değiştirilebilir olduğunu belirtir. Bir sınıfta bir yöntemi virtual olarak işaretlerseniz, 
      alt sınıflar bu yöntemi yeniden tanımlayabilirler ve kendi özelliklerine uygun bir şekilde 
      özelleştirebilirler. Ancak, alt sınıfların override anahtar kelimesi ile yeniden tanımlaması gereklidir. 
      Virtual yöntemler, alt sınıflar tarafından kullanılabildiği için genişletilebilirliği artırır.

      override anahtar kelimesi, bir alt sınıfta virtual olarak işaretlenmiş bir yöntemin 
      yeniden tanımlanacağını belirtir. Yani, override ile işaretlenen yöntem, 
      temel sınıftaki virtual yöntemin yerine geçer.
      */


      Circle_VirtualOverride circle = new Circle_VirtualOverride(6);
      MessageBox.Show(circle.GetArea().ToString());
      // yukarıdaki örnekte Circle sınıfındaki GetArea() yöntemi, Shape sınıfındaki
      // virtual yöntemi yeniden tanımlar. override anahtar kelimesi ile GetArea() yöntemi
      // yeniden tanımlandığı için, Circle sınıfı Shape sınıfını genişletir ve Circle
      // sınıfının özelliklerine uygun bir şekilde GetArea() yöntemi çağrılabilir hale gelir.
    }


    public class Animal_Inheritance
    {
      public string Name { get; set; }
      public int Age { get; set; }
      public virtual void MakeSound()
      {
        MessageBox.Show("Hayvan ses çıkartır");
      }
    }
    public class Dog_Inheritance : Animal_Inheritance
    {
      public void Bark()
      {
        MessageBox.Show("Hav Hav Hav");
      }
      public override void MakeSound()
      {
        MessageBox.Show("Hav Hav Hav");
      }
    }
    private void button9_Click(object sender, EventArgs e)
    {
      /*
      "inheritance" veya Türkçe karşılığıyla "miras alma", nesne yönelimli programlama prensiplerinden biridir. 
      Inheritance, bir sınıfın başka bir sınıftan tüm özelliklerini miras almasına olanak sağlar. 
      Miras alınan sınıf, "base class" veya "parent class" olarak adlandırılırken, 
      miras alan sınıf, "derived class" veya "child class" olarak adlandırılır.

      Inheritance, kodun yeniden kullanılabilirliğini arttırır ve kodun okunabilirliğini ve bakımını kolaylaştırır. 
      Miras alan sınıf, miras aldığı sınıfın tüm özelliklerine sahip olur ve bu özellikleri 
      istediği şekilde kullanabilir veya değiştirebilir.

      C# dilinde inheritance, "class" keyword'ünün yanı sıra, "interface" ve 
      "abstract class" yapıları kullanılarak sağlanabilir.
      */

      Animal_Inheritance animal = new Animal_Inheritance();
      animal.MakeSound();

      Dog_Inheritance dog = new Dog_Inheritance();
      dog.Bark();
      dog.MakeSound();

      // Bu örnekte, "Animal" adlı bir base class oluşturulur. Bu sınıfın içinde, hayvanın adı ve yaşı için
      // iki property tanımlanır. Ayrıca, "MakeSound" adlı bir virtual fonksiyon kullanılarak,
      // hayvanın nasıl ses çıkardığı belirtilir.
      // "Dog" adlı bir derived class ise, "Animal" sınıfından miras alınır.
      // Bu sınıfın içinde, "Bark" adlı bir fonksiyon kullanılarak, köpeğin havlama özelliği tanımlanır.
      // Ayrıca, "MakeSound" fonksiyonu da override edilerek, köpeğin nasıl havladığı belirtilir.
      // Böylece, "Dog" sınıfı, "Animal" sınıfının tüm özelliklerine sahip olur ve
      // köpek özelindeki özellikleri de eklenmiş olur.
    }

    public class Cat_Polymorphism : Animal_Inheritance
    {
      public override void MakeSound()
      {
        MessageBox.Show("Miyav");
      }
    }
    private void button15_Click(object sender, EventArgs e)
    {
      /*
      Polymorphism, nesne yönelimli programlama prensiplerinden biridir ve aynı isimde fakat 
      farklı parametrelerle birden fazla fonksiyonun tanımlanmasına olanak sağlar.
      Polymorphism, bir nesnenin farklı şekillerde davranabilmesini sağlayan bir programlama konseptidir.
      Bu sayede, farklı tiplerde nesnelerin aynı fonksiyonu kullanarak farklı sonuçlar üretmesi sağlanır.

      Polymorphism, bir sınıfın, birden fazla sınıfın bir örneği olarak davranabilmesi anlamına gelir. 
      Bu, bir nesnenin farklı durumlarda veya farklı koşullarda farklı şekillerde davranabilmesine olanak tanır. 
      Polymorphism, kodun daha ölçeklenebilir ve genişletilebilir hale gelmesine yardımcı olabilir.

      Polymorphism, genellikle kalıtım ve sınıf hiyerarşileriyle ilişkilendirilir.
      Bir alt sınıf, üst sınıfın bir örneği olarak davranabilir. 
      Böylece, bir üst sınıfın yöntemi bir alt sınıfta yeniden tanımlanabilir ve 
      alt sınıftaki örnekte bu yöntem çağrılabilir. Bu, Polymorphism'in bir örneğidir.

      Polymorphism, inheritance ve interface yapılarıyla kullanılabilir. 
      Inheritance ile polymorphism kullanıldığında, bir derived class, base class'ın fonksiyonunu 
      override ederek kendi özel gereksinimlerine göre işleyebilir. 
      Interface ile polymorphism kullanıldığında ise, farklı sınıfların aynı fonksiyonu implemente ederek, 
      bu fonksiyonun farklı şekillerde çalışmasını sağlayabilirler.
      */


      Cat_Polymorphism cat = new Cat_Polymorphism();
      cat.MakeSound();
      // Bu örnekte, "Animal" adlı bir sınıf oluşturulur ve bu sınıfın içinde "MakeSound" adlı bir virtual
      // fonksiyon tanımlanır. "Cat" adlı sınıf ise "Animal" sınıfından miras alınır ve "MakeSound" fonksiyonu
      // override edilerek, kedilerin miyavlaması sağlanır. Bu sayede, "Animal" tipinde bir değişkene kedi
      // atanması durumunda, "MakeSound" fonksiyonu her iki tipte de farklı şekillerde çalışacaktır.

    }

    private void button16_Click(object sender, EventArgs e)
    {
      /*
      C# dilinde string interpolation, string ifadeleri oluşturmanın bir yoludur. 
      Bu yöntem, string ifadelerinin içerisinde değişkenleri, ifadeleri veya metotları 
      yerleştirmeyi kolaylaştırır.

      String interpolation, $"..." formatı kullanılarak yapılır. 
      Süslü parantezlerin içerisine değişkenler, ifadeler veya metot çağrıları yazılabilir ve 
      bu ifadeleri {} içerisinde yazarak, süslü parantezlerin içerisinde kullanabilirsiniz. Örneğin:
      */

      int age = 25;
      string name = "John";
      MessageBox.Show($"My name is {name} and I am {age} years old.");
    }

    private void button17_Click(object sender, EventArgs e)
    {
      /*
      Improved support for interpolated strings / Enterpolasyonlu dizeler için geliştirilmiş destek
      C# 10 ile birlikte, içerisinde daha fazla ifade bulunan öntanımlı dizeler 
      (interpolated strings) için daha fazla destek eklenmiştir. 
      Bu, öntanımlı dizelerin daha kolay bir şekilde oluşturulmasını sağlar ve 
      ayrıca daha okunaklı ve sürdürülebilir kod yazmaya yardımcı olur. 
      */

      int a = 10;
      int b = 20;
      MessageBox.Show($"Toplam: {a + b}, Fark: {a - b}");
      // Daha fazla ifade desteği: Öntanımlı dizelerde artık daha fazla ifade kullanılabilir.

      int c = 10;
      MessageBox.Show($"Sayı: {c:D4}"); // Çıktı: "Sayı: 0010"
      // Formatlama özelleştirme: Öntanımlı dizeler artık daha esnek bir şekilde biçimlendirilebilir. 

      string name = "Ahmet";
      MessageBox.Show($"{name.ToUpper()}");
      //String interpolation için fonksiyonlar: Artık öntanımlı dizelerde
      //fonksiyonlar kullanarak string interpolation yapmak mümkündür
    }

    private void button18_Click(object sender, EventArgs e)
    {
      /*
      Constant Interpolation, C# 10 ile birlikte gelen bir özelliktir. 
      Bu özellik sayesinde string ifadelerinde sabitlerin (const) kullanılması mümkün hale gelir.

      Önceden, string ifadelerinde sabitler kullanmak için string concatenation 
      veya string interpolation yöntemleri kullanılırdı. 
      Ancak bu yöntemler sabitlerin değişmemesini garanti edemez ve hata riski taşır.

      Constant Interpolation ile sabitleri string ifadelerinde 
      doğrudan kullanmak mümkündür ve bu sayede hata riski ortadan kalkar.
      */

      const int a = 5;
      const string b = "The value of a is: {a}";
      MessageBox.Show($"{b}");
      // Bu örnekte, a sabiti {a} yerine doğrudan kullanılmıştır. Bu sayede a sabiti
      // string ifadesine sabit bir şekilde yerleştirilmiş ve hata riski ortadan kalkmıştır.
    }

    // interface
    interface IShape_Interface
    {
      void Draw();
    }
    class Circle_Interface : IShape_Interface
    {
      public void Draw()
      {
        MessageBox.Show("Drawing a circle.");
      }
    }
    class Square_Interface : IShape_Interface
    {
      public void Draw()
      {
        MessageBox.Show("Drawing a square.");
      }
    }
    // abstract
    abstract class Animal_Abstract
    {
      public abstract void MakeSound();
      public void Move()
      {
        MessageBox.Show("Hayvan hareket eder");
      }
    }
    class Dog_Abstract : Animal_Abstract
    {
      public override void MakeSound()
      {
        MessageBox.Show("Hav");
      }
    }
    class Cat_Abstract : Animal_Abstract
    {
      public override void MakeSound()
      {
        MessageBox.Show("Miyav");
      }
    }
    private void button19_Click(object sender, EventArgs e)
    {
      /*
      interface ve abstract sınıflar nesne yönelimli programlama prensiplerinin 
      uygulanmasında önemli bir rol oynarlar. Hem interface hem de abstract sınıflar, 
      kalıtım ve polimorfizm gibi kavramların uygulanmasında kullanılır. 
      Ancak, farklı yapı ve kullanım şekilleri vardır.
      */

      /*
      Interface, bir sınıfın belirli özelliklere sahip olduğunu belirten bir sözleşmedir. 
      Bir interface, sınıfların belli bir davranışı göstermelerini sağlar. 
      Bir sınıf birden fazla interface'i implemente edebilir. 
      Interface'ler, içerisindeki metodları sadece tanımlar ve içerikleri yoktur. 
      Sınıflar, interface'leri implemente ederek, içerisindeki metodların kodlarını yazmak zorundadır.
      */

      Square_Interface square = new Square_Interface();
      square.Draw();
      // Bu örnekte, "IShape" adlı bir interface tanımlanır ve içerisinde "Draw" adlı bir metod bulunur.
      // "Circle" ve "Square" adlı sınıflar, "IShape" interface'ini implemente ederler
      // ve içerisindeki "Draw" metodunu uygularlar.


      /*
      Abstract sınıflar ise, tamamlanmamış sınıflardır ve içerisinde hem soyut hem de normal metotlar bulunabilir. 
      Abstract sınıflar, soyut metotlar sayesinde, kalıtım yapılarının belirli bir şekilde yapılmasını sağlar. 
      Soyut metotlar sadece tanımlanır, içerikleri yoktur ve abstract sınıfı miras alan sınıflar 
      bu metotları kendi ihtiyaçlarına göre uygularlar. Normal metotlar ise içerikleriyle birlikte 
      tanımlanır ve sınıflar bu metotları direkt olarak kullanabilirler. Abstract sınıflardan nesne oluşturulamaz.

      abstract anahtar kelimesi, soyutlama yapmak ve kalıtımı kolaylaştırmak için kullanılır.

      Bir sınıf veya yöntem abstract olarak işaretlendiğinde, bu onların somutlaştırılamayacağı 
      ve bir türetilmiş sınıf veya alt sınıfta yeniden tanımlanması gerektiği anlamına gelir. 
      abstract anahtar kelimesi, bir sınıf veya yöntemin tam olarak nasıl uygulanacağına dair bir şablon sağlar 
      ve kalıtım yoluyla bu şablonu kullanarak yeni sınıflar veya yöntemler oluşturulmasına izin verir.
      */

      // Animal_Abstract animal = new Animal_Abstract(); // !!! hata  
      Cat_Abstract cat = new Cat_Abstract();
      cat.Move();
      cat.MakeSound();
      // Bu örnekte, "Animal" adlı bir abstract sınıf tanımlanır ve içerisinde "MakeSound" adlı bir soyut metot ve
      // "Move" adlı bir normal metot bulunur. "Dog" ve "Cat" adlı sınıflar, "Animal" sınıfını miras alır ve
      // "MakeSound" metodunu override ederek kendi ihtiyaçlarına göre uygularlar.
      // "Move" metodunu ise direkt olarak kullanabilirler.
    }

    public class MyException : Exception
    {
      public MyException() : base("Özel hata mesajı") { }
    }
    private void button20_Click(object sender, EventArgs e)
    {
      // Throw/ Try-Catch / When / Finally, C# dilinde hata yakalama ve yönetme mekanizmalarını sağlar.

      /*
      Throw anahtar kelimesi, bir hata durumunda özel bir istisna nesnesi fırlatmamızı sağlar. 
      Try-Catch blokları, kodda meydana gelen hataları yakalamak için kullanılır. 
      When anahtar kelimesi, try-catch bloklarının yanı sıra belirli hata türleri için belirli koşullar belirleyebilir. 
      Finally anahtar kelimesi, try-catch bloğunun sonunda her durumda çalışacak olan kod bloğunu temsil eder.
      */

      try
      {
        int a = 10;
        int b = 0;
        if (b == 0)
        {
          throw new DivideByZeroException("Cannot divide by zero.");
        }
        int c = a / b;
        MessageBox.Show(c.ToString());
      }
      catch (DivideByZeroException ex)
      {
        MessageBox.Show("Error: " + ex.Message);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex.Message);
      }
      finally
      {
        MessageBox.Show("The program has finished executing.");
      }
      // Bu örnekte, önce try bloğu içerisinde bir sayıyı 0'a bölmeye çalışıyoruz.
      // Böyle bir durumda DivideByZeroException türünde bir istisna fırlatılıyor.
      // Bu hatayı yakalamak için catch blokları kullanıyoruz. İlk catch bloğu,
      // DivideByZeroException türünde bir hata için çalışırken, ikinci catch bloğu
      // Exception türünde bir hata için çalışır. Finally bloğu, kodun çalışmasından
      // sonra her durumda çalışacak olan kod bloğunu temsil eder.

      try
      {
        int a = 10;
        int b = 0;
        int c = a / b;
        MessageBox.Show(c.ToString());
      }
      catch (DivideByZeroException ex) when (ex.Message.Contains("zero"))
      {
        MessageBox.Show("Error: " + ex.Message);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex.Message);
      }
      finally
      {
        MessageBox.Show("The program has finished executing.");
      }
      // Bu örnekte, When anahtar kelimesi kullanarak DivideByZeroException
      // türünde bir hatayı yakalamadan önce, hatanın "zero" kelimesini içermesi koşulunu belirledik.


      // Nested Try-Catch: Bir try-catch bloğunun içinde başka bir try-catch bloğu kullanarak,
      // daha ayrıntılı hata yönetimi sağlayabilirsiniz.
      try
      {
        // Kodlar
        try
        {
          // Kodlar
        }
        catch (Exception ex)
        {
          // Hata yönetimi
          MessageBox.Show(ex.Message);
        }
      }
      catch (Exception ex)
      {
        // Hata yönetimi
        MessageBox.Show(ex.Message);
      }


      //Rethrowing Exceptions: Bir hata durumunda, hatayı yeniden fırlatarak,
      //üst seviye try-catch bloklarında yönetebilirsiniz.
      try
      {
        // Kodlar
      }
      catch (Exception ex)
      {
        // Hata yönetimi
        MessageBox.Show(ex.Message);
        throw;
      }

      // Custom Exceptions: Kendi özel hata türlerinizi oluşturabilirsiniz.
      try
      {
        // Kodlar
        throw new MyException();
      }
      catch (MyException ex)
      {
        // Özel hata yönetimi
        MessageBox.Show(ex.Message);
      }
      catch (Exception ex)
      {
        // Genel hata yönetimi
        MessageBox.Show(ex.Message);
      }

      // istenilen hata mesajı veya özel hata türü fırlatmak için kullanılır.
      try
      {
        int x = 0;
        // Kodlar
        if (x == 0)
        {
          throw new Exception("X değeri sıfır olamaz!");
        }
      }
      catch (Exception ex)
      {
        // Hata yönetimi
        MessageBox.Show(ex.Message);
      }
    }

    public IEnumerable<int> GetNumbers()
    {
      yield return 1;
      yield return 2;
      yield return 3;
    }
    public IEnumerable<int> GetNumbers(int start, int end)
    {
      for (int i = start; i <= end; i++)
      {
        yield return i;
      }
    }
    private void button21_Click(object sender, EventArgs e)
    {
      /*
      yield anahtar kelimesi, C# programlama dilinde, özellikle koleksiyonlar üzerinde çalışırken, 
      bellekte yer tutmamak için kullanılan bir anahtar kelime olarak kullanılır.
      genellikle bellek kullanımını ve performansı iyileştirmek için kullanılır.

      yield, bir metot içindeki döngüyü askıya alarak, döngüdeki her elemanı tek tek geri döndürür. 
      Bu sayede, koleksiyonlardaki elemanları tek tek döndürmek yerine, 
      bellekte yer tutmadan ve performans kaybı yaşamadan elemanları tek tek işleyebilirsiniz.

      yield anahtar kelimesi, bir yöntemin iterator olacağını belirtmek için kullanılır. 
      Iterator yöntemler, sonraki elemanı döndürmek için çağrıldıklarında çalışırlar. 
      yield return anahtar kelimesi ise, bir iterator yönteminde kullanılan bir ifadedir ve 
      yield anahtar kelimesi ile birlikte kullanılır. Bu ifade, iterator tarafından döndürülen değeri belirtir.

      yield return ifadesi, bir yöntemdeki çalışma zamanı duraklamasını sağlar ve yöntemin çağrılmasını bekletir. 
      İterator yöntem, döndürülecek elemanları bellekte tutmak yerine, her bir elemanı çağıran metoda geri döndürür. 
      Bu, bellek kullanımını ve performansı iyileştirir, çünkü tüm elemanlar bellekte tutulmak zorunda kalmaz.

      yield anahtar kelimesi, IEnumerable<T> veya IEnumerator<T> 
      arayüzlerini uygulayan sınıfların oluşturulmasında kullanılır.
      */

      foreach (var item in GetNumbers())
      {
        MessageBox.Show(item.ToString());
      }
      // Bu kod bloğunda, GetNumbers() adlı bir metot oluşturduk ve içerisindeki yield return
      // ifadeleri ile elemanları tek tek döndürüyoruz. Bu metodu çağırdığınızda,
      // her yield return ifadesinde bir eleman döndürülecektir.


      var numbers = GetNumbers(2, 5);
      foreach (var number in numbers)
      {
        MessageBox.Show(number.ToString());
      }
      // Bu kod, GetNumbers metodunu çağırarak bir IEnumerable<int> koleksiyonu
      // elde eder ve her bir elemanını foreach döngüsü ile ekrana yazdırır.
      // Bu yöntem, büyük verilerle çalışırken bellek kullanımını düşük tutmak için çok kullanışlıdır.


      var numberse = GetNumbers(5, 9);
      var evenNumbers = numberse.Where(n => n % 2 == 0);
      foreach (var number in evenNumbers)
      {
        Console.WriteLine(number);
      }
      // Bu kod, GetNumbers metodunu çağırarak bir IEnumerable<int> koleksiyonu elde eder ve
      // ardından Where sorgusu ile sadece çift sayıları içeren yeni bir koleksiyon oluşturur.
      // Son olarak, foreach döngüsü ile bu koleksiyondaki her bir elemanı ekrana yazdırır.

    }

    public record Person_Record(string FirstName, string LastName, int Age);
    public record TableData_Record
    {
      public TableData_Record(string tableName, IEnumerable<Person_Record> data)
      {
        TableName = tableName;
        Data = data;
      }
      public string TableName { get; init; }
      public IEnumerable<Person_Record> Data { get; init; }
    }
    private void button22_Click(object sender, EventArgs e)
    {
      /*
      C# 9.0 sürümü ile birlikte tanıtılan "record" özelliği, nesne odaklı programlama yaklaşımında, 
      verilerin değil davranışların önemli olduğu durumlarda kullanılan bir yapıdır. 
      Record, yapı olarak sınıflara benzer ama özellikleri daha azdır ve daha az kod yazarak 
      nesnelerin tanımlanmasını ve kullanılmasını kolaylaştırır.

      Record yapısı, bir sınıfın sahip olduğu bazı özelliklerin yanı sıra, özel olarak tanımlanmış birkaç özellik içerir. 
      Record'lar varsayılan olarak "değer tipi" davranışı sergiler ve immutable'dır, yani değerleri değiştirilemez. 
      Record'lar, verileri taşımak için kullanılan yapısal veri tiplerinden farklı olarak, 
      verilerin yanı sıra, verileri işleyen davranışları da içerirler.

      Record'lar, veri transfer nesneleri, DTO (Data Transfer Object), POCO (Plain Old CLR Object) gibi kullanımlarda sıkça tercih edilir. 
      Record'lar, nesnelerin üretimini kolaylaştırdığı için kodun daha okunaklı ve sürdürülebilir olmasını sağlar.
      */

      var tableData = new TableData_Record("PersonTable", new List<Person_Record> {
          new Person_Record("John", "Doe", 35),
          new Person_Record("Jane", "Doe", 30),
          new Person_Record("Alice", "Smith", 25)
      });

      MessageBox.Show($"Table Name: {tableData.TableName}");
      foreach (var person in tableData.Data)
      {
        MessageBox.Show($"{person.FirstName} {person.LastName}, {person.Age}");
      }

      // Yukarıdaki örnekte, "Person" adında bir record tanımlanmıştır.
      // Bu record, "Name" ve "Age" adında iki özelliğe sahiptir. "record" anahtar kelimesi
      // ile tanımlanan bu yapı, "Name" ve "Age" özellikleri dışında,
      // nesnenin eşitlik, kopyalama, sıralama gibi davranışlarını da içerir.

    }

    public class Person_Init
    {
      public string Name { get; init; }
      public int Age { get; set; }
    }
    private void button23_Click(object sender, EventArgs e)
    {
      /*
      get, set ve init anahtar kelimeleri, C# programlama dilinde bir özelliğin ne kadar erişilebilir 
      olduğunu belirlemek için kullanılır. Bu anahtar kelimeler, nesne yönelimli 
      programlamada veri bütünlüğünü korumak ve kodun okunabilirliğini artırmak için önemlidir.

      get anahtar kelimesi, bir özelliğin değerini almak için kullanılırken, 
      set anahtar kelimesi, bir özelliğin değerini atamak için kullanılır. 
      Özellik, okuma ve yazma işlemine açık olursa, hem get hem de set kullanılır.

      C# 9.0 ile birlikte, init anahtar kelimesi de kullanılmaya başlandı. 
      init anahtar kelimesi, yalnızca özelliğin başlatıcı tarafından ilk değeri atanırken kullanılır. 
      Özellik, başlatıcıdan sonra salt okunur hale gelir. 
      Bu, özellik değerinin nesne oluşturulduktan sonra değiştirilemez olmasını sağlar ve 
      nesne yönelimli programlamada "immutability" (değişmezlik) prensibine uygunluğu artırır.
      */

      var person = new Person_Init { Name = "Ali Baba", Age = 99 };
      // person.Name = "Veli"; // !!! Hata
      person.Age = 30;
      // Name özelliği sadece okunabilir ve sadece başlangıçta bir değer atanabilir.
      // Age özelliği ise okunabilir ve yazılabilir.

    }

    public record Person_With
    {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public int Age { get; set; }
    }
    private void button24_Click(object sender, EventArgs e)
    {
      /*
      C# 9.0'da sunulan "with" ifadesi, mevcut nesnelerin kopyalarını oluşturmak ve 
      bu kopyalar üzerinde değişiklik yapmak için kullanılır. 
      "with" ifadesi, özellik değerlerini değiştirerek yeni bir nesne döndürür. 
      Bu sayede, mevcut nesneyi değiştirmeden, yeni bir nesne oluşturarak üzerinde değişiklik yapabilirsiniz.

      // ???? with anahtar kelimesi, sadece record tipleri ve struct yapıları için kullanılabilir.
      // *** Ek
      with anahtar kelimesi, C# 9.0'da tanıtılan bir özellik olup, sadece record tipleri ve struct yapıları ile kullanılabilir.
      record tipleri, özellikleri okunabilir ve değiştirilemez olan veri yapılarıdır. with anahtar kelimesi, 
      bir record tipindeki özelliklerin kopyasını alıp değiştirerek yeni bir record tipi örneği oluşturmak için kullanılabilir.
      struct yapıları ise, değer tipleridir ve classlardan farklı olarak değer kopyaları oluştururlar. with anahtar kelimesi, 
      bir struct tipindeki özelliklerin kopyasını alıp değiştirerek yeni bir struct örneği oluşturmak için de kullanılabilir.
      Öte yandan, class tiplerinde with anahtar kelimesi kullanılamaz. Çünkü class tipleri referans tipleridir ve değişkenler 
      sadece referansları tutarlar. Bu nedenle, class tiplerinde özelliklerin kopyalanması, 
      sadece yeni bir referans değişkeni oluşturularak yapılabilir.
      */

      // Person sınıfından bir örnek oluşturuyoruz
      Person_With person1 = new Person_With { FirstName = "Ali", LastName = "Baba", Age = 99 };

      // with anahtar kelimesi kullanarak mevcut örneğin kopyasını oluşturuyoruz ve özelliklerinden birini değiştiriyoruz
      Person_With person2 = person1 with { Age = 40 };

      MessageBox.Show($"Original Person: {person1.FirstName} {person1.LastName}, {person1.Age}");
      MessageBox.Show($"New Person: {person2.FirstName} {person2.LastName}, {person2.Age}");

      // Yukarıdaki örnekte, Person sınıfı bir record tipidir ve with anahtar kelimesi kullanarak
      // özelliklerinin kopyasını almak ve değiştirmek mümkündür.
      // Bu sayede, mevcut örneğin değişikliğe uğramaması sağlanır.
    }

    private void button25_Click(object sender, EventArgs e)
    {
      /*
      C# 6.0 sürümünde eklenen "using static" ifadesi, belirli bir sınıfın statik 
      üyelerine erişirken sürekli olarak sınıf adını yazmaktan kurtulmak için kullanılır. 
      Bu ifade, bir statik sınıfın adını using ifadesiyle birleştirir ve statik üyelerine, 
      sınıf adını belirtmeden erişmenizi sağlar.
      */

      /*
      using System;
      using static System.Math;

        namespace MyProgram
        {
          class Program
          {
      */

      double radius = 5;
      double area = PI * radius * radius;
      double roundedValue = Round(3.14159265358979323846, 2);
      MessageBox.Show($"Area: {area}"); // Output: Area: 78.53981633974483
      MessageBox.Show($"Rounded Value: {roundedValue}"); // Output: Rounded Value: 3.14

      // Bu örnekte, "using static System.Math" ifadesi kullanılarak, Math sınıfının statik üyelerine
      // sınıf adını yazmadan erişilebilir hale getirildi.
      // Böylece PI sabiti ve Round metoduna sınıf adını belirtmeden erişilebilir hale geldi.

      // "using static" ifadesi, sadece statik üyeleri olan sınıflarda kullanılabilir.
      // Ayrıca, kullanırken dikkatli olunmalıdır çünkü belirli bir sınıfın tüm statik üyeleri,
      // kodun okunabilirliğini azaltabilir.
    }

    public int MyProperty_nameof { get; set; }

    private void button26_Click(object sender, EventArgs e)
    {
      /*
      C# 6.0 sürümüyle birlikte eklenen "nameof" ifadesi, kodun okunabilirliğini arttırmak için kullanılan bir ifadedir. 
      Bu ifade, bir nesne, değişken, özellik, metod veya sınıf adının metinsel olarak alınmasını sağlar.
      */

      MessageBox.Show(nameof(Uygulamalar)); // Output: Uygulamalar
      MessageBox.Show(nameof(MyProperty_nameof)); // Output: MyProperty
      MessageBox.Show(nameof(button26_Click)); // Output: MyMethod

    }



    //File1.cs
    public partial class MyPartialClass
    {
      public void Method1()
      {
        // implementation
      }
    }

    //File2.cs
    public partial class MyPartialClass
    {
      public void Method2()
      {
        // implementation
      }
    }
    private void button29_Click(object sender, EventArgs e)
    {
      /*
      C# partial class, bir sınıfın tanımını iki ya da daha fazla koda parçaya ayırarak tanımlamak için kullanılır. 
      Bu sayede bir sınıfın farklı özellikleri ve metotları farklı dosyalarda tanımlanabilir ve 
      daha düzenli bir kod yapısı elde edilir. Partial class kullanımı genellikle büyük projelerde 
      kodun okunabilirliğini ve yönetilebilirliğini artırmak amacıyla tercih edilir.

      Partial class tanımlanırken, sınıfın her parçasının aynı isim ve erişim belirleyicisi ile tanımlanması gerekir.
      */

      MyPartialClass myPartialClass = new MyPartialClass();
      myPartialClass.Method1();
      myPartialClass.Method2();
      // Burada MyPartialClass sınıfı, iki ayrı dosyada aynı isim ve erişim belirleyicisi ile tanımlanmıştır.
      // Bu sayede MyPartialClass sınıfına ait Method1() ve Method2() metotları, farklı dosyalarda implemente edilebilir.
      // Aynı sınıfın farklı özelliklerinin ya da metotlarının farklı dosyalarda implemente edilmesi,
      // kod yönetimi ve bakımı açısından kolaylık sağlar.
    }

    public class Dikdortgen_Nested
    {
      private int en;
      private int boy;

      public Dikdortgen_Nested(int e, int b)
      {
        en = e;
        boy = b;
      }

      public int AlanHesapla()
      {
        return en * boy;
      }

      public class Yuzey
      {
        public void YuzeyAlanHesapla(Dikdortgen_Nested d)
        {
          MessageBox.Show("Dikdörtgen yüzey alanı: " + (2 * (d.en + d.boy)));
        }
      }
    }
    private void button30_Click(object sender, EventArgs e)
    {
      /*
      Nested Class, bir sınıfın içindeki başka bir sınıfı ifade eder. 
      Nested Class, dıştaki sınıfın özelliklerine erişebilir ve bu sınıf dışında kullanılamaz. 
      Bu, kodun daha modüler ve anlaşılır hale getirilmesine yardımcı olabilir.

      C# ile Nested Class oluşturmak için, sınıfın içinde yeni bir sınıf tanımlamanız yeterlidir. 
      */

      Dikdortgen_Nested dikdortgen = new Dikdortgen_Nested(5, 15);
      Dikdortgen_Nested.Yuzey yuzey = new Dikdortgen_Nested.Yuzey();
      yuzey.YuzeyAlanHesapla(dikdortgen);
    }

    public class Araba_InnerType
    {
      public int ModelYili { get; set; }
      public string Marka { get; set; }
      public string Renk { get; set; }

      public class Motor
      {
        public int Hacim { get; set; }
        public int BeygirGucu { get; set; }
      }
    }
    private void button31_Click(object sender, EventArgs e)
    {
      /*
        Inner Type, bir sınıf içinde başka bir sınıfın tanımlanmasıdır. 
      İçerideki sınıf, dışardaki sınıfın bir öğesi olarak kabul edilir ve ona erişilebilir. 
      Inner Type modelleme, sınıf yapılarının daha anlamlı ve düzenli hale getirilmesine yardımcı olur.
      */

      Araba_InnerType arabam = new Araba_InnerType();
      arabam.ModelYili = 2021;
      arabam.Marka = "Mercedes";
      arabam.Renk = "Gri";

      Araba_InnerType.Motor motorum = new Araba_InnerType.Motor();
      motorum.Hacim = 2000;
      motorum.BeygirGucu = 250;

    }

    private void button32_Click(object sender, EventArgs e)
    {
      ///*
      //Ranges ve Indices, C# 8.0 ile birlikte tanıtılan ve koleksiyonlar üzerinde 
      //daha kolay erişim sağlamak için kullanılan bir özelliktir.

      //Ranges, bir koleksiyonun belirli bir alt veya üst aralığına erişmek için kullanılır. 
      //Örneğin, list[2..5] ifadesi, list koleksiyonunun 2. indeksinden başlayarak 5. indeksine 
      //kadar olan elemanları içeren bir alt kümesini döndürür.

      //Indices, koleksiyonların sonundan geriye doğru indeksleme yapmak için kullanılır. 
      //Örneğin, list[^1] ifadesi, list koleksiyonunun son elemanına erişmek için kullanılır.

      //Ranges ve Indices birlikte kullanılarak, koleksiyonların belirli bir aralığında ve 
      //son elemanına erişmek çok daha kolay hale gelir.
      //*/

      //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

      //// Using Ranges
      //var subset = numbers[2..5]; // Returns [2, 3, 4]

      //// Using Indices
      //var last = numbers[^1]; // Returns 9

      //// Using Ranges and Indices together
      //var subsetFromEnd = numbers[^5..^2]; // Returns [5, 6, 7]
    }

    public void GetPerson_OutVar(out string name, out int age)
    {
      name = "John";
      age = 30;
    }
    private void button27_Click(object sender, EventArgs e)
    {
      /*
      C# 7.0 sürümüyle birlikte eklenen "out var" ifadesi, bir değişkenin 
      değişken türünün belirtilmesine gerek kalmadan bir methoddan döndürülen değerlerin atamasını sağlar.

      "out var" ifadesi, "out" anahtar kelimesiyle birlikte kullanılır. "out" anahtar kelimesi, 
      bir methoddan birden fazla değer döndürmek için kullanılır. "out" anahtar kelimesiyle birlikte 
      "var" ifadesi kullanarak, döndürülen değerleri değişkenlere atamak için ayrı ayrı 
      değişken türleri belirtilmeden kullanılabilir.
      */

      GetPerson_OutVar(out var name, out var age);
      MessageBox.Show($"Name: {name}, Age: {age}"); // Output: Name: John, Age: 30
    }



    private void button28_Click(object sender, EventArgs e)
    {
      /*
       * Null Coalescing Operatörü ??
      C# ?? operatörü, null koalesans operatörü olarak da bilinir. 
      Bu operatör, null olabilen bir ifadeyi null olmadığından emin olmak için kullanılır.

      ?? operatörü, sol tarafındaki ifade null değilse sol tarafındaki değeri döndürür, 
      aksi takdirde sağ tarafındaki ifadeyi döndürür. 
      Bu, sıklıkla bir nesnenin null olup olmadığını kontrol etmek için kullanılır.
      */

      string name = null;
      string fullName = name ?? "Ali Baba";
      MessageBox.Show(fullName); // "Ali Baba"
      // Yukarıdaki örnekte, name değişkeni null olduğu için fullName değişkeni "Ali Baba" olarak atanır.

      int? num1 = null;
      int num2 = num1 ?? 0;
      MessageBox.Show(num2.ToString()); // 0
      // Yukarıdaki örnekte, num1 değişkeni null olduğu için num2 değişkeni 0 olarak atanır.
    }







  } // EOF
}
