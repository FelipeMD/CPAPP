namespace CPAPP.Domain.Entities
{
    public class Produto : Entity
    {
        public string Nome { get; protected set; }
        public int CodigoProduto { get; protected set; }

        public Produto(int id, string nome, int codigoProduto)
        {
            Id = id;
            Nome = nome;
            CodigoProduto = codigoProduto;
        }
    }
}