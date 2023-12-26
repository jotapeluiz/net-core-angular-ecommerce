using QuickBuy.Domain.Entities.Enums;

namespace QuickBuy.Domain.Entities.Payment
{
	public class FormPayment : Entity
	{
		public string Name { get; set; } = string.Empty;

		public string Description { get; set; } = string.Empty;

		public bool IsBill { get => CheckPaymentType(PaymentType.Bill); }

		public bool IsCreditCard { get => CheckPaymentType(PaymentType.CreditCard); }

		public bool IsUndefined { get => CheckPaymentType(PaymentType.Undefined); }

		public override void Validate()
		{
			ClearErrors();

			if (string.IsNullOrEmpty(Name))
			{
				AddErrorMessage("É preciso informar o nome da forma de pagamento");
			}
		}

		private bool CheckPaymentType(PaymentType paymentType) => Id == (int)paymentType;
	}
}