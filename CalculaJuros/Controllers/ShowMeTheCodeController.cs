using CalculaJuros.Aplicacao.ShowMeTheCode;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.Controllers
{
    [Route("showmethecode")]
    public class ShowMeTheCodeController
    {
        private readonly IAplicShowMeTheCode _aplicShowMeTheCode;
        public ShowMeTheCodeController(IAplicShowMeTheCode aplicShowMeTheCode)
        {
            _aplicShowMeTheCode = aplicShowMeTheCode;
        }

        [HttpGet]
        public object ShowMeTheCode()
        {
            return _aplicShowMeTheCode.ShowMeTheCode();
        }
    }
}
