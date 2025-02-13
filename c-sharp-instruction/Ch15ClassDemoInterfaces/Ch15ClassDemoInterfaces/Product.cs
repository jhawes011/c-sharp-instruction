
using ConsoleLibrary;

namespace Ch15ClassDemoInterfaces
{
	internal class Product : Summarizable
	{
		public string Code { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }

		public Product(string code, string description, decimal price)
		{
			this.Code = code;
			this.Description = description;
			this.Price = price;
		}

		public string GetSummeryDetails()
		{
			string summary = $"Product: ({Code}) {Description} @ {Price}";
			return summary;
		}
	}
}
