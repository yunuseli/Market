using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace DeleteBackUpFileService
{
  public class Worker : BackgroundService
  {
    private int _serviceRunInDays;
    private int _serviceRunInSeconds;
    private string _backUpFilePath;

    private IServiceScopeFactory _serviceScopeFactory;

    public Worker(IServiceScopeFactory serviceScopeFactory)
    {
      _serviceScopeFactory = serviceScopeFactory;
    }

    public override Task StartAsync(CancellationToken cancellationToken)
    {
      var configuration = _serviceScopeFactory.CreateScope().ServiceProvider.GetRequiredService<IConfiguration>();
      _backUpFilePath = configuration["FileConfigSettings:BackUpFilePath"];
      _serviceRunInDays = Convert.ToInt32(configuration["FileConfigSettings:RunIntervalInDays"]);
      _serviceRunInSeconds = Convert.ToInt32(configuration["FileConfigSettings:RunIntervalInSeconds"]);
      return base.StartAsync(cancellationToken);
    }
    public override Task StopAsync(CancellationToken cancellationToken)
    {
      return base.StopAsync(cancellationToken);
    }

    public void ClearBackUpFile()
    {
      try
      {
        if (!Directory.Exists(_backUpFilePath))
          Directory.CreateDirectory(_backUpFilePath);

        string[] files = Directory.GetFiles(_backUpFilePath, "*.bak*");
        Array.ForEach(files, File.Delete);
      }
      catch (Exception)
      {
      }
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
      while (!stoppingToken.IsCancellationRequested)
      {
        ClearBackUpFile();
        //await Task.Delay(TimeSpan.FromDays(_serviceRunInDays), stoppingToken);
        await Task.Delay(TimeSpan.FromSeconds(_serviceRunInSeconds), stoppingToken);
      }
    }
  }
}
