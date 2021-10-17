using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CPAPP.Domain.Validation;
using CPAPP.Domain.ValueObjetcs;

namespace CPAPP.Domain.Entities
{
    public sealed class Usuario : Entity 
    {
        public string Nome { get; private set; }
        public Cpf Cpf { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Sexo { get; private set; }
        
        //TODO: Criar Classe Endereco
        
        private List<string> _tamanhoCampos = new List<string>();
        
        public Usuario(int id, string nome, Cpf cpf, DateTime nascimento, string sexo)
        {
            DomainExceptionValidation.When(id < 0, "Id inválido.");
            Nome = nome;
            Cpf = cpf;
            Nascimento = nascimento;
            Sexo = sexo;
        }

        private void Validacao()
        {
            ValidarCampos();
        }

        private void ValidarCampos()
        {
            if (string.IsNullOrEmpty(Cpf.ToString()) || !Cpf.IsValid())
                DomainExceptionValidation.When(Cpf.IsValid() != true, "Cpf inválido.");
        }
    }
}