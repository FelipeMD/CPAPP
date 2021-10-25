using FluentMigrator;

namespace CPAPP.Infrastucture.Migrations
{
    [Migration(202110181035)]
    public class MigrationCriacaoTabelaUsuario : Migration
    {
        public override void Up()
        {
            Create.Table("Usuarios")
                .WithColumn("ID").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("Nome").AsString().NotNullable()
                .WithColumn("Cpf").AsString().NotNullable()
                .WithColumn("Nascimento").AsDateTime().NotNullable()
                .WithColumn("Sexo").AsString().NotNullable()
                .WithColumn("UF").AsString().NotNullable()
                .WithColumn("CEP").AsString().NotNullable();
        }

        public override void Down()
        {
            if (Schema.Table("Usuario").Exists())
                Delete.Table("Usuario");
        }
    }
}