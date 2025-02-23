
using ConsoleLibrary;

namespace Ch15ClassDemoInterfaces
{
	internal class Product : Summarizable, IComparable<Product>
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

		public int CompareTo(Product? other) // ? says if null, jusst ignore it
		{
			return this.Price.CompareTo(other?.Price);  //could also compare Code or Description
		}
	}
}
