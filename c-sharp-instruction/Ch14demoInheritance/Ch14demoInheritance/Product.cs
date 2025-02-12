

namespace Ch14demoInheritance
{
	public abstract class Product // abstract say product can no longer be substantiated
	{
		public string Code { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public Product() { } 
		public Product(string Code, string Description, decimal Price) 
		{
			this.Code = Code;
			this.Description = Description;
			this.Price = Price;
		}
		public virtual string GetDisplayText(string sep)  // sep=seperator
		{
			return $"{Code}{sep}{Price:c}{sep}{Description}";//price:c = price.tostring"c"
		}


	}
}
