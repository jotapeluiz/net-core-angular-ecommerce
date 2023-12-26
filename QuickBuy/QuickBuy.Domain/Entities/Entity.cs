namespace QuickBuy.Domain.Entities
{
	public abstract class Entity
	{
		private List<string> Errors { get; set; }

		public Entity()
		{
			Errors = [];
		}

		protected void ClearErrors() => Errors.Clear();

		protected void AddErrorMessage(string message) => Errors.Add(message);

		protected bool IsValid { get => Errors.Count == 0; }

		public abstract void Validate();
	}
}
