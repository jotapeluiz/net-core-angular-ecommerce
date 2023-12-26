using FluentMigrator;

namespace QuickBuy.Repository.Data.MIgrations
{
    [Migration(20231225073002)]
    public class CreateTableUsers : Migration
    {
        private readonly string _tableName = "Users";

        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table(_tableName)
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("LastName").AsString(100).NotNullable()
                .WithColumn("Email").AsString(100).NotNullable().Unique()
                .WithColumn("Password").AsString(20).NotNullable().Unique();
        }
    }
}