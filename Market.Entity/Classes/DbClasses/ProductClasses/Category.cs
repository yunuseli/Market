using Market.Entity.Classes.DbClasses.BaseClasses;

namespace Market.Entity.Classes.DbClasses.ProductClasses
{
  public class Category : BaseObject
  {
    public string Definition { get; set; }
    public string Description { get; set; }
    public string ImageType { get; set; }
    public byte[] ImageBytes { get; set; }
  }
}
