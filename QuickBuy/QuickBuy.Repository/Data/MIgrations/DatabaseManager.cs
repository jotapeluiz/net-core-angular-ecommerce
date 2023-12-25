using Dapper;

namespace QuickBuy.Repository.Data.Migrations
{
    public class DatabaseManager
    {
        private readonly DapperContext _dapperContext;

        public DatabaseManager(DapperContext dapperContext)
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