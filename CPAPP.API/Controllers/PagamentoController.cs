using System.Threading.Tasks;
using CPAPP.Application.DTOs;
using CPAPP.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CPAPP.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PagamentoController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly IPagamentoService _pagamentoService;

        public PagamentoController(IProdutoService produtoService, IPagamentoService pagamentoService)
        {
            _produtoService = produtoService;
            _pagamentoService = pagamentoService;
        }
        
        [HttpPost ("Post")]
        public async Task<ActionResult> Post([FromBody] PagamentoDTO pagamentoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            } 
            
            var nome = await _produtoService.GetByName();
           await _pagamentoService.PagamentoCartao(pagamentoDto, nome);

           return Ok(true);
        }
    }
}