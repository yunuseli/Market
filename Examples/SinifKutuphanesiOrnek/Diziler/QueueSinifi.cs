using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
  public class QueueSinifi
  {

    Queue<string> kuyruk = new Queue<string>();

    public void Ekle(string deger)
    {
      kuyruk.Enqueue(deger);
    }

    public string Getir()
    {
      if (kuyruk.Count == 0)
      {
        return string.Empty;
      }
      return kuyruk.Dequeue();
    }

    public List<string> Liste()
    {
      List<string> liste = new List<string>();
      foreach (var item in kuyruk)
      {
        liste.Add(item.ToString());
      }
      return liste;
    }

  }
}


/*
  Queue(Kuyruk), ilk giren ilk çıkar işleyişine sahip bir koleksiyondur(FIFO). 
  Koleksiyondan bir eleman çıkarılmak istenildiğinden, kuyruğun en önünde yer 
  eleman çıkartılacaktır. Yeni eklenmek istenen bir eleman ise kuyruğun 
  en sonuna eklenecektir.

  Aslında bu veri yapısı günlük yaşantımızda şıkça karşılaştığımız ve 
  gözlemlediğimiz bir işleyişe sahip. Fatura yatırmak için sıra bekleyen 
  bir grup insanın oluşturmuş olduğu bir kuyruğu düşünecek olursak; 
  Sıraya ilk giren kişi yani kuyruğun en önünde bulunan kişi, faturasını 
  ilk yatıracak kişidir. Bu yüzden kuyruktan ilk bu kişi ayrılacaktır. 
  Sıraya en son giren yani kuyruğun sonunda ki kişi ise faturasını en son 
  yatıracak kişidir. Eğer sıraya başka bir kişi daha dahil olmak isterse,
  direk kuyruğun en sonuna geçip sırasını bekleyecektir.

  Queue (Kuyruk) diğer koleksiyon sınıfları gibi dinamik bir yapıya sahiptir. 
  Yani eleman eklendikçe boyutu dinamik olarak artmaktadır.

  Queue sınıfının Enqueue() ve Dequeue() olmak üzere 2 temel metodu bulunmaktadır.

  Enqueue(): Kuyruğun sonuna bir eleman ekler.
  Dequeue(): Kuyruğun başındaki elemanı çıkarır.


  https://www.srdrylmz.com/c-queue-sinifi/
*/