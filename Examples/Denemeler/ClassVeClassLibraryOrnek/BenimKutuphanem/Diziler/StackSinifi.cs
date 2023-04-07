using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimKutuphanem.Diziler
{
  public class StackSinifi
  {
    Stack<string> yigin = new Stack<string>();

    public void Ekle(string deger)
    {
      yigin.Push(deger);
    }

    public string Getir()
    {
      if (yigin.Count == 0)
      {
        return string.Empty;
      }
      return yigin.Pop();
    }

    public List<string> Liste()
    {
      List<string> liste = new List<string>();
      foreach (var item in yigin)
      {
        liste.Add(item.ToString());
      }
      return liste;
    }
  }
}


/*
  Stack, ilk giren son çıkar işleyişine sahip bir koleksiyondur.
  Diğer bir deyişle; ilk eklenen elemanın koleksiyondan en son çıkarıldığı 
  ve en son eklenen elemanında ilk çıkarıldığı bir veri yapısıdır(LIFO).

  Pop(): Stack’in en üstündeki nesneyi çıkarır.
  Push(): Stack’in en üstüne bir nesne ekler.

  Stack’in Kullanım Yerleri
  Tarayıcılarda bulunan “Geri“ butonu, en son ziyaret edilen sayfaya 
  dönme işlemini stack veri yapısını kullanarak gerçekleştirmektedir. 
  Ziyaret edilen siteler Stack’e atılıp, her “Geri“ butonuna tıklanıldığında 
  Stack’in tepesinde bulunan site, Stack’ten çıkarılıp (POP), tarayıcının adres 
  çubuğuna gönderilerek, bir önceki web sitenin görüntülenmesi sağlanır.

  Aynı şekilde word, notepad++ gibi editörlerde bulunan “Geri Al“ butonu, en son 
  yaptığımız işlemin geri alınmasını yine Stack veri yapısını kullanarak gerçekleştirmektedir.


  // Stack içerisine sadece belirtilen veri tipindeki öğeler eklenebilir.
  // Eleman ekleme ve çıkarma işlemlerinde Boxing-Unboxing gerçekleşmez.
  Stack<int> yigin = new Stack<int>();
  // Stack içerisine veri tipi fark etmeksizin her türlü öğe eklenebilir.
  // Eleman ekleme ve çıkarma işlemlerinde Boxing-Unboxing gerçekleşir. 
  Stack yigin = new Stack();

  https://www.srdrylmz.com/c-stack-sinifi/

*/
