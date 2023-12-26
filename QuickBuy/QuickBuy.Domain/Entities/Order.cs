namespace QuickBuy.Domain.Entities
{
	public class Order : Entity
	{
		public DateTime Date { get; set; }

		public DateTime ExpectedDeliveryDate { get; set; }

		public int Number { get; set; }

		public int UsuarioId { get; set; }

		public int FormPaymentId { get; set; }

		public int AddressId { get; set; }

		public ICollection<OrderedItem>? OrderedItems { get; set; }

		public override void Validate()
		{
			ClearErrors();

			if (OrderedItems == null || OrderedItems.Count == 0)
			{
				AddErrorMessage("Pedido não pode ficar sem itens");
			}

			if (FormPaymentId == 0)
			{
				AddErrorMessage("Não foi informada a forma de pagamento");
			}

			if (AddressId == 0)
			{
				AddErrorMessage("Não foi informado o endereço");
			}
		}
	}
}
