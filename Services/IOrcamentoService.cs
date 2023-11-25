using AppWeb.Models;

namespace AppWeb.Services
{
    public interface IOrcamentoService
    {
        public Task<List<Orcamento>?> GetOrcamentosAsync();
        public Task<Orcamento?> CreateOrcamentoAsync(Orcamento orcamento);
    }
}