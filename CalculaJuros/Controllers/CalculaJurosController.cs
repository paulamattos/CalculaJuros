using CalculaJuros.Aplicacao.CalculaJuros;
using CalculaJuros.Aplicacao.CalculaJuros.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CalculaJuros.Controllers
{
    [Route("calculaJuros")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IAplicCalculaJuros _aplicCalculaJuros;
        public CalculaJurosController(IAplicCalculaJuros aplicCalculaJuros)
        {
            _aplicCalculaJuros = aplicCalculaJuros;
        }

        [HttpGet]
        public async Task<decimal> CalculaJurosAsync(CalculaJurosDTO dto)
        {
            return await _aplicCalculaJuros.CalculaJurosAsync(dto);
        }
    }
}
