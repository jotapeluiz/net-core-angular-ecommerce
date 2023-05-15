using QuickBuy.Domain.Contracts;

namespace QuickBuy.Repository.Repositories
{
	public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
	{
		public BaseRepository()
		{

		}

		public void Delete(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public TEntity Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<TEntity> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Insert(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public void Update(TEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}