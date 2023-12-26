using FluentMigrator;

namespace QuickBuy.Repository.Data.MIgrations
{
    [Migration(20231225074520)]
    public class CreateTableProducts : Migration
    {
        private readonly string _tableName = "Products";

        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table(_tableName)
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Description").AsString(200).Nullable()
                .WithColumn("Price").AsDecimal().NotNullable();
        }
    }
}