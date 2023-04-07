using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSinifOrnekleri
{
  public class OrneklerPaylasim2
  {
    // Örnekler 2

    //*************************************** Kare - Küp - Kök Bulma ***************************************
    /*
        Bu örnekte bir sayı girişi ve işlem seçimi istiyoruz
        Sayı ve işlem girişinde hatayı önlemek için TryParse metodunu kullandık
        Hatalı girişlerde tekrar giriş istemek için goto atlatma deyimi ile etiketlenen noktaya dönüş sağladık
        Hesaplamaları yapmak için Math kütüphanesinden yararlandık
     */
    // SayiGiris:
    //Console.WriteLine("Sayı giriniz:");
    //int sayi = 0;
    //if (int.TryParse(Console.ReadLine(), out sayi) == false)
    //{
    //  Console.WriteLine("Hatalı sayı");
    //  goto SayiGiris;
    //}

    //islemgiris:
    //Console.WriteLine("İşlem : 1-Karesi 2-Küpü 3-Kökü");
    //int islem = 0;
    //if (int.TryParse(Console.ReadLine(), out islem) == false)
    //{
    //  Console.WriteLine("Hatalı işlem");
    //  goto islemgiris;
    //}

    //switch (islem)
    //{
    //  case 1:
    //    Console.WriteLine("Karesi = " + Math.Pow(sayi, 2));
    //    break;
    //  case 2:
    //    Console.WriteLine($"Küpü = {Math.Pow(sayi, 3)}");
    //    break;
    //  case 3:
    //    Console.WriteLine($"KareKökü = \n{Math.Sqrt(sayi)}");
    //    break;
    //  default:
    //    Console.WriteLine("hatalı işlem");
    //    goto islemgiris;
    //}
    //*************************************** Kare - Küp - Kök Bulma ***************************************


    //*************************************** operatör kullanımı (++ --) ***************************************
    /*
        Bu örnekte arttırma eksiltme operatörlerinin farklı kullanımlarını görmekteyiz
        ++x önden arttırma / x++ sonradan arttırma
     */
    //int a = 0; int b = 0;
    //Console.WriteLine($"a işlem değeri {a++}");
    //Console.WriteLine($"b işlem değeri {++b}");
    //Console.WriteLine($"a son değeri {a}");
    //Console.WriteLine($"b son değeri {b}");

    //int x = 0; int y = 0; 
    //Console.WriteLine($"x işlem değeri {x--}");
    //Console.WriteLine($"y işlem değeri {--y}");
    //Console.WriteLine($"x son değeri {x}");
    //Console.WriteLine($"y son değeri {y}");
    //*************************************** operatör kullanımı (++ --) ***************************************

    //*************************************** koşul içinde birden çok işlem ***************************************
    /*
        Bu örnekte while satırı aynı koşul içinde atama, arttırma, karşılaştırma gibi birden çok işlemin
        aynı anda kullanımı görülmektedir
     */
    //int sayibak = 0;
    //int sayac = 0;
    //while ((sayibak = ++sayac) < 10)
    //  if (sayibak > 7) break;
    //Console.WriteLine($"sayi değeri {sayibak}");
    //*************************************** koşul içinde birden çok işlem ***************************************

    //*************************************** string biçimlendirme ***************************************
    /*
        Bu örnekte (ilk 7 satır) farklı yöntemlerle string biçimlendirme işlemleri görülmektedir
        alt kısımda ise microsoft kaynağıda verilen detaylı biçimlendirme örnekleri var.
     */
    //int a = 5, b = 6;
    //string s1 = "{a=" + a + " b=" + b + "}\n\"Kareleri : a2=" + Math.Pow(a, 2) + " b2=" + Math.Pow(b, 2) + "\"";
    //Console.WriteLine(s1);
    //string s2 = String.Format("{{a={0} b={1}}}\n\"Kareleri : a2={2} b2={3}\"", a, b, a, b);
    //Console.WriteLine(s2);
    //string s3 = $"{{a={a} b={b}}}\n\"Kareleri : a2={Math.Pow(a, 2)} b2={Math.Pow(b, 2)}";
    //Console.WriteLine(s3);



    //string s = String.Format("It is now {0:d} at {0:t}", DateTime.Now);
    //Console.WriteLine(s);

    //decimal value2 = 16309.5436m;
    //string result = String.Format("{0,12:#.00000} {0,12:0,000.00} {0,12:000.00#}", value2);
    //Console.WriteLine(result);

    ////https://learn.microsoft.com/en-us/dotnet/api/system.string.format?view=net-7.0
    //*************************************** string biçimlendirme ***************************************

    //*************************************** ConsoleKeyInfo ***************************************
    /*
        Bu örnekte ConsoleKeyInfo sınıfı kullanılarak klavyeden basılan tuşların 
        hangi tuş, hangi karakter, basıldı ise değiştirici tuş bilgileri alınması görülmektedir.
     */
    //while (true)
    //{
    //  Console.Write("Bir tuşa basınız (ENTER ile sonlandırabilirsiniz)...");
    //  ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
    //  if (consoleKeyInfo.Key == ConsoleKey.Enter)
    //  {
    //    Console.WriteLine("Programı sonlandırdınız...");
    //    break;
    //    //Environment.Exit(0);
    //  }
    //  Console.WriteLine();
    //  Console.WriteLine("Tuş: " + consoleKeyInfo.Key.ToString());
    //  Console.WriteLine("Karakter: " + consoleKeyInfo.KeyChar.ToString());
    //  Console.WriteLine("Ascii Karşılığı: " + Convert.ToInt32(consoleKeyInfo.KeyChar));
    //  Console.WriteLine("Değiştirici: " + consoleKeyInfo.Modifiers.ToString());
    //  Console.WriteLine();
    //}
    //*************************************** ConsoleKeyInfo ***************************************

    //*************************************** Math sınıfı örnek2 ***************************************
    /*
        Bu örnekte math sınıfı üzerine hata almadan çalışma sağlayacak farklı bir program
        if blokları içindeki kapalı satırlarda Math sınıfı kullanılmasaydı hesaplama nasıl yapılabilirdi
        örnekleri de var.
     */
    //int sayi, secim;

    //SayiGiris:

    //Console.Write("Bir sayı giriniz=");
    //if (int.TryParse(Console.ReadLine(), out sayi) == false)
    //{
    //  Console.WriteLine("! Giriş sayı değil");
    //  Console.WriteLine();
    //  goto SayiGiris;
    //}

    //IslemSecim:

    //Console.WriteLine("İşlemler : 1-Kare 2-Küp 3-KareKök");
    //Console.Write("Seçiminiz : ");
    //if (int.TryParse(Console.ReadLine(), out secim) == false)
    //{
    //  Console.WriteLine("! Hatalı seçim yaptınız");
    //  Console.WriteLine();
    //  goto IslemSecim;
    //}

    //if (secim == 1)
    //{
    //  //double kare = sayi * sayi;
    //  double kare = Math.Pow(sayi, 2);
    //  Console.WriteLine("Girdiğiniz sayının karesi= {0}", kare);
    //}
    //else if (secim == 2)
    //{
    //  //double kup = sayi * sayi * sayi;
    //  double kup = Math.Pow(sayi, 3);
    //  Console.WriteLine("Girdiğiniz sayının kübü= {0}", kup);
    //}
    //else if (secim == 3)
    //{
    //  ////The Babylonian Method for Computing Square Roots
    //  //double kok = sayi;
    //  //double y = 1;
    //  //while (kok > y)
    //  //{
    //  //  kok = (kok + y) / 2;
    //  //  y = sayi / kok;
    //  //}
    //  double kok = Math.Sqrt(sayi);
    //  Console.WriteLine("Girdiğiniz sayının kökü= {0}", kok);
    //}
    //else
    //{
    //  Console.WriteLine("! Hatalı seçim yaptınız");
    //  Console.WriteLine();
    //  goto IslemSecim;
    //}

    //Console.WriteLine();
    //Console.Write("Tekrar için ENTER tuşuna, çıkış için herhangi bir tuşa basınız");
    //if (Console.ReadKey().Key == ConsoleKey.Enter)
    //{
    //  Console.Clear();
    //  goto SayiGiris;
    //}
    //else
    //{
    //  Environment.Exit(0); // bu satır programı akışa bakmaksızın sonlandırır, döngüden çıkış deyimi benzeri, programdan çıkar
    //}
    //*************************************** Math sınıfı örnek2 ***************************************

    //*************************************** Girilen İki Sayı Arasındaki Sayıları Ekrana Yazdır ***************************************
    //Console.Write("Başlangıç Değerini Giriniz : ");
    //int baslangic = int.Parse(Console.ReadLine());
    //Console.Write("Bitiş Değerini Giriniz : ");
    //int bitis = int.Parse(Console.ReadLine());
    //for (int i = baslangic; i < bitis; i++)
    //{
    //  Console.WriteLine(i + " ");
    //}
    //Console.ReadKey();
    //*************************************** Girilen İki Sayı Arasındaki Sayıları Ekrana Yazdır ***************************************

    //*************************************** Ternary Operator ?: --- üçüncül koşullu işleç ***************************************
    /*
        Bu örnekte Ternary Operator ve aşağıda aynı işlemi yapan bir if yapısı görülmektedir
     */
    ////is this condition true ? yes : no
    //int test = a > 5 ? 3 : 6;
    //Console.WriteLine($"test değeri {test}");
    //if (a > 5)
    //{
    //  test = 3;
    //}
    //else
    //{
    //  test = 6;
    //}
    //Console.WriteLine($"test değeri {test}");
    //*************************************** Ternary Operator ?: --- üçüncül koşullu işleç ***************************************

    //*************************************** sayilardan en büyük ve en küçüğü bulma ***************************************
    //int girilensayi, enKucuk = int.MaxValue, enBuyuk = int.MinValue, sayac1 = 0, dongu = 5;
    //while (sayac1++ < dongu)
    //{
    //  Console.Write($"{sayac1}. sayıyı girin: ");
    //  girilensayi = Convert.ToInt32(Console.ReadLine());

    //  if (girilensayi > enBuyuk)
    //    enBuyuk = girilensayi;

    //  if (girilensayi < enKucuk)
    //    enKucuk = girilensayi;

    //  //enBuyuk = girilensayi > enBuyuk ? girilensayi : enBuyuk;
    //  //enKucuk = girilensayi < enKucuk ? girilensayi : enKucuk;
    //}
    //Console.WriteLine($"Girilen en küçük sayı={enKucuk}");
    //Console.WriteLine($"Girilen en büyük sayı={enBuyuk}");
    //Console.ReadKey();
    //*************************************** sayilardan en büyük ve en küçüğü bulma ***************************************

    //*************************************** girilen aralıktaki asal sayılar ***************************************
    //int kontrolSayi, asalSayac =0;
    //Console.Write($"Asal sayı bulma, hangi sayıya kadar bakılacak ? ");
    //int donguSonu = Convert.ToInt32(Console.ReadLine());
    //Console.Write($"Girilen aralıktaki 0-{donguSonu} asal sayılar : ");
    //for (int i = 2; i <= donguSonu; i++)
    //{
    //  bool asaldegil = false;
    //  for (int j = 2; j < i - 1; j++)
    //  {
    //    if (i % j == 0)
    //    {
    //      asaldegil = true;
    //      break;
    //    }
    //  }

    //  if (!asaldegil)
    //  {
    //    Console.Write($"{i} ");
    //    asalSayac++;
    //  }

    //}
    //Console.WriteLine();
    //Console.WriteLine($"Girilen aralıktaki asal sayıların miktarı {asalSayac}");
    //*************************************** girilen aralıktaki asal sayılar ***************************************

    //*************************************** Fibonacci sayılar ***************************************
    //int x = 0;
    //int y = 1;
    //int sayi;
    //Console.Write("Fibonacci Dizisi Kaç Elemanlı Olsun = ");
    //sayi = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("--------------------------------------------------------");
    //Console.Write("0 1 ");
    //for (int i = 3; i <= sayi; i++)
    //{
    //  int z = x + y;
    //  Console.Write($"{z} ");
    //  x = y;
    //  y = z;
    //}
    //Console.WriteLine();
    //*************************************** Fibonacci sayılar ***************************************



    //*************************************** DateTime ***************************************
    //DateTime baslamaZamani = DateTime.Now;
    //DateTime zaman = new DateTime(2023, 1, 1, 0, 0, 0);
    //Console.WriteLine(zaman - baslamaZamani);

    //TimeSpan ts = zaman - baslamaZamani;
    //Console.WriteLine(ts.TotalDays);
    //Console.WriteLine(ts.Days);



    //Console.Write("Doğum yılınız...");
    //int dogumyili = Convert.ToInt32(Console.ReadLine());
    //DateTime suan = DateTime.Now;
    //int buyil = suan.Year;
    //int yas = buyil - dogumyili;
    //Console.WriteLine($"Yaşınız : {yas} yıl");



    //DateTime bitisZamani = DateTime.Now;
    //Console.WriteLine(baslamaZamani);
    //Console.WriteLine(bitisZamani);
    //Console.WriteLine((bitisZamani - baslamaZamani));
    //Console.WriteLine((bitisZamani - baslamaZamani).Seconds);


    //bitisZamani = bitisZamani.AddDays(35).AddMinutes(-2).AddSeconds(5);
    //Console.WriteLine(bitisZamani);

    //DateTime zamnnn = Convert.ToDateTime("01.01.2023 08:00:00");
    //Console.WriteLine(zamnnn);

    //DateTime z = new DateTime(2023, 1, 1, 0, 0, 0);
    //Console.WriteLine(z);


    ////yaş hesaplama - gün-ay-yıl
    //DogumTarihi:
    //Console.Write("Doğum tarihiniz (gün.ay.yıl şeklinde giriniz)...");
    //DateTime dogumTarihi;
    //if (DateTime.TryParse(Console.ReadLine(), out dogumTarihi) == false)
    //{
    //  Console.WriteLine("! Hatalı giriş");
    //  goto DogumTarihi;
    //}
    //if (dogumTarihi >= DateTime.Now)
    //{
    //  Console.WriteLine("! Doğum tarihi bu gün veya sonrası olamaz");
    //  goto DogumTarihi;
    //}
    //if (dogumTarihi >= DateTime.Now.AddDays(-365))
    //{
    //  Console.WriteLine("! Bu yaşta bu zeka, :) büyüksün");
    //}

    //DateTime suAnkiZaman = DateTime.Now;
    //TimeSpan fark = suAnkiZaman - dogumTarihi;
    //Console.WriteLine($"Yaşadığınız gün : {fark.Days}");

    //int yasYil = suAnkiZaman.Year - dogumTarihi.Year;
    //if (dogumTarihi.Month > suAnkiZaman.Month || (suAnkiZaman.Month == dogumTarihi.Month && dogumTarihi.Day > suAnkiZaman.Day))
    //  yasYil--;

    //int yasAy = suAnkiZaman.Month - dogumTarihi.Month;
    //if (yasAy < 0)
    //  yasAy = 12 + yasAy;

    //int yasGun = suAnkiZaman.Day - dogumTarihi.Day;
    //if (yasGun < 0)
    //{
    //  DateTime newNow = suAnkiZaman.AddMonths(-1);
    //  yasGun += (int)(suAnkiZaman - newNow).TotalDays;
    //}

    //Console.WriteLine($"Yaşınız : {yasYil} yıl {yasAy} ay {yasGun} gün");

    //Console.WriteLine($"Bir sonraki doğum gününüz : {new DateTime(suAnkiZaman.AddYears(1).Year, dogumTarihi.Month, dogumTarihi.Day).ToShortDateString()}");

    //Console.WriteLine();
    //Console.Write("Tekrar için ENTER tuşuna, çıkış için herhangi bir tuşa basınız");
    //if (Console.ReadKey().Key == ConsoleKey.Enter)
    //{
    //  Console.Clear();
    //  goto DogumTarihi;
    //}

    //*************************************** DateTime ***************************************







    //*************************************** Süper Loto Tahmin ***************************************
    /*
        5 farklı teknikle tahmin sonuçları
     */

    //Basla:

    //DateTime basla, bitis;

    //// Rastgele bulma
    //int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6;
    //Random rnd = new Random();

    //// tek if
    //basla = DateTime.Now;
    //TekIf:
    //sayi1 = rnd.Next(1, 60);
    //sayi2 = rnd.Next(1, 60);
    //sayi3 = rnd.Next(1, 60);
    //sayi4 = rnd.Next(1, 60);
    //sayi5 = rnd.Next(1, 60);
    //sayi6 = rnd.Next(1, 60);
    //if (sayi1 == sayi2 || sayi1 == sayi3 || sayi1 == sayi4 || sayi1 == sayi5 || sayi1 == sayi6 ||
    //    sayi2 == sayi3 || sayi2 == sayi4 || sayi2 == sayi5 || sayi2 == sayi6 ||
    //    sayi3 == sayi4 || sayi3 == sayi5 || sayi3 == sayi6 ||
    //    sayi4 == sayi5 || sayi4 == sayi6 || sayi5 == sayi6)
    //{
    //  goto TekIf;
    //}
    //Console.WriteLine($"Çıkan sayılar 1  : {sayi1} {sayi2} {sayi3} {sayi4} {sayi5} {sayi6}");

    //// if - goto
    //sayi1 = 0; sayi2 = 0; sayi3 = 0; sayi4 = 0; sayi5 = 0; sayi6 = 0;
    //sayi1 = rnd.Next(1, 60);
    //Sse2:
    //sayi2 = rnd.Next(1, 60);
    //if (sayi2 == sayi1)
    //  goto Sse2;
    //Sse3:
    //sayi3 = rnd.Next(1, 60);
    //if (sayi3 == sayi2 || sayi3 == sayi1)
    //  goto Sse3;
    //Sse4:
    //sayi4 = rnd.Next(1, 60);
    //if (sayi4 == sayi3 || sayi4 == sayi2 || sayi4 == sayi1)
    //  goto Sse4;
    //Sse5:
    //sayi5 = rnd.Next(1, 60);
    //if (sayi5 == sayi4 || sayi5 == sayi3 || sayi5 == sayi2 || sayi5 == sayi1)
    //  goto Sse5;
    //Sse6:
    //sayi6 = rnd.Next(1, 60);
    //if (sayi6 == sayi5 || sayi6 == sayi4 || sayi6 == sayi3 || sayi6 == sayi2 || sayi6 == sayi1)
    //  goto Sse6;
    //Console.WriteLine($"Çıkan sayılar 2  : {sayi1} {sayi2} {sayi3} {sayi4} {sayi5} {sayi6}");
    ////if (sayi1 == sayi2 || sayi1 == sayi3 || sayi1 == sayi4 || sayi1 == sayi5 || sayi1 == sayi6 ||
    ////    sayi2 == sayi3 || sayi2 == sayi4 || sayi2 == sayi5 || sayi2 == sayi6 ||
    ////    sayi3 == sayi4 || sayi3 == sayi5 || sayi3 == sayi6 ||
    ////    sayi4 == sayi5 || sayi4 == sayi6 || sayi5 == sayi6)
    ////{
    ////  Console.WriteLine("!!! aynı sayı var !!!");
    ////  Console.ReadLine();
    ////}


    //// do while
    //sayi1 = 0; sayi2 = 0; sayi3 = 0; sayi4 = 0; sayi5 = 0; sayi6 = 0;
    //for (int i = 1; i <= 6; i++)
    //  switch (i)
    //  {
    //    case 1: sayi1 = rnd.Next(1, 60); break;
    //    case 2: do sayi2 = rnd.Next(1, 60); while (sayi2 == sayi1); break;
    //    case 3: do sayi3 = rnd.Next(1, 60); while (sayi3 == sayi1 || sayi3 == sayi2); break;
    //    case 4: do sayi4 = rnd.Next(1, 60); while (sayi4 == sayi1 || sayi4 == sayi2 || sayi4 == sayi3); break;
    //    case 5: do sayi5 = rnd.Next(1, 60); while (sayi5 == sayi1 || sayi5 == sayi2 || sayi5 == sayi3 || sayi5 == sayi4); break;
    //    case 6: do sayi6 = rnd.Next(1, 60); while (sayi6 == sayi1 || sayi6 == sayi2 || sayi6 == sayi3 || sayi6 == sayi4 || sayi6 == sayi5); break;
    //  }
    //Console.WriteLine($"Çıkan sayılar 3  : {sayi1} {sayi2} {sayi3} {sayi4} {sayi5} {sayi6}");


    //// while (atama + karşılaştırma)
    //sayi1 = 0; sayi2 = 0; sayi3 = 0; sayi4 = 0; sayi5 = 0; sayi6 = 0;
    //for (int i = 1; i <= 6; i++)
    //  switch (i)
    //  {
    //    case 1: sayi1 = rnd.Next(1, 60); break;
    //    case 2: while ((sayi2 = rnd.Next(1, 60)) == sayi1) ; break;
    //    case 3: while ((sayi3 = rnd.Next(1, 60)) == sayi1 || sayi3 == sayi2) ; break;
    //    case 4: while ((sayi4 = rnd.Next(1, 60)) == sayi1 || sayi4 == sayi2 || sayi4 == sayi3) ; break;
    //    case 5: while ((sayi5 = rnd.Next(1, 60)) == sayi1 || sayi5 == sayi2 || sayi5 == sayi3 || sayi5 == sayi4) ; break;
    //    case 6: while ((sayi6 = rnd.Next(1, 60)) == sayi1 || sayi6 == sayi2 || sayi6 == sayi3 || sayi6 == sayi4 || sayi6 == sayi5) ; break;
    //  }
    //Console.WriteLine($"Çıkan sayılar 4  : {sayi1} {sayi2} {sayi3} {sayi4} {sayi5} {sayi6}");


    //int gs = 0; // geçici sayı - while 
    //sayi1 = 0; sayi2 = 0; sayi3 = 0; sayi4 = 0; sayi5 = 0; sayi6 = 0;
    //for (int i = 1; i <= 6; i++)
    //{
    //  while ((gs = rnd.Next(1, 60)) == sayi1 || gs == sayi2 || gs == sayi3 || gs == sayi4 || gs == sayi5 || gs == sayi6) ;
    //  switch (i)
    //  {
    //    case 1: sayi1 = gs; break;
    //    case 2: sayi2 = gs; break;
    //    case 3: sayi3 = gs; break;
    //    case 4: sayi4 = gs; break;
    //    case 5: sayi5 = gs; break;
    //    case 6: sayi6 = gs; break;
    //  }
    //}
    //Console.WriteLine($"Çıkan sayılar 5  : {sayi1} {sayi2} {sayi3} {sayi4} {sayi5} {sayi6}");


    //// Bulunanları sıralama
    //int gecicisayi1 = 0, gecicisayi2 = 0, gecicisayi3 = 0, gecicisayi4 = 0, gecicisayi5 = 0, gecicisayi6 = 0, bakilansayi = 0;
    //for (int i = 1; i <= 6; i++)
    //{
    //  int min = 60;
    //  if (sayi1 < min && sayi1 > bakilansayi) min = sayi1;
    //  if (sayi2 < min && sayi2 > bakilansayi) min = sayi2;
    //  if (sayi3 < min && sayi3 > bakilansayi) min = sayi3;
    //  if (sayi4 < min && sayi4 > bakilansayi) min = sayi4;
    //  if (sayi5 < min && sayi5 > bakilansayi) min = sayi5;
    //  if (sayi6 < min && sayi6 > bakilansayi) min = sayi6;
    //  switch (i)
    //  {
    //    case 1: gecicisayi1 = bakilansayi = min; break;
    //    case 2: gecicisayi2 = bakilansayi = min; break;
    //    case 3: gecicisayi3 = bakilansayi = min; break;
    //    case 4: gecicisayi4 = bakilansayi = min; break;
    //    case 5: gecicisayi5 = bakilansayi = min; break;
    //    case 6: gecicisayi6 = bakilansayi = min; break;
    //  }
    //}
    //Console.WriteLine($"Sayılar 5 sıralı : {gecicisayi1} {gecicisayi2} {gecicisayi3} {gecicisayi4} {gecicisayi5} {gecicisayi6}");


    //Console.WriteLine();
    //Console.Write("Tekrar için ENTER tuşuna, çıkış için herhangi bir tuşa basınız");
    //if (Console.ReadKey().Key == ConsoleKey.Enter)
    //{
    //  //Console.Clear();
    //  Console.WriteLine();
    //  goto Basla;
    //}


    //*************************************** Süper Loto Tahmin ***************************************



    //*************************************** İlkokul ortalama hesaplama programı ***************************************
    // girilen 3 notun ortalamasını ve 5 lik sistemdeki karşılığını yazar

    //float not1 = 0, not2 = 0, not3 = 0;

    //Not1:
    //Console.Write("Birinci notu giriniz : ");
    //if (!float.TryParse(Console.ReadLine(), out not1))
    //{
    //  Console.WriteLine("! Giriş sayı değil\n");
    //  goto Not1;
    //}
    //if (not1 > 100 || not1 < 0)
    //{
    //  Console.WriteLine("! Not 0 ile 100 arasında olmalı\n");
    //  goto Not1;
    //}

    //Not2:
    //Console.Write("İkinci notu giriniz  : ");
    //if (!float.TryParse(Console.ReadLine(), out not2))
    //{
    //  Console.WriteLine("! Giriş sayı değil\n");
    //  goto Not2;
    //}
    //if (not2 > 100 || not2 < 0)
    //{
    //  Console.WriteLine("! Not 0 ile 100 arasında olmalı\n");
    //  goto Not2;
    //}

    //Not3:
    //Console.Write("Üçüncü notu giriniz  : ");
    //if (!float.TryParse(Console.ReadLine(), out not3))
    //{
    //  Console.WriteLine("! Giriş sayı değil\n");
    //  goto Not3;
    //}
    //if (not3 > 100 || not3 < 0)
    //{
    //  Console.WriteLine("! Not 0 ile 100 arasında olmalı\n");
    //  goto Not3;
    //}

    //float ortalama = (not1 + not2 + not3) / 3;
    ////Console.WriteLine("Ortalama = " + ortalama.ToString("G"));
    //Console.WriteLine("Ortalama = " + Convert.ToInt32(ortalama));

    //if (ortalama < 44) Console.WriteLine("Sonuç    = Başarısız");
    //else if (ortalama < 54) Console.WriteLine("Sonuç    = Geçer");
    //else if (ortalama < 69) Console.WriteLine("Sonuç    = Orta");
    //else if (ortalama < 84) Console.WriteLine("Sonuç    = İyi");
    //else Console.WriteLine("Sonuç    = Pekiyi");
    //*************************************** İlkokul ortalama hesaplama programı ***************************************


  }
}
