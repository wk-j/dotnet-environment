using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MyApp {
    class AppSettings {
        public string ConnectionString { set; get; }
        public Alfresco Alfresco { set; get; }
    }

    public class Alfresco {
        public string User { set; get; }
    }

    class Program {
        static void Main(string[] args) {
            var config = new ConfigurationBuilder()
                 .AddJsonFile("appsettings.json", optional: true)
                 .AddEnvironmentVariables()
                 .Build();

            var settings = config.Get<AppSettings>();
            var cs = settings.ConnectionString;

            Console.WriteLine("ConnectionString = {0}", cs);
            Console.WriteLine("Alfresco.User = {0}", settings.Alfresco.User);
        }
    }
}
