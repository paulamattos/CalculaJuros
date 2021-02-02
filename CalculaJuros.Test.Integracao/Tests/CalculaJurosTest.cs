using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CalculaJuros.Test.Integracao.Tests
{
    public class CalculaJurosTest
    {
        private readonly TestContext _testContext;
        private readonly string _controller = "/calculaJuros";

        public CalculaJurosTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task CalcularAsync_DeveRetornar105_1()
        {            
            var url = QueryHelpers.AddQueryString(_controller, new Dictionary<string, string>
            {
                { "ValorInicial", "100" },
                { "Tempo", "5" }
            });

            var response = await _testContext.Client.GetAsync(url);

            response.EnsureSuccessStatusCode();
            
            var valorAtual = JsonConvert.DeserializeObject<decimal>(await response.Content.ReadAsStringAsync());

            Assert.Equal(105.1m, valorAtual);
        }
    }
}
