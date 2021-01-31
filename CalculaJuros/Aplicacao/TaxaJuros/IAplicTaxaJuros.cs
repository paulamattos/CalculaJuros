using System.Threading.Tasks;

namespace CalculaJuros.Aplicacao.TaxaJuros
{
    public interface IAplicTaxaJuros
    {
        Task<decimal> TaxaJurosAsync();
    }
}