using Market.Entity.Classes.DbClasses.BaseClasses;

namespace Market.Entity.Classes.DbClasses.UserClasses
{
  public class MarketUser : BaseObject
  {
    public string Name { get; set; }
    public string SurName { get; set; }
    public string FullName => $"{Name} {SurName}";
    public string Password { get; set; }
    public string EMail { get; set; }
    public DateTime BirthDate { get; set; }
    public string ImageType { get; set; }
    public byte[] ImageBytes { get; set; }
  }
}
