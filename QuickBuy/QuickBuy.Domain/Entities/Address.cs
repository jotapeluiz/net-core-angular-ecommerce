namespace QuickBuy.Domain.Entities
{
    public class Address : Entity
    {
        public string ZipCode { get; set; } = string.Empty;

		public string City { get; set; } = string.Empty;

		public string State { get; set; } = string.Empty;

		public string Street { get; set; } = string.Empty;

		public int Number { get; set; }

        public override void Validate()
        {
            ClearErrors();

            if (string.IsNullOrEmpty(ZipCode))
            {
                AddErrorMessage("É preciso informar o CEP");
            }

            if (string.IsNullOrEmpty(City))
            {
                AddErrorMessage("É preciso informar a cidade");
            }

            if (string.IsNullOrEmpty(State))
            {
                AddErrorMessage("É preciso informar o estado");
            }

            if (string.IsNullOrEmpty(Street))
            {
                AddErrorMessage("É preciso informar a rua");
            }
        }
    }
}