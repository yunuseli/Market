using DBTest.DataModels.BaseModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace DBTest.DataModels.ClientModels
{
  public class ClientModel
  {
    public IPAddress ClientIp { get; set; }

    [StringLength(30)]
    public string ClientName { get; set; }

    [StringLength(30)]
    public string ClientUserName { get; set; }

    [StringLength(30)]
    public string ClientOSVersion { get; set; }


  }
}
