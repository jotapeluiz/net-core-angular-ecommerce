using System.Data;

namespace QuickBuy.Repository.Data
{
	public interface IDapperContext
	{
		IDbConnection CreateDatabaseConnection();
	}
}