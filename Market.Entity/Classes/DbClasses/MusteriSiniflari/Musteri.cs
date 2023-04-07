using Market.Entity.Classes.DbClasses.BaseClasses;

namespace Market.Entity.Classes.DbClasses.MusteriSiniflari
{
  public class Musteri : BaseObject
  {
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Isim => $"{Ad} {Soyad}";
    public string Telefon { get; set; }
  }
}
