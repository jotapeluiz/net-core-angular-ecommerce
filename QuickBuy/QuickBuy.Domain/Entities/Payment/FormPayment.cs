using QuickBuy.Domain.Entities.Enums;

namespace QuickBuy.Domain.Entities.Payment
{
	public class FormPayment : Entity
	{
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
		public bool IsBill
		{
			get { return Id == (int)PaymentType.Bill; }
		}
		public bool IsCreditCard
		{
			get { return Id == (int)PaymentType.CreditCard; }
		}
		public bool IsUndefined
		{
			get { return Id == (int)PaymentType.Undefined; }
		}
		public override void Validate()
		{
			throw new NotImplementedException();
		}
	}
}