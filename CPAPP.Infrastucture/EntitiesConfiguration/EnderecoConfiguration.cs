using CPAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPAPP.Infrastucture.EntitiesConfiguration
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            
            builder.HasKey(e => e.Id).HasName("IDEndereco");
            builder.Property(e => e.Uf).HasColumnName("Uf").IsRequired();
            builder.Property(e => e.Cep).HasColumnName("Cep").IsRequired();
            builder.Property(e => e.Logradouro).HasColumnName("Logradouro").IsRequired();
            builder.Property(e => e.Numero).HasColumnName("Numero").IsRequired();
            builder.Property(e => e.Complemento).HasColumnName("Complemento").IsRequired();
            builder.Property(e => e.Bairro).HasColumnName("Bairro").IsRequired();
            builder.Property(e => e.Municipio).HasColumnName("Municipio").IsRequired();

            builder.HasMany(e => e.Usuarios)
                .WithOne(u => u.Endereco);
        }
    }
}