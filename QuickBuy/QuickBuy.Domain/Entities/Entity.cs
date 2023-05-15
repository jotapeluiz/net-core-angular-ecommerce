namespace QuickBuy.Domain.Entities
{
	public abstract class Entity
	{
		private List<string>? _errors { get; set; }
		private List<string> Errors
		{
			get { return _errors ?? (_errors = new List<string>()); }
		}

		protected void ClearErrors()
		{
			Errors.Clear();
		}
		protected void AddErrorMessage(string message)
		{
			Errors.Add(message);
		}
		public abstract void Validate();
		protected bool IsValid
		{
			get { return !Errors.Any(); }
		}
	}
}
