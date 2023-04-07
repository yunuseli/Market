using Market.Entity.Classes.DbClasses.BaseClasses;

namespace Market.Entity.Classes.DbClasses.ProductClasses
{
  public class BrandModel : BaseObject
  {
    public int ParentId { get; set; }
    public string Definition { get; set; }
    public string Description { get; set; }
    public string ImageType { get; set; }
    public byte[] ImageBytes { get; set; }
  }
}
