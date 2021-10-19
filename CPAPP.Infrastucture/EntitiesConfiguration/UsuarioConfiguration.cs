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
            builder.Property(u => u.EnderecoId).HasColumnName("IDEndereco").IsRequired();
            builder.Property(u => u.Nome).HasMaxLength(100).HasColumnName("Nome").IsRequired();
            builder.Property(u => u.Cpf)
                .HasConversion(c => c.ToString(), v => new Cpf())
                .HasColumnName("Cpf")
                .IsRequired();
            builder.Property(u => u.Nascimento).HasColumnName("DTNascimento").IsRequired();
            builder.Property(u => u.Sexo).HasColumnName("Sexo").IsRequired();
            builder.Property(u => u.EnderecoId).HasColumnName("IDEndereco").IsRequired();

            builder.HasOne(e => e.Endereco)
                .WithMany(u => u.Usuarios)
                .HasForeignKey(e => e.EnderecoId);
        }
    }
}