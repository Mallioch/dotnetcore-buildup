using Microsoft.AspNetCore.Hosting;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();

            host.Run();
    }
}
