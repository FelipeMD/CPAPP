using System;
using CPAPP.Domain.Entities;
using CPAPP.Domain.ValueObjetcs;

namespace CPAPP.Application.DTOs
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public string Sexo { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
    }
}