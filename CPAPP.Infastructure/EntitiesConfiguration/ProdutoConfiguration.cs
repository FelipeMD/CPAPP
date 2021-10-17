using CPAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPAPP.Infastructure.EntitiesConfiguration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).HasMaxLength(100).HasColumnName("Nome").IsRequired();
            builder.Property(u => u.CodigoProduto).HasColumnName("CDProduto").IsRequired();

            builder.HasData(
                new Produto(1, "Aplicativo 1", 333),
                new Produto(2, "Aplicativo 2", 123),
                new Produto(3, "Aplicativo 3", 35533),
                new Produto(4, "Aplicativo 4", 534)
                );
        }
    }
}