namespace QuickBuy.Domain.Contracts
{
	public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
	{
		TEntity Get(int id);

		IEnumerable<TEntity> GetAll();

		void Insert(TEntity entity);

		void Update(TEntity entity);

		void Delete(TEntity entity);
	}
}