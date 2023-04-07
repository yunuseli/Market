using Market.Entity.Classes.ResponseClasses;
using Market.Entity.Classes.SystemClasses;
using Market.Entity.Enums;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;

namespace Market.Helper.Classes.System
{
  public class ClientHelper
  {
    public ClientData GetClientInfo(out ResultObject result)
    {
      result = new ResultObject();
      result.OriginProcess = $"{MethodBase.GetCurrentMethod().DeclaringType.FullName}.{MethodBase.GetCurrentMethod().Name}";
      result.Title = "Client Bilgisi";

      try
      {
        ClientData clientData = new ClientData();

        clientData.ClientName = Environment.MachineName;
        clientData.ClientOSVersion = Environment.OSVersion.VersionString;
        clientData.ClientUserName = Environment.UserName;


        NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces(); //get all network interfaces
        IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName()); // get all IP addresses based on the local host name 
        foreach (NetworkInterface adapter in adapters) //for each Network interface in addapters
        {
          if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet || adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
          {
            if (adapter.OperationalStatus == OperationalStatus.Up)
            {
              if (adapter.Name.Contains("VMware") == false)
              {
                IPInterfaceProperties properties = adapter.GetIPProperties(); // get the ip properties from the adapter and store them into properties
                foreach (UnicastIPAddressInformation ip in properties.UnicastAddresses) // for each UnicastIPAddressInformation in the IPInterfaceProperties Unicast address( this assocaites the IP address with the correct adapter)
                {
                  //if the operationalStatus of the adapter is up and the ip Address family is in the Internwork
                  if (ip.Address.AddressFamily == AddressFamily.InterNetwork) //test against the name of the adapter you want to get
                  {
                    clientData.ClientIp = ip.Address;

                  }//end if
                }//end inner for, the UnicastIPAddressInformation for
              }
            }
          }
        }
        
        result.ResultStatus = ResultStatus.Success;
        result.Message = "İşlem başarılı";
        return clientData;

      }
      catch (Exception ex)
      {
        result.ResultStatus = ResultStatus.Error;
        result.Message = $"İşlem Hatası";
        result.Description = ex.Message;
        return null;
      }
    }

  } // EOF
}
