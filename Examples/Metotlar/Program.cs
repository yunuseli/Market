namespace Metotlar
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();

      if (args.Length>0 && args[0].ToString() == "argsornek")
      {
        Application.Run(new ArgsForm());
      }
      else
      {
        Application.Run(new Form1());
      }

    }
  }
}