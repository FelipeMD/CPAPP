using System.Collections.Generic;
using System.Threading.Tasks;
using CPAPP.Application.DTOs;
using CPAPP.Domain.Entities;

namespace CPAPP.Application.Interfaces
{
    public interface IProdutoService
    {
        Task<List<ProdutoDTO>> GetProdutosAsync();

        Task CreateAsync(ProdutoDTO produtoDto);

        Task<Produto> GetByName();
    }
}