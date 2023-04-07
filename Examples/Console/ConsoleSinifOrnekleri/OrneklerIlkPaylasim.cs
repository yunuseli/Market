using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSinifOrnekleri
{
  public class OrneklerIlkPaylasim
  {
    // Örnekler

    // Sayıları toplayalım
    //Console.Write("Sayı giriniz : ");
    //int sayi1 = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Sayı giriniz: ");
    //int sayi2 = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Sayı giriniz: ");
    //int sayi3 = Convert.ToInt32(Console.ReadLine());
    //int toplam = sayi1 + sayi2 + sayi3;
    //Console.Write("Girilen sayıların toplamaı = " + toplam.ToString());

    // Ortalama Bulma
    //Console.Write("Sayı giriniz : ");
    //int sayi1 = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Sayı giriniz : ");
    //int sayi2 = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Sayı giriniz : ");
    //int sayi3 = Convert.ToInt32(Console.ReadLine());
    //int toplam = sayi1 + sayi2 + sayi3;
    //float ortalama = toplam / 3.0f; // float, double ve decimal işlemlerinde tanımlanacak sabit sayıların yazılış şekillerine dikkat
    ////double ortalama = toplam / 3.0;
    ////decimal ortalama = toplam / 3.0m;
    //Console.Write("Girilen sayıların ortalaması = " + ortalama.ToString());

    // Yaş hesaplama
    //Console.Write("Doğum yılınız...");
    //int dogumyili = Convert.ToInt32(Console.ReadLine());
    //int buyil = 2023;
    ////int buyil = DateTime.Now.Year;
    //int yas = buyil - dogumyili;
    //Console.WriteLine("Yaşınız : " + yas.ToString());

    // Hangi tuşa basıldı
    //Console.Write("Bir tuşa basınız...");
    //char c = Console.ReadKey().KeyChar;
    //Console.WriteLine();
    //Console.WriteLine("Basılan Tuş : " + c);

    // Basılan tuş ve değiştirici kodu :: Örnek ctrl tuşuna basılı iken bir tuşa basın
    //Console.Write("Bir tuşa basınız...");
    //ConsoleKeyInfo info = Console.ReadKey();
    //Console.WriteLine();
    //Console.WriteLine("Tuş : " + info.Key.ToString());
    //Console.WriteLine("Karakter : " + info.KeyChar.ToString());
    //Console.WriteLine("Değiştirici : " + info.Modifiers.ToString());



    // Sayı Tek-çift
    //int sayi;
    //Console.WriteLine("Sayıyı giriniz..");
    //sayi = Convert.ToInt32(Console.ReadLine());
    //if (sayi % 2 == 0)
    //{
    //  Console.WriteLine("girilen sayı çifttir");
    //}
    //else
    //{
    //  Console.WriteLine("girilen sayı tektir");
    //}

    // Sayı negatif-pozitif-sıfır
    //Console.Write("Bir sayı giriniz=");
    //int sayi = int.Parse(Console.ReadLine());
    //if (sayi < 0)
    //  Console.Write("Girdiğiniz Sayı Negatif");
    //else if (sayi > 0)
    //  Console.Write("Girdiğiniz Sayı Pozitif");
    //else
    //  Console.Write("Girdiğiniz Sayı Sıfır");

    // büyük-küçük
    //int sayi1, sayi2;
    //sayi1 = Convert.ToInt32(Console.ReadLine());
    //sayi2 = Convert.ToInt32(Console.ReadLine());
    //if (sayi1 > sayi2)
    //{
    //  Console.WriteLine("1. Sayı Büyük");
    //}
    //else if (sayi2 > sayi1)
    //{
    //  Console.WriteLine("2. Sayı Büyük");
    //}
    //else
    //{
    //  Console.WriteLine("Sayılar Eşit");
    //}

    // birden fazla durumu karşılaştırma
    //Console.Write("Sayı giriniz=");
    //int sayi1 = int.Parse(Console.ReadLine());
    //Console.Write("Sayı giriniz=");
    //int sayi2 = int.Parse(Console.ReadLine());
    //if (sayi1 < sayi2 && sayi1 != 0 && sayi2 != 0)
    //  Console.Write("İlk girilen sayı daha küçük (" + sayi1 + "<" + sayi2 + ")");
    //else if (sayi2 < sayi1 && sayi1 != 0 && sayi2 != 0)
    //  Console.Write("İkinci girilen sayı daha küçük (" + sayi2 + "<" + sayi1 + ")");
    //else
    //  Console.Write("Girilen iki sayıda 0");

    // Basit bir menü - haftanın günü
    //Console.WriteLine("1-Pazartesi");
    //Console.WriteLine("2-Salı");
    //Console.WriteLine("3-Çarşamba");
    //Console.WriteLine("4-Perşembe");
    //Console.WriteLine("5-Cuma");
    //Console.WriteLine("6-Cumartesi");
    //Console.WriteLine("7-Pazar");
    //Console.Write("Seçim yapınız...");
    //char c = Console.ReadKey().KeyChar;
    //Console.WriteLine();
    //Console.WriteLine();
    //Console.WriteLine("Seçim = {0}", c);
    //if (c == '1')
    //  Console.WriteLine("Seçilen gün - Pazartesi");
    //else if (c == '2')
    //  Console.WriteLine("Seçilen gün - Salı");
    //else if (c == '3')
    //  Console.WriteLine("Seçilen gün - Çarşamba");
    //else if (c == '4')
    //  Console.WriteLine("Seçilen gün - Perşembe");
    //else if (c == '5')
    //  Console.WriteLine("Seçilen gün - Cuma");
    //else if (c == '6')
    //  Console.WriteLine("Seçilen gün - Cumartesi");
    //else if (c == '7')
    //  Console.WriteLine("Seçilen gün - Pazar");
    //else
    //  Console.WriteLine("Hatalı seçim");

    // Dört işlem
    //Console.WriteLine("Lütfen 1. sayıyı giriniz");
    //int sayi1 = Int32.Parse(Console.ReadLine());
    //Console.WriteLine("Lütfen 2. sayıyı giriniz");
    //int sayi2 = Int32.Parse(Console.ReadLine());
    //Console.WriteLine("Lütfen işlem türünü giriniz");
    //Console.WriteLine("toplama=1, çıkarma=2, çarpma=3, bölme=4");
    //int islem = Int32.Parse(Console.ReadLine());
    //switch (islem)
    //{
    //  case 1: Console.WriteLine(sayi1 + sayi2); break;
    //  case 2: Console.WriteLine(sayi1 - sayi2); break;
    //  case 3: Console.WriteLine(sayi1 * sayi2); break;
    //  case 4: Console.WriteLine((double)sayi1 / (double)sayi2); break;
    //  default: Console.WriteLine("Geçersi işlem"); break;
    //}

    // switch - birden fazla durum için tek işlem
    //switch (DateTime.Now.DayOfWeek)
    //{
    //  case DayOfWeek.Monday:
    //  case DayOfWeek.Tuesday:
    //  case DayOfWeek.Wednesday:
    //  case DayOfWeek.Thursday:
    //  case DayOfWeek.Friday:
    //    Console.WriteLine("Hafta içindeyiz çalışmaya devam...");
    //    break;
    //  case DayOfWeek.Saturday:
    //  case DayOfWeek.Sunday:
    //    Console.WriteLine("Hafta sonu dinlen, pazartesi iş bizi bekler...");
    //    break;
    //}

    // string birleştirme ve düzen işlemleri
    //for (int i = 1; i < 11; i++)
    //{
    //  Console.WriteLine("Fuat - " + i + " / " + (i + 12));
    //  Console.WriteLine(String.Format("Fuat - {0} / {1}", i, i + 12));
    //  Console.WriteLine($"Fuat - {i} / {i+12}");
    //}


    // 0-100 arası 1 rakamı içeren sayıların adedi - for
    //int sayac = 0;
    //for (int i = 1; i <= 100; i++)
    //{
    //  if (i.ToString().Contains("1"))
    //  { sayac++; }
    //}
    //Console.WriteLine("1 rakamı içeren sayıların adedi : " + sayac.ToString());


    // 0-100 arası tek sayıların toplamı  - while
    //int sayi = 0;
    //int toplam = 0;
    //while (sayi <= 100)
    //{
    //  if (sayi % 2 == 1)
    //    toplam += sayi;
    //  sayi++;
    //}
    //Console.WriteLine("Tek sayıların toplamı:" + toplam);

    // Alfabe - do while
    //char i = 'A';
    //do
    //{
    //  Console.Write(i);
    //  i++;
    //} while (i <= 'Z');
    //Console.WriteLine();

    // Sayı tahmin - for
    //for (int i = 0; i < 5; i++)
    //{
    //  Console.Write("Tahmininiz : ");
    //  int tahmin = int.Parse(Console.ReadLine());
    //  if (tahmin == rastgele)
    //  {
    //    Console.WriteLine($"Bildiniz : {rastgele}");
    //    break;
    //  }
    //  if (tahmin < rastgele)
    //    Console.WriteLine("Yukarı");
    //  else
    //    Console.WriteLine("Yukarı");
    //}


    // Sayı tahmin - while sonsuz döngü
    //Random rnd = new Random();
    //int rastgele = rnd.Next(0,10);
    //while (true)
    //{
    //  Console.Write("Tahmininiz : ");
    //  int tahmin = int.Parse(Console.ReadLine());
    //  if (tahmin == rastgele)
    //  {
    //    Console.WriteLine($"Bildiniz : {rastgele}");
    //    break;
    //  }
    //  if (tahmin < rastgele)
    //    Console.WriteLine("Yukarı");
    //  else
    //    Console.WriteLine("Yukarı");
    //}

    // Sayı  tahmin - kaç seferde
    //int i = 1;
    //Random rdn = new Random();
    //int rastgele = rdn.Next(0, 10);
    //while (true)
    //{
    //  Console.Write("Sayı Giriniz:");
    //  int sayi = Convert.ToInt32(Console.ReadLine());
    //  if (sayi == rastgele)
    //  {
    //    break;
    //  }
    //  i++;
    //}
    //Console.WriteLine(i + ". tahmininizde sayıyı buldunuz.");


    // sonsuz döngü for
    //Console.Write("Tahmin giriniz : ");
    //for (; ; )
    //{
    //  int sayi = int.Parse(Console.ReadLine());
    //  if (sayi == 5)
    //  {
    //    Console.WriteLine("Bildiniz : 5");
    //    break;
    //  }
    //  Console.Write("Bilemediniz, yeni tahmin giriniz : ");
    //}

    // indirim hesapla - güne göre
    //Console.WriteLine("Haftanın kaçıncı günündesiniz?");
    //int gun = int.Parse(Console.ReadLine());
    //Console.WriteLine("Alışveriş Tutarı Giriniz:");
    //double tutar = double.Parse(Console.ReadLine());
    //switch (gun)
    //{
    //  case 1:
    //    if (tutar > 99)
    //      Console.WriteLine("Tebrikler!!! Pazartesi indiriminden yararlandınız. Ödeyeceğiniz tutar: " + (tutar - (tutar * 0.1)) + "TL");
    //    else
    //      Console.WriteLine("Ödeyeceğiniz tutar: " + tutar + "TL");
    //    break;
    //  case 2:
    //    if (tutar > 199)
    //      Console.WriteLine("Tebrikler!!! Salı indiriminden yararlandınız. Ödeyeceğiniz tutar: " + (tutar - (tutar * 0.15)) + "TL");
    //    else
    //      Console.WriteLine("Ödeyeceğiniz tutar: " + tutar + "TL");
    //    break;
    //  case 3:
    //  case 4:
    //  case 5:
    //    Console.WriteLine("Ödeyeceğiniz tutar: " + tutar + "TL");
    //    break;
    //  case 6:
    //  case 7:
    //    if (tutar > 299)
    //      Console.WriteLine("Tebrikler!!! Haftasonu indiriminden yararlandınız. Ödeyeceğiniz tutar: " + (tutar - (tutar * 0.20)) + "TL");
    //    else
    //      Console.WriteLine("Ödeyeceğiniz tutar: " + tutar + "TL");
    //    break;
    //  default:
    //    Console.WriteLine("!! Hata, yanlış gün");
    //    break;
    //}

    // İlkokul not ortalaması *********************************************************************************************************************

    //// İlkokul ortalama hesaplama programı,
    //// girilen 3 notun ortalamasını ve 5 lik sistemdeki karşılığını yazar

    //int not1 = 0, not2 = 0, not3 = 0;

    //Not1:
    //Console.Write("Birinci notu giriniz : ");
    //if (!int.TryParse(Console.ReadLine(), out not1))
    //{
    //  Console.WriteLine("! Giriş tam sayı değil\n");
    //  goto Not1;
    //}
    //if (not1 > 100 || not1 < 0)
    //{
    //  Console.WriteLine("! Not 0 ile 100 arasında olmalı\n");
    //  goto Not1;
    //}

    //Not2:
    //Console.Write("İkinci notu giriniz : ");
    //if (!int.TryParse(Console.ReadLine(), out not2))
    //{
    //  Console.WriteLine("! Giriş tam sayı değil\n");
    //  goto Not2;
    //}
    //if (not2 > 100 || not2 < 0)
    //{
    //  Console.WriteLine("! Not 0 ile 100 arasında olmalı\n");
    //  goto Not2;
    //}

    //Not3:
    //Console.Write("Üçüncü notu giriniz : ");
    //if (!int.TryParse(Console.ReadLine(), out not3))
    //{
    //  Console.WriteLine("! Giriş tam sayı değil\n");
    //  goto Not3;
    //}
    //if (not3 > 100 || not3 < 0)
    //{
    //  Console.WriteLine("! Not 0 ile 100 arasında olmalı\n");
    //  goto Not3;
    //}

    //int ortalama = (not1 + not2 + not3) / 3;
    //Console.WriteLine("Ortalama = " + ortalama);
    ////Console.WriteLine(String.Fotmat("Ortalama = " {0},ortalama));
    ////Console.WriteLine($"Ortalama = {ortalama}");

    //if (ortalama < 44) Console.WriteLine("Sonuç    = Başarısız");
    //else if (ortalama < 54) Console.WriteLine("Sonuç    = Geçer");
    //else if (ortalama < 69) Console.WriteLine("Sonuç    = Orta");
    //else if (ortalama < 84) Console.WriteLine("Sonuç    = İyi");
    //else Console.WriteLine("Sonuç    = Pekiyi");

    // İlkokul not ortalaması *********************************************************************************************************************

    // Genişliği ve yüksekliği kullanıcı tarafından verilen dikdörtgen oluşturma
    //Console.Write("Yüksekliği Girin : ");
    //int yukseklik = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Genişliği Girin : ");
    //int genislik = Convert.ToInt32(Console.ReadLine());
    //for (int i = 1; i <= yukseklik; i++)
    //{
    //  for (int j = 1; j <= genislik; j++)
    //  {
    //    if (i == 1 || i == yukseklik)
    //      Console.Write("*");
    //    else
    //        if (j == 1 || j == genislik)
    //      Console.Write("*");
    //    else
    //      Console.Write(" ");
    //  }
    //  Console.WriteLine();
    //}
    //Console.WriteLine();


    // cümledeki kelime sayısı
    //string cumle = "";
    //int sayackelime = 0;
    //bool oncekiharfbosluk = false;
    //Console.Write("Cümle giriniz giriniz : ");
    //cumle = Console.ReadLine().Trim();
    //for (int i = 1; i < cumle.Length; i++)
    //{
    //  if (cumle[i].ToString() == " " && !oncekiharfbosluk)
    //  {
    //    sayackelime++;
    //    oncekiharfbosluk = true;
    //  }
    //  else if (cumle[i].ToString() != " ")
    //  {
    //    oncekiharfbosluk = false;
    //  }
    //}
    //Console.WriteLine("Cümledeki kelime sayısı : " + (++sayackelime).ToString());


    // Klavyeden girilen bir metnin içindeki sesli ve sessiz harflerin sayısı
    //string cumle;
    //int seslisayac = 0;
    //int sessizsayac = 0;
    //Console.Write("Metni Giriniz:");
    //cumle = Convert.ToString(Console.ReadLine());
    //char[] sesliler = { 'a', 'e', 'i', 'o', 'u' };
    //for (int x = 0; x < cumle.Length; x++)
    //{
    //  for (int i = 0; i < sesliler.Length; i++)
    //  {
    //    if (cumle[x] == sesliler[i])
    //    {
    //      seslisayac++;
    //    }
    //  }
    //}
    //sessizsayac = cumle.Length - seslisayac;
    //Console.WriteLine("sesli harfler:" + seslisayac.ToString());
    //Console.WriteLine("sessiz harfler:" + sessizsayac.ToString());
    //Console.ReadKey();
  }
}
