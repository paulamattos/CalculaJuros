using CalculaJuros.Aplicacao.CalculaJuros;
using CalculaJuros.Aplicacao.CalculaJuros.DTOs;
using CalculaJuros.Aplicacao.TaxaJuros;
using Moq;
using Xunit;

namespace CalculaJuros.Test.Aplicacao
{
    public class AplicCalculaJurosTest
    {
        public async void CalculaValorTotalComJurosDeveRetornar105_1()
        {
            var mockAplicTaxaJuros = new Mock<IAplicTaxaJuros>();
            mockAplicTaxaJuros.Setup(p => p.TaxaJurosAsync()).ReturnsAsync(0.01m);
            var aplic = new AplicCalculaJuros(mockAplicTaxaJuros.Object);
            var valorTotal = await aplic.CalculaJurosAsync(new CalculaJurosDTO() { ValorInicial = 100, Tempo = 1 });
            Assert.Equal(105.1m, valorTotal);
        }
    }
}
