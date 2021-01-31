using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculaJuros.Aplicacao.CalculaJuros.DTOs;
using CalculaJuros.Aplicacao.TaxaJuros;

namespace CalculaJuros.Aplicacao.CalculaJuros
{
    public class AplicCalculaJuros : IAplicCalculaJuros
    {
        private readonly IAplicTaxaJuros _aplicTaxaJuros;

        public AplicCalculaJuros(IAplicTaxaJuros aplicTaxaJuros)
        {
            _aplicTaxaJuros = aplicTaxaJuros;
        }

        public async Task<decimal> CalculaJurosAsync(CalculaJurosDTO dto)
        {
            var taxa = await _aplicTaxaJuros.TaxaJurosAsync();
            var juros = (double)dto.ValorInicial * Math.Pow(1 + (double)taxa, dto.Tempo);

            return decimal.Truncate((decimal)juros * 100) / 100;    
        }
    }
}
