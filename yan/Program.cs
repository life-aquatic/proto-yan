using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using proto.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using proto.DIscratch;

namespace proto
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            CreateDbIfNotExists(host);

            host.Run();
            CreateWebHostBuilder(args).Build().Run();
        }


        private static void CreateDbIfNotExists(IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<CDPContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
            Guid s = new Guid ("72C75AA1-2F4E-4484-AAA1-CE13A7AC8891");
        }


        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(AddAppConfiguration)
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddConsole();
            })
            .UseStartup<Startup>();
        //why do I have this "AddAppConfiguration" here, if I am also adding configuration in Startup.ConfigureServices??????????
        public static void AddAppConfiguration(WebHostBuilderContext hostingContext,
            IConfigurationBuilder config)
        {
            //this magic line is very important. environment variables are buried inside that WebHostBuilderContext thingie - 
            //how else could I have found out it's there?
            var env = hostingContext.HostingEnvironment.EnvironmentName;
            config
                .AddJsonFile("somesettings.json", optional: true)
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile($"appsettings.{env}.json", optional: true)
                .AddEnvironmentVariables();
        }
    }
}
