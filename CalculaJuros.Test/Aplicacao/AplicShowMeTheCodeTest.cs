using CalculaJuros.Aplicacao.ShowMeTheCode;
using Microsoft.Extensions.Configuration;
using Moq;
using Xunit;

namespace CalculaJuros.Test.Aplicacao
{
    public class AplicShowMeTheCodeTest
    {
        [Fact]
        public void ShowMeTheCodeControllerRetornarUrlsGit()
        {
            var mockConfiguration = new Mock<IConfiguration>();
            mockConfiguration.Setup(p => p["UrlGitTaxaJuros"]).Returns("url1");
            mockConfiguration.Setup(p => p["UrlGitCalcJuros"]).Returns("url2");
            var aplic = new AplicShowMeTheCode(mockConfiguration.Object);
            var urls = aplic.ShowMeTheCode();
            Assert.Equal("url1", urls.UrlGitTaxaJuros);
            Assert.Equal("url2", urls.UrlGitCalcJuros);
        }
    }
}
