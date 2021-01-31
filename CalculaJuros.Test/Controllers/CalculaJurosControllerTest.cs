using CalculaJuros.Aplicacao.CalculaJuros;
using CalculaJuros.Aplicacao.CalculaJuros.DTOs;
using CalculaJuros.Controllers;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculaJuros.Test.Controllers
{
    public class CalculaJurosControllerTest
    {
        [Fact]
        public async void CalculaValorTotalComJurosDeveRetornar105_1()
        {
            var calculaJurosDTO = new CalculaJurosDTO()
            {
                ValorInicial = 100,
                Tempo = 5
            };

            var mockAplicCalculaJuros = new Mock<IAplicCalculaJuros>();
            mockAplicCalculaJuros.Setup(p => p.CalculaJurosAsync(calculaJurosDTO)).ReturnsAsync(105.1m);
            var controller = new CalculaJurosController(mockAplicCalculaJuros.Object);
            var valorTotal = await controller.CalculaJurosAsync(calculaJurosDTO);
            Assert.Equal(105.1m, valorTotal);
        }
    }
}
