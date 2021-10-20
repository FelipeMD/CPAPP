using System.Collections.Generic;
using System.Threading.Tasks;
using CPAPP.Domain.Entities;
using CPAPP.Domain.Interfaces;
using CPAPP.Infrastucture.Context;
using Microsoft.EntityFrameworkCore;

namespace CPAPP.Infrastucture.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private ApplicationDbContext _productContext;
        public ProdutoRepository(ApplicationDbContext context)
        {
            _productContext = context;
        }
        
        public async Task<IEnumerable<Produto>> GetProdutosAsync()
        {
            return await _productContext.Produtos.ToListAsync();
        }

        public async Task<Produto> CreateAsync(Produto product)
        {
            _productContext.Add(product);
            await _productContext.SaveChangesAsync();
            return product;
        }
    }
}