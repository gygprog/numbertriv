using System;
using Microsoft.AspNetCore.Hosting;
using Xunit;
using System.IO;
using api;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http.Headers;
using System.Net.Http;

namespace tests
{
    public class ApiControllerTestBase
    {
    
        protected HttpClient GetClient()
        {
            var builder = new WebHostBuilder()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseStartup<Startup>()
            .UseEnvironment("Testing");

            var server = new TestServer(builder);
            var client = server.CreateClient();

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        
    }
}
