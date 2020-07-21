using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ToDoList
{
  public class program
  {
    public static void Main()
    {
      var host = new WebHostBuilder()
          .UseKestrel()
          .UseContentRoot(Directory.GetCurrentDirectory())
          .UseIISIntegration()
          .UseStartup<Startup>()
          .Build();

        host.Run();
    }
  }
}