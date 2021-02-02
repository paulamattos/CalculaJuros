using CalculaJuros.Aplicacao.ShowMeTheCode;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CalculaJuros.Test.Integracao.Tests
{
    public class ShowMeTheCodeTest
    {
        private readonly TestContext _testContext;
        private readonly string _controller = "/showmethecode";

        public ShowMeTheCodeTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task GetUrlGitGub_TestaRetorno()
        {          
            var response = await _testContext.Client.GetAsync(_controller);

            response.EnsureSuccessStatusCode();

            var ret = JsonConvert.DeserializeObject<UrlDTO>(await response.Content.ReadAsStringAsync());
            
            Assert.Equal(ret.UrlGitTaxaJuros, "https://github.com/paulamattos/TaxaJuros.git");
            Assert.Equal(ret.UrlGitCalcJuros, "https://github.com/paulamattos/CalculaJuros.git");
        }
    }
}
