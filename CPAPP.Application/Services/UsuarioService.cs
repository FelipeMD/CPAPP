using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CPAPP.Application.DTOs;
using CPAPP.Application.Interfaces;
using CPAPP.Domain.Entities;
using CPAPP.Domain.Interfaces;

namespace CPAPP.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UsuarioDTO>> GetProdutosAsync()
        {
            var usuariosEntity = await _usuarioRepository.GetUsuariosAsync();
            return _mapper.Map<IEnumerable<UsuarioDTO>>(usuariosEntity);
        }

        public async Task CreateAsync(UsuarioDTO usuarioDto)
        {
            var usuarioEntity = _mapper.Map<Usuario>(usuarioDto);
            await _usuarioRepository.CreateAsync(usuarioEntity);
        }
    }
}