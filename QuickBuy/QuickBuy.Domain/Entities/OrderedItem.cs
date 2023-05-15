namespace QuickBuy.Domain.Entities
{
	public class OrderedItem : Entity
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int Amount { get; set; }

		public override void Validate()
		{
			if (ProductId == 0)
			{
				AddErrorMessage("Não foi indentificada qual a referência do produto");
			}

			if (Amount == 0)
			{
				AddErrorMessage("Quantidade não foi informada");
			}
		}
	}
}