using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyPortfolio.BusinessLogic.Implementations;
using MyPortfolio.BusinessLogic.Interfaces;
using MyPortfolio.DataAccess.Implementations;
using MyPortfolio.DataAccess.Interfaces;

namespace MyPortfolio
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
             .ConfigureServices((hostContext, services) =>
             {
                 services.AddSingleton<Portfolio>();
                 services.AddSingleton<BuildPortfolio>();
                 services.AddLogging(configure => configure.AddConsole()); // ToDo: Replace with file logger 

                 // Business Logic
                 services.AddScoped<ITradesBusinessLogic, TradesBusinessLogic>();
                 services.AddScoped<IPortfolioPerformanceBusinessLogic, PortfolioPerformanceBusinessLogic>();
                 services.AddScoped<IPortfolioBusinessLogic, PortfolioBusinessLogic>();

                 //Data Access
                 services.AddScoped<ITradesRepository, TradesRepository>();
                 services.AddScoped<IStockInformationRepository, StockInformationRepository>();
                 services.AddScoped<IPortfolioPerformanceRepository, PortfolioPerformanceRepository>();
                 services.AddScoped<IPortfolioRepository, PortfolioRepository>();
                 services.AddScoped<IHttpClientRepository, HttpClientRepository>();
             });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                try
                {
                    Application.SetHighDpiMode(HighDpiMode.SystemAware);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    var buildPortfolio = services.GetRequiredService<BuildPortfolio>();
                    Application.Run(buildPortfolio);

                    // Log Success
                }
                catch(Exception ex)
                {
                    // Log exception details
                }
            }
        }
    }
}
