using CalculaJuros.Aplicacao.CalculaJuros.DTOs;
using System.Threading.Tasks;

namespace CalculaJuros.Aplicacao.CalculaJuros
{
    public interface IAplicCalculaJuros
    {
        Task<decimal> CalculaJurosAsync(CalculaJurosDTO dto);
    }
}
