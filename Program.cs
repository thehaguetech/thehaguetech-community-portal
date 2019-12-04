using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using thehaguetech_community_portal.Models;

namespace thehaguetech_community_portal
{
    public class Program
    {

        public static void Main(string[] args)
        {


            Apicontroller.GetAuthorisationToken();

            System.Console.WriteLine(Apicontroller.JWTtoken);

            CreateHostBuilder(args).Build().Run();
            //authorization server parameters owned from the client
            //this values are issued from the authorization server to the client through a separate process (registration, etc...)
           
        }



        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
