using CPAPP.Domain.Entities;
using Microsoft.VisualBasic;

namespace CPAPP.Application.DTOs
{
    public class PagamentoDTO
    {
        public string NumeroCartao { get; set; }
        public string NomeCartao { get; set; }
        public string DataValidade { get; set; }
        public int CodigoSeguranca { get; set; }
    }
}