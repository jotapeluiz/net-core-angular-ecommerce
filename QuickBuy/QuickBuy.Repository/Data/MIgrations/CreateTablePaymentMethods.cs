using FluentMigrator;

namespace QuickBuy.Repository.Data.MIgrations
{
    [Migration(20231225110731)]
    public class CreateTablePaymentMethods : Migration
    {
        private readonly string _tableName = "PaymentMethods";

        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table(_tableName)
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey()
                .WithColumn("Name").AsString().NotNullable().Unique()
                .WithColumn("Description").AsString().Nullable();
        }
    }
}