using System.Collections.Generic;
using System.Threading.Tasks;
using CPAPP.Domain.Entities;
using CPAPP.Domain.Interfaces;
using CPAPP.Infrastucture.Context;
using Microsoft.EntityFrameworkCore;

namespace CPAPP.Infrastucture.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private ApplicationDbContext _usuarioContext;

        public UsuarioRepository(ApplicationDbContext usuarioContext)
        {
            _usuarioContext = usuarioContext;
        }

        public async Task<IEnumerable<Usuario>> GetUsuariosAsync()
        {
            return await _usuarioContext.Usuarios.ToListAsync();
        }

        public async Task<Usuario> CreateAsync(Usuario usuario)
        {
            _usuarioContext.Add(usuario);
            await _usuarioContext.SaveChangesAsync();
            return usuario;
        }
    }
}