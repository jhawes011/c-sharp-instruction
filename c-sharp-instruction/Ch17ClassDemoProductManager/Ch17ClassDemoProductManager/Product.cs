using ConsoleLibrary;

namespace Ch17ClassDemoProductManager
{
	internal class Product
	{
		public string Code { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public Product(string code, string description, decimal Price)
		{
			this.Code = code;
			this.Description = description;
			this.Price = Price;
		}

		public override string ToString()
		{
			return $"Product: ({Code}) - {Description} @ {Price:c}";
		}

	}
}
