using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using CPAPP.Domain.Validation;
using CPAPP.Domain.ValueObjetcs;

namespace CPAPP.Domain.Entities
{
    public class Usuario : Entity 
    {
        public string Nome { get; protected set; }
        public string Cpf { get; protected set; }
        public DateTime Nascimento { get; protected set; }
        public string Sexo { get; protected set; }
        public string Uf { get; protected set; }
        public string Cep { get; protected set; }

        private List<string> _tamanhoCampos = new List<string>();
        
        // public Usuario(int id, string nome, Cpf cpf, DateTime nascimento, string sexo, Endereco endereco)
        // {
        //     DomainExceptionValidation.When(id < 0, "Id inválido.");
        //     Nome = nome;
        //     Cpf = cpf;
        //     Nascimento = nascimento;
        //     Sexo = sexo;
        //     Endereco = endereco;
        // }

        // private void Validacao()
        // {
        //     ValidarCampos();
        // }

        // private void ValidarCampos()
        // {
        //     if (string.IsNullOrEmpty(Cpf.ToString()) || !Cpf.IsValid())
        //         DomainExceptionValidation.When(Cpf.IsValid() != true, "Cpf inválido.");
        // }
    }
}