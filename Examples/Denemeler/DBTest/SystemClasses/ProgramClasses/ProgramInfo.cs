using DBTest.DataModels.BaseModels;
using DBTest.DataModels.ClientModels;
using DBTest.DataModels.UserModels;

namespace DBTest.SystemClasses.ProgramClasses
{
  public class ProgramInfo
  {
    public ProgramInfo()
    {
      Session.currentUser = new UserModel();
      Session.currentClient = new ClientModel();
      DataBase.systemDbFileName = Application.StartupPath + "\\dbf.dbc";
    }

    public class Session
    {
      public static string currentUserFullName { get { return $"{currentUser.Name} {currentUser.SurName}"; } }

      public static UserModel currentUser { get; set; }

      public static ClientModel currentClient { get; set; }

      public static Guid sGuid { get; set; }
      public static int sId { get; set; }

    }
    public class DataBase
    {
      public static string systemDbFileName { get; set; }
      public static string defaultDbConnStr
      {
        get { return $"Data Source=\"YOURSERVER\";Initial Catalog=\"YOURDB\";Persist Security Info=True;User ID=\"YOURUSER\";Password=\"YOURPASSWORD\""; }
      }

    }

    public static string result(ResultObject resultObject)
    {
      string res = resultObject.Message;
      if (!String.IsNullOrEmpty(resultObject.Description))
      {
        res.Concat(" : ");
        res.Concat(resultObject.Description);
      }
      return res;
    }

    public static string classMessage(string msg, string name)
    {
      string res = msg;
      if (!String.IsNullOrEmpty(name))
      {
        res += Environment.NewLine + Environment.NewLine;
        res += name;
      }
      return res;
    }


  }
}
