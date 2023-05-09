using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopAPI.Persistence
{
    static class Configuration
    {
        public static string ConnectionString
        {
            get {
                ConfigurationManager configurationManager = new();
                // The functions below coming from Microsoft.Extensions.Configuration.Json package
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/MiniShopAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("PostgreSQL");

            }
        }
    }
}
