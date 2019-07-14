using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Czar.Cms.Admin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            //.UseConfiguration(GetConfiguration())
             //.UseKestrel()
            // .UseIISIntegration()
            .UseStartup<Startup>();
            //.ConfigureKestrel((context, options) =>
            //{
            //    // Set properties and call methods on options
            //});

        public static IConfiguration GetConfiguration()
        {
            var config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("hosting.json", optional: true)

        .Build();
            return config;
        }
    }
}
