using QuickBuy.Domain.Entities.Payment;

namespace QuickBuy.Domain.Entities
{
	public class Order : Entity
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public int UsuarioId { get; set; }
		public DateTime ExpectedDeliveryDate { get; set; }
		public string ZipCode
		{
			get { return ZipCode ?? string.Empty; }
			set { ZipCode = value; }
		}
		public string City
		{
			get { return City ?? string.Empty; }
			set { City = value; }
		}
		public string State
		{
			get { return State ?? string.Empty; }
			set { State = value; }
		}
		public string Address
		{
			get { return Address ?? string.Empty; }
			set { Address = value; }
		}
		public int Number { get; set; }
		public int FormPaymentId { get; set; }
		public FormPayment? FormPayment { get; set; }
		public ICollection<OrderedItem>? OrderedItems { get; set; }

		public override void Validate()
		{
			ClearErrors();

			if (OrderedItems == null || !OrderedItems.Any())
			{
				AddErrorMessage("Pedido não pode ficar sem itens");
			}

			if (string.IsNullOrEmpty(ZipCode))
			{
				AddErrorMessage("CEP precisa estar preenchido");
			}

			if (FormPaymentId == 0)
			{
				AddErrorMessage("Não foi informada a forma de pagamento");
			}
		}
	}
}
