﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace GroupDocs.Viewer.UI.Cloud.Api.Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}