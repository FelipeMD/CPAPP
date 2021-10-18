using FluentMigrator;

namespace CPAPP.Infrastucture.Migrations
{
    [Migration(202110181037)]
    public class MigrationCriacaoTabelaEndereco : Migration
    {
        public override void Up()
        {
            Create.Table("Endereco")
                .WithColumn("IdEndereco").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("Uf").AsString().NotNullable()
                .WithColumn("Cep").AsString().NotNullable()
                .WithColumn("Logradouro").AsString().NotNullable()
                .WithColumn("Numero").AsString().NotNullable()
                .WithColumn("Complemento").AsString().NotNullable()
                .WithColumn("Bairro").AsString().NotNullable()
                .WithColumn("Municipio").AsString().NotNullable()
                .WithColumn("IDUsuario").AsString().NotNullable();
            
            // Create.ForeignKey("FK_Usuario_Endereco")
            //     .FromTable("Endereco").ForeignColumn("IDUsuario")
            //     .ToTable("Usuario").PrimaryColumn("IdUsuario");
        }

        public override void Down()
        {
            if (Schema.Table("Endereco").Exists())
                Delete.Table("Endereco");
        }
    }
}