namespace QuickBuy.Domain.Entities
{
	public class User : Entity
	{
		public int Id { get; set; }
		public string Email
		{
			get { return Email ?? string.Empty; }
			set { Email = value; }
		}
		public string Password
		{
			get { return Password ?? string.Empty; }
			set { Password = value; }
		}
		public string Name
		{
			get { return Name ?? string.Empty; }
			set { Name = value; }
		}
		public string LastName
		{
			get { return LastName ?? string.Empty; }
			set { LastName = value; }
		}
		public ICollection<Order>? Orders { get; set; }

		public override void Validate()
		{
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
