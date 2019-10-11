using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HrPayrollFinalProject.DAL;
using HrPayrollFinalProject.SeedHost;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HrPayrollFinalProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           IWebHost host =  CreateWebHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                using (PayrollDbContext dbContext =  scope.ServiceProvider.GetRequiredService<PayrollDbContext>())
                {
                   await Seed.InvokeAsync(scope, dbContext);
                }
            }
            await host.RunAsync();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();


    }
}
