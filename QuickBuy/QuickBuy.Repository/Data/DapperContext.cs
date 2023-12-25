using System.Data;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace QuickBuy.Repository.Data
{
	public class DapperContext : IDapperContext
	{
		private readonly IConfiguration _configuration;

		public DapperContext(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public IDbConnection CreateDatabaseConnection()
			=> CreateConnection(_configuration.GetConnectionString("DatabaseApp"));

		public IDbConnection CreateMasterConnection()
			=> CreateConnection(_configuration.GetConnectionString("Master"));

		private IDbConnection CreateConnection(string connectionName) => new NpgsqlConnection(connectionName);
	}
}