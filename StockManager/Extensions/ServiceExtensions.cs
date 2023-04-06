using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Configuration;
using Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace StockManager.Extensions
{
    public static class ServiceExtensions
    {


        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
          services.AddScoped<IRepositoryManager, RepositoryManager>();

        //public static void ConfigureServiceManager(this IServiceCollection services) =>
        //   services.AddScoped<IServiceManager, ServiceManager>();

        //public static void ConfigureLoggerService(this IServiceCollection services) =>
        //    services.AddSingleton<ILoggerManager, LoggerManager>();



        public static void ConfigureSqlContext(this IServiceCollection services)
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);
            IConfiguration config = builder.Build();
            services.AddSingleton<IConfiguration>(config);

            services.AddDbContext<RepositoryContext>(opts =>
                 opts.UseSqlServer(config.GetConnectionString("SqlConnection")));
        }
    }
}
