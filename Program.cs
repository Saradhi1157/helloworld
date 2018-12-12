﻿using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace HelloWorld.net
{
    class Program
    {
        static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder().
                UseStartup<Startup>().
                UseKestrel().
                UseUrls("http://0.0.0.0:80").
                Build().
                Run();
        }
    }

    public class Startup
    {
        public void Configure(IApplicationBuilder applicationBuilder, IHostingEnvironment hostingEnvironment)
        {
            applicationBuilder.Run(async context =>
            {
                await context.Response.WriteAsync("Hello, World!");
            });
        }
    }
}
