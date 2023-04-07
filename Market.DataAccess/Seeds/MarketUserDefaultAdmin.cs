using Market.Entity.Classes.DbClasses.UserClasses;

namespace Market.DataAccess.Seeds
{
  public class MarketUserDefaultAdmin
  {
    private MarketUser DefaultAdmin = new MarketUser
    {
      Id = 0,
      CreatedBy = "System Core",
      CreatedOn = DateTime.Now,
      LastModifiedBy = "System Core",
      LastModifiedOn = DateTime.Now,
      IsActive = true,
      IsDeleted = false,
      Name = "System",
      SurName = "Admin",
      EMail = "admin@system.com",
      Password = "1",
    };

    public MarketUser GetDefaultAdmin()
    {

      return DefaultAdmin;
    }



  }
}
