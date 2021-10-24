using Microsoft.VisualBasic;

namespace CPAPP.Domain.Entities
{
    public class Pagamento : Entity
    {
        public string NumeroCartao { get; set; }
        public string NomeCartao { get; set; }
        public string DataValidade { get; set; }
        public int CodigoSeguranca { get; set; }
    }
}