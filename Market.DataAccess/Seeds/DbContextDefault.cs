using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccess.Seeds
{
  public class DbContextDefault
  {

    public string DefaultConnString()
    {
      return $"Data Source=\"YOURSERVER\";Initial Catalog=\"YOURDB\";Persist Security Info=True;User ID=\"YOURUSER\";Password=\"YOURPASSWORD\"";
    }
    public string DefaultConnJson()
    {
      return @"
        {
        ""Data Source"":""YOURSERVER"",
        ""Initial Catalog"":""YOURDB"",
        ""Persist Security Info"":""True"",
        ""User ID"":""YOURUSER"",
        ""Password="":""YOURPASSWORD""
        }
        ";
    }
    public string SystemDbFileName(string applicationStartupPath)
    {
      return applicationStartupPath + "\\dbSys.dbc";
    }
  }
}
