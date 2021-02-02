using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace CalculaJuros.Test.Integracao
{
    public class TestContext
    {
        public HttpClient Client { get; set; }
        private TestServer _server;

        public TestContext()
        {
            var webBuilder = new WebHostBuilder().UseStartup<Startup>();
            webBuilder.ConfigureServices(p =>
            {

            });
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>()
                                                         .UseConfiguration(new ConfigurationBuilder()
                                                         .AddJsonFile("appsettings.json")
                                                         .Build()));
            Client = _server.CreateClient();
        }        
    }
}
