namespace CPAPP.Domain.Entities
{
    public class Endereco : Entity
    {
        public string Uf { get; protected set; }
        public string Cep { get; protected set; }
        public string Logradouro { get; protected set; }
        public string Numero { get; protected set; }
        public string Complemento { get; protected set; }
        public string Bairro { get; protected set; }
        public string Municipio { get; protected set; }
        public Usuario Usuario { get; protected set; }
        public int UsarioId { get; protected set; }

        public Endereco(int id, string uf, string cep,
            string logradouro,
            string numero,
            string complemento,
            string bairro,
            string municipio,
            Usuario usuario)
        {
            Id = id;
            Uf = uf;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Municipio = municipio;
            Usuario = usuario;
        }
    }
}