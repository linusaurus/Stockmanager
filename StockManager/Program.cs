using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using StockManager.Extensions;
using System.Security.RightsManagement;

namespace StockManager
{
    internal static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {

            var services = new ServiceCollection();

            ConfigureServices(services);

            ApplicationConfiguration.Initialize();

           
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(form1);

            }

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            ServiceExtensions.ConfigureRepositoryManager(services);
            //ServiceExtensions.ConfigureServiceManager(services);
            ServiceExtensions.ConfigureSqlContext(services);
            //ServiceExtensions.ConfigureLoggerService(services);


            //services.AddTransient<IPartRepository, PartRepository>();

            services.AddScoped<MainForm>();

        }

        public class Globals
        {
                public string? UserName;
                public int? UserID;
        }
    }
}