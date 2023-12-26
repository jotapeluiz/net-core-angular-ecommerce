namespace QuickBuy.Domain.Entities
{
	public class Product : Entity
	{
		public int Id { get; set; }

		public string Name { get; set; } = string.Empty;

		public string Description { get; set; } = string.Empty;

		public decimal Price { get; set; }

		public override void Validate()
		{
			ClearErrors();

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
