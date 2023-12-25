using System.Data;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace QuickBuy.Repository.Data
{
	public class DapperContext : IDapperContext
	{
		private readonly string? _connectionString;

		private readonly IConfiguration _configuration;

		public DapperContext(IConfiguration configuration)
		{
			_configuration = configuration;
			_connectionString = _configuration.GetConnectionString("Default");
		}

		public IDbConnection CreateConnection() => new NpgsqlConnection(_connectionString);
	}
}