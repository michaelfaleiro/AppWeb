using AppWeb.Models;
using RestSharp;


namespace AppWeb.Services

{

    public class OrcamentoService : IOrcamentoService
    {

        public async Task<List<Orcamento>?> GetOrcamentosAsync()
        {
            var options = new RestClientOptions($"{Configuration.ApiUrl}");

            var client = new RestClient(options);
            var request = new RestRequest("v1/api/orcamentos");

            var orcamentos = await client.GetAsync<List<Orcamento>>(request);

            return orcamentos;
        }

        public async Task<Orcamento?> CreateOrcamentoAsync(Orcamento model)
        {
            var options = new RestClientOptions($"{Configuration.ApiUrl}");

            var client = new RestClient(options);
            var request = new RestRequest("v1/api/orcamentos")
            .AddBody(model);

            var orcamento = await client.PostAsync<Orcamento?>(request);
            

            return orcamento;
        }
    }
}