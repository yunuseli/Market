using Market.DataAccess.Enums;
using Market.Entity.Classes.DbClasses.UserClasses;
using Market.Entity.Classes.SystemClasses;

namespace Market.Presentation.WinUI.Classes.ProgramClasses
{
  public class ProgramInfo
  {
    public ProgramInfo()
    {
      Session.CurrenUser = new MarketUser();
      Session.CurrentClient = new ClientData();
      Session.DbFileRecordingType = DbFileRecordingTypes.Constructor;
    }

    public class Session
    {
      public static DbFileRecordingTypes DbFileRecordingType { get; set; }

      public static MarketUser CurrenUser { get; set; }
      public static ClientData CurrentClient { get; set; }

      public static Guid sGuid { get; set; }
    }


  }
}
