YukseklikSOR:
Console.WriteLine("Yükseklik giriniz : ");
int yukseklik, sayi = 2, genislik = Console.WindowWidth / 2;
string yazi = "";
Console.WriteLine(Console.WindowWidth);
if (int.TryParse(Console.ReadLine(), out yukseklik))
{
  if (yukseklik <= genislik)
  {
    Console.WriteLine("*".PadLeft(yukseklik, ' '));
    for (int a = 1; a < yukseklik; a++)
    {

      for (int b = 0; b < a + sayi; b++)
      {
        yazi += "*";
      }
      Console.WriteLine(yazi.PadLeft(a + yukseklik, ' '));
      sayi++; yazi = "";
    }
  }
  else
  {
    Console.WriteLine($"{genislik} değerinden büyük giriş yaptığınız için çizim oturmuyor.");
    goto YukseklikSOR;
  }
}
else
{
  Console.WriteLine("Lütfen Sayı giriniz");
  goto YukseklikSOR;
}