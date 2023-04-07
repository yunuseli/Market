using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DeleteBackUpFileService
{
  public class Program
  {
    //https://mertmtn.blogspot.com/2020/12/net-core-ile-windows-servis-uygulamas.html

    // publish
    // cmd
    // sc create BenimServisim binPath="C:\Program Files (x86)\Common Files\BenimUygulamam\DeleteBackUpFileService.exe",
    //sc query "BenimServisim"
    //sc start "BenimServisim"
    //sc stop "BenimServisim"
    //sc delete "BenimServisim"


    //Run Regedit or Regedt32
    //Go to the registry entry "HKEY_LOCAL_MACHINE/SYSTEM/CurrentControlSet/Services"


    public static void Main(string[] args)
    {
      CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseWindowsService() //Worker service working as a Windows Service
            .ConfigureServices((hostContext, services) =>
            {
              services.AddHostedService<Worker>();
            });
  }
}
