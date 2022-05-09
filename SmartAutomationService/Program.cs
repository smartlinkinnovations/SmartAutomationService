using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SmartAutomationService.Model.Connections;
using SmartAutomationService.Model.Data;
using SmartAutomationService.Model.Proto;
using SmartAutomationService.Model.Services;

namespace SmartAutomationService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                    services.Configure<AppSettings>(hostContext.Configuration.GetSection("AppSettings"));
                    services.AddSingleton<UtilService>();
                    services.AddSingleton<EmailService>();
                    services.AddSingleton<IDbConnection, SmartMedsConnection>();
                    services.AddSingleton<KrollApiService>();
                    services.AddSingleton<AutomationService>();
                }).UseWindowsService();
    }
}