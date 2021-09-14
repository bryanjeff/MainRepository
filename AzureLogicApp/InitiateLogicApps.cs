using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using PO_API.Entities;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;

namespace PO_API.AzureLogicApp
{
    public class InitiateLogicApps
    {
        public class MyLogicAppConfig {
            public string URL {get; set;}
        }

        public async void TriggerCreateNotif(Object _object) {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            IConfigurationRoot Configuration = builder.Build();
            var myLogicAppConfig = new MyLogicAppConfig();
            Configuration.GetSection("LogicAppSettings").Bind(myLogicAppConfig);

            HttpClient thisClient = new HttpClient();
            string req = JsonSerializer.Serialize(_object);
            HttpResponseMessage result = await thisClient.PostAsync(
                myLogicAppConfig.URL,
                new StringContent(req, Encoding.UTF8, "application/json")
                );
            //string statusCode = result.StatusCode.ToString();
        }


    }
}
