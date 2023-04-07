using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Market.Entity.Classes.SystemClasses
{
  public class ClientData
  {
    public IPAddress ClientIp { get; set; }

    public string ClientName { get; set; }

    public string ClientUserName { get; set; }

    public string ClientOSVersion { get; set; }
  }
}
