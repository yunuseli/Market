//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleSinifOrnekleri
//{
//  internal class Ornekyeni
//  {
//    public Ornekyeni()
//    {

//      // if - goto
//      sayi1 = rnd.Next(1, 60);
//    Sse2:
//      sayi2 = rnd.Next(1, 60);
//      if (sayi2 == sayi1)
//        goto Sse2;
//      Sse3:
//      sayi3 = rnd.Next(1, 60);
//      if (sayi3 == sayi2 && sayi3 == sayi1)
//        goto Sse3;
//      Sse4:
//      sayi4 = rnd.Next(1, 60);
//      if (sayi4 == sayi3 && sayi4 == sayi2 && sayi4 == sayi1)
//        goto Sse4;
//      Sse5:
//      sayi5 = rnd.Next(1, 60);
//      if (sayi5 == sayi4 && sayi5 == sayi3 && sayi5 == sayi2 && sayi5 == sayi1)
//        goto Sse5;
//      Sse6:
//      sayi6 = rnd.Next(1, 60);
//      if (sayi6 == sayi5 && sayi6 == sayi4 && sayi6 == sayi3 && sayi6 == sayi2 && sayi6 == sayi1)
//        goto Sse6;
//      Console.WriteLine($"Çıkan sayılar  : {sayi1} {sayi2} {sayi3} {sayi4} {sayi5} {sayi6}");
//      if (sayi1 == sayi2 || sayi1 == sayi3 || sayi1 == sayi4 || sayi1 == sayi5 || sayi1 == sayi6 ||
//          sayi2 == sayi3 || sayi2 == sayi4 || sayi2 == sayi5 || sayi2 == sayi6 ||
//          sayi3 == sayi4 || sayi3 == sayi5 || sayi3 == sayi6 ||
//          sayi4 == sayi5 || sayi4 == sayi6 || sayi5 == sayi6)
//      {
//        Console.WriteLine("!!! aynı sayı var !!!");
//        Console.ReadLine();
//      }



//    Basla:

//      // Rastgele bulma
//      int sayi1 = 0, sayi2 = 0, sayi3 = 0, sayi4 = 0, sayi5 = 0, sayi6 = 0;
//      Random rnd = new Random();

//      // do while
//      for (int i = 1; i <= 6; i++)
//        switch (i)
//        {
//          case 1: sayi1 = rnd.Next(1, 60); break;
//          case 2: do sayi2 = rnd.Next(1, 60); while (sayi2 == sayi1); break;
//          case 3: do sayi3 = rnd.Next(1, 60); while (sayi3 == sayi1 && sayi3 == sayi2); break;
//          case 4: do sayi4 = rnd.Next(1, 60); while (sayi4 == sayi1 && sayi4 == sayi2 && sayi4 == sayi3); break;
//          case 5: do sayi5 = rnd.Next(1, 60); while (sayi5 == sayi1 && sayi5 == sayi2 && sayi5 == sayi3 && sayi5 == sayi4); break;
//          case 6: do sayi6 = rnd.Next(1, 60); while (sayi6 == sayi1 && sayi6 == sayi2 && sayi6 == sayi3 && sayi6 == sayi4 && sayi6 == sayi5); break;
//        }
//      Console.WriteLine($"Çıkan sayılar  : {sayi1} {sayi2} {sayi3} {sayi4} {sayi5} {sayi6}");
//      if (sayi1 == sayi2 || sayi1 == sayi3 || sayi1 == sayi4 || sayi1 == sayi5 || sayi1 == sayi6 ||
//          sayi2 == sayi3 || sayi2 == sayi4 || sayi2 == sayi5 || sayi2 == sayi6 ||
//          sayi3 == sayi4 || sayi3 == sayi5 || sayi3 == sayi6 ||
//          sayi4 == sayi5 || sayi4 == sayi6 || sayi5 == sayi6)
//      {
//        Console.WriteLine("!!! aynı sayı var !!!");
//        Console.ReadLine();
//      }

//      int gs = 0; // geçici sayı
//      sayi1 = 0; sayi2 = 0; sayi3 = 0; sayi4 = 0; sayi5 = 0; sayi6 = 0;
//      for (int i = 1; i <= 6; i++)
//      {
//        do gs = rnd.Next(1, 60); while (gs = rnd.Next(1, 60)) == sayi1 && gs == sayi2 && gs == sayi3 && gs == sayi4 && gs == sayi5 && gs == sayi6) ;
//      switch (i)
//      {
//        case 1: sayi1 = gs; break;
//        case 2: sayi2 = gs; break;
//        case 3: sayi3 = gs; break;
//        case 4: sayi4 = gs; break;
//        case 5: sayi5 = gs; break;
//        case 6: sayi6 = gs; break;
//      }
//    }
//    Console.WriteLine($"Çıkan sayılar  : {sayi1} {sayi2} {sayi3} {sayi4} {sayi5} {sayi6}");
//if (sayi1 == sayi2 || sayi1 == sayi3 || sayi1 == sayi4 || sayi1 == sayi5 || sayi1 == sayi6 ||
//    sayi2 == sayi3 || sayi2 == sayi4 || sayi2 == sayi5 || sayi2 == sayi6 ||
//    sayi3 == sayi4 || sayi3 == sayi5 || sayi3 == sayi6 ||
//    sayi4 == sayi5 || sayi4 == sayi6 || sayi5 == sayi6)
//{
//  Console.WriteLine("!!! aynı sayı var !!!");
//  Console.ReadLine();
//}

//  // Bulunanları sıralama
//  int gecicisayi1 = 0, gecicisayi2 = 0, gecicisayi3 = 0, gecicisayi4 = 0, gecicisayi5 = 0, gecicisayi6 = 0, bakilansayi = 0;
//for (int i = 1; i <= 6; i++)
//{
//  int min = 60;
//  if (sayi1<min && sayi1> bakilansayi) min = sayi1;
//  if (sayi2<min && sayi2> bakilansayi) min = sayi2;
//  if (sayi3<min && sayi3> bakilansayi) min = sayi3;
//  if (sayi4<min && sayi4> bakilansayi) min = sayi4;
//  if (sayi5<min && sayi5> bakilansayi) min = sayi5;
//  if (sayi6<min && sayi6> bakilansayi) min = sayi6;
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
//Console.WriteLine($"Sayılar sıralı : {gecicisayi1} {gecicisayi2} {gecicisayi3} {gecicisayi4} {gecicisayi5} {gecicisayi6}");


//Console.WriteLine();
//Console.Write("Tekrar için ENTER tuşuna, çıkış için herhangi bir tuşa basınız");
//if (Console.ReadKey().Key == ConsoleKey.Enter)
//{
//  //Console.Clear();
//  Console.WriteLine();
//  goto Basla;
//}


















//      // isimlendirme
//      // ve veya
//      // string.format - $""
//      // datetime
//      // try catch
//      // random


//      //int for = 5;

//      //Console.Write("Sayı giriniz : ");
//      //int sayi1 = int.Parse(Console.ReadLine());
//      //Console.Write("Sayı giriniz : ");
//      //int sayi2 = int.Parse(Console.ReadLine());
//      //if (sayi1 == 4 || sayi1 == 3)
//      //{
//      //  Console.WriteLine("Sayı 1 doğru aralıkta");
//      //}
//      //if (sayi1 == 4 && sayi2 == 4)
//      //{
//      //  Console.WriteLine("Sayı 1 ve sayı 2 doğru");
//      //}



//      //Random rnd = new Random();
//      //int rastgele = rnd.Next(0,10);
//      //while (true)
//      //{
//      //  Console.Write("Tahmininiz : ");
//      //  int tahmin = int.Parse(Console.ReadLine());
//      //  if (tahmin == rastgele)
//      //  {
//      //    Console.WriteLine($"Bildiniz : {rastgele}");
//      //    break;
//      //  }
//      //  if (tahmin < rastgele)
//      //    Console.WriteLine("Yukarı");
//      //  else
//      //    Console.WriteLine("Yukarı");
//      //}

//      //for (int i = 0; i < 5; i++)
//      //{
//      //  Console.Write("Tahmininiz : ");
//      //  int tahmin = int.Parse(Console.ReadLine());
//      //  if (tahmin == rastgele)
//      //  {
//      //    Console.WriteLine($"Bildiniz : {rastgele}");
//      //    break;
//      //  }
//      //  if (tahmin < rastgele)
//      //    Console.WriteLine("Yukarı");
//      //  else
//      //    Console.WriteLine("Yukarı");
//      //}





//      //int sayi1 = 0, sayi2 = 0, sayi3 = 0, sayi4 = 0, sayi5 = 0, sayi6 = 0;
//      //Random rnd = new Random();
//      //for (int i = 1; i <= 6; i++)
//      //  switch (i)
//      //  {
//      //    case 1: sayi1 = rnd.Next(1, 60); break;
//      //    case 2: do sayi2 = rnd.Next(1, 60); while (sayi2 == sayi1); break;
//      //    case 3: do sayi3 = rnd.Next(1, 60); while (sayi3 == sayi1 && sayi3 == sayi2); break;
//      //    case 4: do sayi4 = rnd.Next(1, 60); while (sayi4 == sayi1 && sayi4 == sayi2 && sayi4 == sayi3); break;
//      //    case 5: do sayi5 = rnd.Next(1, 60); while (sayi5 == sayi1 && sayi5 == sayi2 && sayi5 == sayi3 && sayi5 == sayi4); break;
//      //    case 6: do sayi6 = rnd.Next(1, 60); while (sayi6 == sayi1 && sayi6 == sayi2 && sayi6 == sayi3 && sayi6 == sayi4 && sayi6 == sayi5); break;
//      //  }
//      //Console.WriteLine($"Çıkan sayılar  : {sayi1} {sayi2} {sayi3} {sayi4} {sayi5} {sayi6}");

//      //int gecicisayi1 = 0, gecicisayi2 = 0, gecicisayi3 = 0, gecicisayi4 = 0, gecicisayi5 = 0, gecicisayi6 = 0, bakilansayi = 0;
//      //for (int i = 1; i <= 6; i++)
//      //{
//      //  int min = 60;
//      //  if (sayi1 < min && sayi1 > bakilansayi) min = sayi1;
//      //  if (sayi2 < min && sayi2 > bakilansayi) min = sayi2;
//      //  if (sayi3 < min && sayi3 > bakilansayi) min = sayi3;
//      //  if (sayi4 < min && sayi4 > bakilansayi) min = sayi4;
//      //  if (sayi5 < min && sayi5 > bakilansayi) min = sayi5;
//      //  if (sayi6 < min && sayi6 > bakilansayi) min = sayi6;
//      //  switch (i)
//      //  {
//      //    case 1: gecicisayi1 = bakilansayi = min; break;
//      //    case 2: gecicisayi2 = bakilansayi = min; break;
//      //    case 3: gecicisayi3 = bakilansayi = min; break;
//      //    case 4: gecicisayi4 = bakilansayi = min; break;
//      //    case 5: gecicisayi5 = bakilansayi = min; break;
//      //    case 6: gecicisayi6 = bakilansayi = min; break;
//      //  }
//      //}
//      //Console.WriteLine($"Sayılar sıralı : {gecicisayi1} {gecicisayi2} {gecicisayi3} {gecicisayi4} {gecicisayi5} {gecicisayi6}");


//      //for (int i = 1; i < 11; i++)
//      //{
//      //  Console.WriteLine("Fuat - " + i + " / " + (i + 12));
//      //  Console.WriteLine(String.Format("Fuat - {0} / {1}", i, i + 12));
//      //  Console.WriteLine($"Fuat - {i} / {i+12}");
//      //}


//      //int sayi = 0;
//      //int toplam = 0;
//      //while (sayi <= 100)
//      //{
//      //  if (sayi % 2 == 1)
//      //    toplam += sayi;
//      //  sayi++;
//      //}
//      //Console.WriteLine("Tek sayıların toplamı:" + toplam);

//      //char i = 'b';
//      //Console.WriteLine(Convert.ToInt32(i));


//      //char c = 'A';
//      //do
//      //{
//      //  Console.Write(c);
//      //  c++;
//      //} while (c <= 'Z');
//      //Console.WriteLine();


//      // sonsuz döngü for
//      //Console.Write("Tahmin giriniz : ");
//      //for (; ; )
//      //{
//      //  int sayi = int.Parse(Console.ReadLine());
//      //  if (sayi == 5)
//      //  {
//      //    Console.WriteLine("Bildiniz : 5");
//      //    break;
//      //  }
//      //  Console.Write("Bilemediniz, yeni tahmin giriniz : ");
//      //}





















//    }
//  }
//}
















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
//bitis = DateTime.Now;
//Console.WriteLine($"Çıkan sayılar 0  : {sayi1} {sayi2} {sayi3} {sayi4} {sayi5} {sayi6} ({(bitis - basla).TotalMilliseconds}ms)");


//// if - goto
//basla = DateTime.Now;
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
//bitis = DateTime.Now;
//Console.WriteLine($"Çıkan sayılar 1  : {sayi1} {sayi2} {sayi3} {sayi4} {sayi5} {sayi6} ({(bitis - basla).TotalMilliseconds}ms)");
////if (sayi1 == sayi2 || sayi1 == sayi3 || sayi1 == sayi4 || sayi1 == sayi5 || sayi1 == sayi6 ||
////    sayi2 == sayi3 || sayi2 == sayi4 || sayi2 == sayi5 || sayi2 == sayi6 ||
////    sayi3 == sayi4 || sayi3 == sayi5 || sayi3 == sayi6 ||
////    sayi4 == sayi5 || sayi4 == sayi6 || sayi5 == sayi6)
////{
////  Console.WriteLine("!!! aynı sayı var !!!");
////  Console.ReadLine();
////}


//// do while
//basla = DateTime.Now;
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
//bitis = DateTime.Now;
//Console.WriteLine($"Çıkan sayılar 2  : {sayi1} {sayi2} {sayi3} {sayi4} {sayi5} {sayi6} ({(bitis - basla).TotalMilliseconds}ms)");


//// while (atama + karşılaştırma)
//basla = DateTime.Now;
//sayi1 = 0; sayi2 = 0; sayi3 = 0; sayi4 = 0; sayi5 = 0; sayi6 = 0;
//for (int i = 1; i <= 6; i++)
//  switch (i)
//  {
//    case 1: sayi1 = rnd.Next(1, 60); break;
//    case 2: while ((sayi2 = rnd.Next(1, 60)) == sayi1) ; break;
//    case 3:
//      while ((sayi3 = rnd.Next(1, 60)) == sayi1 || sayi3 == sayi2)
//      {
//        int a = 0;
//      }; break;
//    case 4:
//      while ((sayi4 = rnd.Next(1, 60)) == sayi1 || sayi4 == sayi2 || sayi4 == sayi3)
//      {
//        int a = 0;
//      }; break;
//    case 5:
//      while ((sayi5 = rnd.Next(1, 60)) == sayi1 || sayi5 == sayi2 || sayi5 == sayi3 || sayi5 == sayi4)
//      {
//        int a = 0;
//      }; break;
//    case 6:
//      while ((sayi6 = rnd.Next(1, 60)) == sayi1 || sayi6 == sayi2 || sayi6 == sayi3 || sayi6 == sayi4 || sayi6 == sayi5)
//      {
//        int a = 0;
//      }; break;
//  }
//bitis = DateTime.Now;
//Console.WriteLine($"Çıkan sayılar 3  : {sayi1} {sayi2} {sayi3} {sayi4} {sayi5} {sayi6} ({(bitis - basla).TotalMilliseconds}ms)");


//int gs = 0; // geçici sayı - while 
//basla = DateTime.Now;
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
//bitis = DateTime.Now;
//Console.WriteLine($"Çıkan sayılar 4  : {sayi1} {sayi2} {sayi3} {sayi4} {sayi5} {sayi6} ({(bitis - basla).TotalMilliseconds}ms)");


//// Bulunanları sıralama
//basla = DateTime.Now;
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
//bitis = DateTime.Now;
//Console.WriteLine($"Sayılar 4 sıralı : {gecicisayi1} {gecicisayi2} {gecicisayi3} {gecicisayi4} {gecicisayi5} {gecicisayi6} ({(bitis - basla).TotalMilliseconds}ms)");


//Console.WriteLine();
//Console.Write("Tekrar için ENTER tuşuna, çıkış için herhangi bir tuşa basınız");
//if (Console.ReadKey().Key == ConsoleKey.Enter)
//{
//  //Console.Clear();
//  Console.WriteLine();
//  goto Basla;
//}


