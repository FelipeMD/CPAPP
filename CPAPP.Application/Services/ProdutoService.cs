using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CPAPP.Application.DTOs;
using CPAPP.Application.Interfaces;
using CPAPP.Domain.Entities;
using CPAPP.Domain.Interfaces;

namespace CPAPP.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private IProdutoRepository _productRepository;

        private readonly IMapper _mapper;
        public ProdutoService(IMapper mapper, IProdutoRepository productRepository)
        {
            _productRepository = productRepository ??
                                 throw new ArgumentNullException(nameof(productRepository));

            _mapper = mapper;
        }
        
        public async Task<IEnumerable<ProdutoDTO>> GetProdutosAsync()
        {
            var productsEntity = await _productRepository.GetProdutosAsync();
            return _mapper.Map<IEnumerable<ProdutoDTO>>(productsEntity);
        }

        public async Task CreateAsync(ProdutoDTO produtoDto)
        {
            var productEntity = _mapper.Map<Produto>(produtoDto);
            await _productRepository.CreateAsync(productEntity);
        }
    }
}