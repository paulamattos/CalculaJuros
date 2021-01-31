using Microsoft.Extensions.Configuration;

namespace CalculaJuros.Aplicacao.ShowMeTheCode
{
    public class AplicShowMeTheCode: IAplicShowMeTheCode
    {
        private readonly IConfiguration _configuration;

        public AplicShowMeTheCode(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public UrlDTO ShowMeTheCode()
        {
            return new UrlDTO
            {
                UrlGitTaxaJuros = _configuration["UrlGitTaxaJuros"],
                UrlGitCalcJuros = _configuration["UrlGitCalcJuros"]
            };
        }
    }
}
