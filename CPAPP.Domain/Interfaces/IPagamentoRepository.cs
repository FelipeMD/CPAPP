using System.Collections.Generic;
using System.Threading.Tasks;
using CPAPP.Domain.Entities;

namespace CPAPP.Domain.Interfaces
{
    public interface IPagamentoRepository
    {
        Task<Pagamento> PagamentoCartao(Pagamento pagamento, Produto nome);
    }
}