using System.Threading.Tasks;
using CPAPP.Application.DTOs;
using CPAPP.Domain.Entities;

namespace CPAPP.Application.Interfaces
{
    public interface IPagamentoService
    {
        Task PagamentoCartao(PagamentoDTO pagamentoDto, Produto nome);
    }
}