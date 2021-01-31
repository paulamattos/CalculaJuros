using CalculaJuros.Aplicacao.TaxaJuros;
using Microsoft.Extensions.Configuration;
using Moq;
using Moq.Contrib.HttpClient;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xunit;

namespace CalculaJuros.Test.Aplicacao
{
    public class AplicTaxaJurosTest
    {
        [Fact]
        public async void TaxaJurosDeveRetornar0_01()
        {
            var urlTaxaJuros = "http://localhost";
            var mockConfiguration = new Mock<IConfiguration>();
            mockConfiguration.SetupGet(p => p["UrlTaxaJuros"]).Returns(urlTaxaJuros);

            var handler = new Mock<HttpMessageHandler>();
            var factory = handler.CreateClientFactory();

            Mock.Get(factory).Setup(x => x.CreateClient(string.Empty))
                .Returns(() =>
                {
                    var client = handler.CreateClient();
                    client.BaseAddress = new Uri(urlTaxaJuros);

                    return client;
                });

            handler.SetupRequest(HttpMethod.Get, urlTaxaJuros)
                   .ReturnsResponse("0.01");

            var aplic = new AplicTaxaJuros(factory, mockConfiguration.Object);
            var taxaJuros = await aplic.TaxaJurosAsync();
            Assert.Equal(0.01m, taxaJuros);
        }
    }
}
