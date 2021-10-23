using CPAPP.Domain.Entities;
using CPAPP.Domain.ValueObjetcs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CPAPP.Infrastucture.EntitiesConfiguration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            
            builder.HasKey(u => u.Id).HasName("IDUsuario");
            builder.Property(u => u.Nome).HasMaxLength(100).HasColumnName("Nome").IsRequired();
            builder.Property(u => u.Cpf).HasColumnName("Cpf").IsRequired();
            builder.Property(u => u.Cep).HasColumnName("Cep").IsRequired();
            builder.Property(u => u.Uf).HasColumnName("Uf").IsRequired();
            builder.Property(u => u.Nascimento).HasColumnName("Nascimento").IsRequired();
            builder.Property(u => u.Sexo).HasColumnName("Sexo").IsRequired();
        }
    }
}