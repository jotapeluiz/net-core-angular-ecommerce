using FluentMigrator;

namespace QuickBuy.Repository.Data.MIgrations
{
    [Migration(20231225105117)]
    public class CreateTableAdresses : Migration
    {
        private readonly string _tableName = "Address";

        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table(_tableName)
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey()
                .WithColumn("State").AsString().NotNullable()
                .WithColumn("City").AsString().NotNullable()
                .WithColumn("ZipCode").AsString(8).NotNullable()
                .WithColumn("Number").AsInt32().NotNullable();
        }
    }
}