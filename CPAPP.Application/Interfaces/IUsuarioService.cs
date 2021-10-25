using System.Collections.Generic;
using System.Threading.Tasks;
using CPAPP.Application.DTOs;

namespace CPAPP.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<UsuarioDTO>> GetProdutosAsync();

        Task CreateAsync(UsuarioDTO usuarioDto);
    }
}