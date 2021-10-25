using System.Threading.Tasks;
using CPAPP.Application.DTOs;
using CPAPP.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CPAPP.API.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Components.Route("api/v1/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("criaUsuario")]
        public async Task<ActionResult> Post([FromBody] UsuarioDTO usuarioDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _usuarioService.CreateAsync(usuarioDto);

            return Ok();
        }
    }
}