using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Market.Test.Sqlite.Models
{
  public class Yayinevi : BaseObject
  {
    public string Tanim { get; set; }

    //public virtual ObservableCollectionListSource<Kitap> Kitaplar { get; } = new();
  }
}
