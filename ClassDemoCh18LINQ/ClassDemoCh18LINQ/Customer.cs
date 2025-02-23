namespace ClassDemoCh18LINQ
{
	public class Customer
	{
		public int CustomerID { get; set; }
		public string Name { get; set; } = "";
	
		public override string ToString()
		{
			return $"Invoice: ({CustomerID})|{Name}";
		}






	}
}