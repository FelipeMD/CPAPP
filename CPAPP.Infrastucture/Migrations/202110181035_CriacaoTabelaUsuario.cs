using FluentMigrator;

namespace CPAPP.Infrastucture.Migrations
{
    [Migration(202110181035)]
    public class MigrationCriacaoTabelaUsuario : Migration
    {
        public override void Up()
        {
            Create.Table("Usuario")
                .WithColumn("IDUsuario").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("Nome").AsString().NotNullable()
                .WithColumn("Cpf").AsString().NotNullable()
                .WithColumn("DTNascimento").AsDateTime().NotNullable()
                .WithColumn("IDEndereco").AsInt32().NotNullable();

            Create.ForeignKey("IDEndereco")
                .FromTable("Endereco").ForeignColumn("IDEndereco")
                .ToTable("Usuario").PrimaryColumn("IDEndereco");
        }

        public override void Down()
        {
            if (Schema.Table("Usuario").Exists())
                Delete.Table("Usuario");
        }
    }
}