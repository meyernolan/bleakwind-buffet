/*
 * Author: Nolan Meyer
 * Class name: Program.cs
 * Purpose: Class for the Program
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Website
{
    public class Program
    {
        /// <summary>
        /// The Main method of the program
        /// </summary>
        /// <param name="args">a string array for creating the host builder</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates a host builder
        /// </summary>
        /// <param name="args"> the string array for building the host builder</param>
        /// <returns>IHostBuilder-the host builder for the program</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
