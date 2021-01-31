using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculaJuros.Aplicacao.TaxaJuros
{
    public class AplicTaxaJuros : IAplicTaxaJuros
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public AplicTaxaJuros(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<decimal> TaxaJurosAsync()
        {          
            var resp = await _httpClientFactory.CreateClient().GetAsync(GetUrl());
            resp.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<decimal>(await resp.Content.ReadAsStringAsync());
        }

        private string GetUrl()
        {
            return _configuration["UrlTaxaJuros"];
        }
    }
}
