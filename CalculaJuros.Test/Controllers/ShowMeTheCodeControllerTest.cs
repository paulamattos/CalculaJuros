using CalculaJuros.Aplicacao.ShowMeTheCode;
using CalculaJuros.Controllers;
using Moq;
using Xunit;

namespace CalculaJuros.Test.Controllers
{
    public class ShowMeTheCodeControllerTest
    {
        [Fact]
        public void ShowMeTheCodeControllerRetornarUrlsGit()
        {
            var mockAplicShowMeTheCode = new Mock<IAplicShowMeTheCode>();

            var urls = new UrlDTO()
            {
                UrlGitTaxaJuros = "url1",
                UrlGitCalcJuros = "url2"
            };

            mockAplicShowMeTheCode.Setup(p => p.ShowMeTheCode()).Returns(urls);
            var controller = new ShowMeTheCodeController(mockAplicShowMeTheCode.Object);
            var retUrls = controller.ShowMeTheCode();
            Assert.Equal(urls.UrlGitTaxaJuros, retUrls.UrlGitTaxaJuros);
            Assert.Equal(urls.UrlGitCalcJuros, retUrls.UrlGitCalcJuros);
        }
    }
}
