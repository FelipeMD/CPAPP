using FluentMigrator;
using Microsoft.EntityFrameworkCore.Migrations;
using Migration = FluentMigrator.Migration;

namespace CPAPP.Infrastucture.Migrations
{
    [FluentMigrator.Migration(202110181041)]
    public class MigrationCriacaoTabelaProduto : Migration
    {
        public override void Up()
        {
            Create.Table("Produtos")
                .WithColumn("ID").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("Nome").AsString().NotNullable()
                .WithColumn("CodigoProduto").AsInt64().NotNullable();
        }

        public override void Down()
        {
            if (Schema.Table("Produto").Exists())
                Delete.Table("Produto");
        }
    }
}