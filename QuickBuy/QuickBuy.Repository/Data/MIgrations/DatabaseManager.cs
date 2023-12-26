using Dapper;

namespace QuickBuy.Repository.Data.Migrations
{
    public class DatabaseManager
    {
        private readonly IDapperContext _dapperContext;

        public DatabaseManager(IDapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public void CreateDatabase(string name)
        {
            var query = "SELECT COUNT(*) FROM pg_catalog.pg_database WHERE LOWER(datname) = LOWER(@name)";

            using var connection = _dapperContext.CreateMasterConnection();
            var records = connection.QueryFirstOrDefault<int>(query, new { name });

            if (records == 0)
            {
                connection.Execute($"CREATE DATABASE {name}");
            }
        }
    }
}