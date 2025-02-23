using ConsoleLibrary;
namespace Ch15ClassDemoInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintL("Ch15 Interfaces=================================");

			List<Summarizable> things = new List<Summarizable>();

			//create some products
			Product p1 = new Product("c#", "Murach's C#", 53.99m);
			Product p2 = new Product("mysql", "Murach's mysql", 43.99m);
			Product p3 = new Product("andr", "Murach's andr", 59.99m);
			things.Add(p1);
			things.Add(p2);
			things.Add(p3);
			//create some customer
			Customer c1 = new Customer("Adrian", "Johnson", "AJ0001");
			Customer c2 = new Customer("Celina", "Saksith", "CS0020");
			things.Add(c1);
			things.Add(c2);


			//print the results
			// we need a GetSummaryDetails() method on these classes - makings of an interface
			MyConsole.PrintL("Summary");
			foreach (var item in things)
			{
				MyConsole.PrintL($"{item.GetSummeryDetails}");
			}

			//sort list of products
			List<Product> products = new List<Product>();
			products.Add(p1);
			products.Add(p2);
			products.Add(p3);

			MyConsole.PrintL("===All Products===:");
			foreach (Product p in products)
			{
				MyConsole.PrintL(p.GetSummeryDetails());

			}

			//sort products
			products.Sort();
			MyConsole.PrintL("===Sorted Products===:");
			foreach (Product p in products)
			{
				MyConsole.PrintL(p.GetSummeryDetails());

			}



			MyConsole.PrintL("Goodbye=================================");
		}
	}
}
