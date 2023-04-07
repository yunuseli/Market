namespace WorkerServiceBasit
{
  public class Worker : BackgroundService
  {
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
      _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
      while (!stoppingToken.IsCancellationRequested)
      {
        _logger.LogInformation($"Worker çalýþýyor, zaman: {DateTimeOffset.Now}");
        await Task.Delay(1000, stoppingToken);
      }
    }
  }
}