using System.Data;

namespace QuickBuy.Repository.Data
{
	public class DapperContext : IDapperContext
	{
		//private readonly IConfiguration _iConfiguration;
		private readonly string _connectionString;

		public DapperContext()
		{
			_connectionString = "";
		}

		public IDbConnection CreateConnection()
		{
			throw new NotImplementedException();
		}
	}
}