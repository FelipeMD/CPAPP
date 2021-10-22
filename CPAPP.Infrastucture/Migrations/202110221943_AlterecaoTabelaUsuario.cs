using FluentMigrator;

namespace CPAPP.Infrastucture.Migrations
{
    [Migration(202110221943)]
    public class MigrationAlterecaoTabelaUsuario : Migration
    {
        public override void Up()
        {
            Alter.Table("Usuario")
                .AddColumn("IDEndereco").AsInt32().NotNullable();
            
            Create.ForeignKey()
                .FromTable("Usuario").ForeignColumn("IDEndereco")
                .ToTable("Endereco").PrimaryColumn("ID");
        }

        public override void Down()
        {
            throw new System.NotImplementedException();
        }
    }
}