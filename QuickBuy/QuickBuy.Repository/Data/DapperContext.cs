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
			=> CreateConnection(_configuration.GetConnectionString("DatabaseApp") ?? string.Empty);

		public IDbConnection CreateMasterConnection()
			=> CreateConnection(_configuration.GetConnectionString("Master") ?? string.Empty);

		private static NpgsqlConnection CreateConnection(string connectionName) => new(connectionName);
	}
}