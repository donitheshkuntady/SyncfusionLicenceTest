using EJ2APIServices;
using Syncfusion.Licensing;

public class Program
{
    public static void Main(string[] args)
    {
        //// Register Syncfusion license
        //string licenseKey = string.Empty;
        //SyncfusionLicenseProvider.RegisterLicense(licenseKey);

        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
