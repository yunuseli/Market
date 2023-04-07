using System.ComponentModel.DataAnnotations;

namespace WinFormEFSqLite
{
  public class Product
  {
    public int ProductId { get; set; }

    [StringLength(10)]
    public string? Name { get; set; }

    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;
  }
}
