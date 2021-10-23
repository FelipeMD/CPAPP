using System.Collections.Generic;
using System.Threading.Tasks;
using CPAPP.Application.DTOs;
using CPAPP.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CPAPP.API.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Components.Route("api/v1/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        
        [HttpPost ("Post")]
        public async Task<ActionResult> Post([FromBody] ProdutoDTO produtoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
        
            await _produtoService.CreateAsync(produtoDto);
        
            return new CreatedAtRouteResult("GetProduto",
                new { id = produtoDto.Id }, produtoDto);
        }
        
        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> Get()
        {
            var produtos = await _produtoService.GetProdutosAsync();
            return Ok(produtos);
        }
    }
}