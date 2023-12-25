using System.Data;
using Dapper.Contrib.Extensions;
using QuickBuy.Domain.Contracts;
using QuickBuy.Repository.Data;

namespace QuickBuy.Repository.Repositories
{
	public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
	{
		private readonly IDbConnection _dbConnection;

		private readonly IDapperContext _dapperContext;

		public BaseRepository(IDapperContext dapperContext)
		{
			_dapperContext = dapperContext;
			_dbConnection = _dapperContext.CreateDatabaseConnection();
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (_dbConnection != null)
            {
                _dbConnection.Dispose();
                _dbConnection.Close();
            }
        }
    }

    public TEntity Get(int id) => _dbConnection.Get<TEntity>(id);

		public IEnumerable<TEntity> GetAll() => _dbConnection.GetAll<TEntity>();

		public void Insert(TEntity entity) => _dbConnection.Insert(entity);

		public void Update(TEntity entity) => _dbConnection.Update(entity);

		public void Delete(TEntity entity) => _dbConnection.Delete(entity);
	}
}