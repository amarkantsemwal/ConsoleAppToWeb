// See https://aka.ms/new-console-template for more information
using ConsoleAppToWeb;
using System.Reflection.PortableExecutable;

class Program
{

    public class EMployee { 
    
    }
    static void Main(string[] arg)
    {

        CreateHostBuilder(arg).Build().Run();
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webbuilder =>
        {
            webbuilder.UseStartup<Startup>();

        });

}


