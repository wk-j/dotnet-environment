using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MyApp {
    class AppSettings {
        public string ConnectionString { set; get; }
    }

    class Program {
        static void Main(string[] args) {
            var config = new ConfigurationBuilder()
                 .AddJsonFile("appsettings.json", optional: true)
                 .AddEnvironmentVariables()
                 .Build();

            var settings = config.Get<AppSettings>();
            var cs = settings.ConnectionString;
            Console.WriteLine(cs);
        }
    }
}
