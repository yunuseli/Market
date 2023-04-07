using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Market.Test.Sqlite.Models
{
  public class Yazar : BaseObject
  {
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Isim => $"{Ad} {Soyad}";

    //public virtual ObservableCollectionListSource<Kitap> Kitaplar { get; } = new();
  }
}
