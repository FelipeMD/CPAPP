using System.Threading.Tasks;
using CPAPP.Application.DTOs;
using CPAPP.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CPAPP.API.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("Post", Name = "Cria Usuario")]
        public async Task<ActionResult> Post([FromBody] UsuarioDTO usuarioDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _usuarioService.CreateAsync(usuarioDto);

            return new CreatedAtRouteResult("GetProduto",
                new { id = usuarioDto.Id }, usuarioDto);
        }
    }
}