using System.ComponentModel.DataAnnotations;

namespace Market.Test.Sqlite.Models
{
  public class Kitap : BaseObject
  {
    [Required]
    public string Adi { get; set; }
    [Required]
    public string Barkod { get; set; }
    [Required]
    public short BaskiYili { get; set; }
    [Required]
    public short SayfaSayisi { get; set; }
    public string Aciklama { get; set; }

    [Required]
    public int YazarId { get; set; }
    [Required]
    public virtual Yazar Yazar { get; set; }
    //public virtual Yazar Yazar { get; set; } = null!;


    public int YayineviId { get; set; }
    public virtual Yayinevi Yayinevi { get; set; }
    //public virtual Yayinevi Yayinevi { get; set; } = null!;
  }
}

//[CascadeDelete]
