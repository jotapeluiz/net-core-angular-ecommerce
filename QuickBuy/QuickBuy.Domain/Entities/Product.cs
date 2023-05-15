namespace QuickBuy.Domain.Entities
{
	public class Product : Entity
	{
		public int Id { get; set; }
		public string Name
		{
			get { return Name ?? string.Empty; }
			set { Name = value; }
		}
		public string Description
		{
			get { return Description ?? string.Empty; }
			set { Description = value; }
		}
		public decimal Price { get; set; }

		public override void Validate()
		{
			if (string.IsNullOrEmpty(Name))
			{
				AddErrorMessage("Nome do Produto precisa ser informado");
			}

			if (Price == 0)
			{
				AddErrorMessage("Preço do Produto precisa ser informado");
			}
		}
	}
}
