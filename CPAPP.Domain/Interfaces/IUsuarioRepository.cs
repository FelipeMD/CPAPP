using System.Collections.Generic;
using System.Threading.Tasks;
using CPAPP.Domain.Entities;

namespace CPAPP.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetUsuariosAsync();
        
        Task<Usuario> CreateAsync(Usuario usuario);
    }
}