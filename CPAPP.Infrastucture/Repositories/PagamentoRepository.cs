using System.Threading.Tasks;
using CPAPP.Domain.Entities;
using CPAPP.Domain.Interfaces;
using CPAPP.Infrastucture.Context;

namespace CPAPP.Infrastucture.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private ApplicationDbContext _pagamentoContext;

        public PagamentoRepository(ApplicationDbContext pagamentoContext)
        {
            _pagamentoContext = pagamentoContext;
        }

        public async Task<Pagamento> PagamentoCartao(Pagamento pagamento, Produto nome)
        {
            _pagamentoContext.Add(pagamento);
            await _pagamentoContext.SaveChangesAsync();
            return pagamento;
        }
    }
}