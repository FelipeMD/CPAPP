using System.Collections.Generic;
using System.Threading.Tasks;
using CPAPP.Domain.Entities;

namespace CPAPP.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetProdutosAsync();
        
        Task<Produto> CreateAsync(Produto product);

        Task<Produto> GetByName();
    }
}