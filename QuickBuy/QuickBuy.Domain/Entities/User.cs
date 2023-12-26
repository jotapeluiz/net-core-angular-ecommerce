namespace QuickBuy.Domain.Entities
{
	public class User : Entity
	{
		public int Id { get; set; }

		public string Email { get; set; } = string.Empty;

		public string Password { get; set; } = string.Empty;

		public string Name { get; set; } = string.Empty;

		public string LastName { get; set; } = string.Empty;

		public ICollection<Order>? Orders { get; set; }

		public override void Validate()
		{
			ClearErrors();

			if (string.IsNullOrEmpty(Email))
			{
				AddErrorMessage("Email não foi informado");
			}

			if (string.IsNullOrEmpty(Password))
			{
				AddErrorMessage("Senha não foi informada");
			}
		}
	}
}
