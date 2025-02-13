using ConsoleLibrary;
namespace Ch15ClassDemoInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintL("Ch15 Interfaces=================================");
			
			Product p1 = new Product("c#", "Murach's C#", 53.99m);
			Product p2 = new Product("mysql", "Murach's mysql", 43.99m);
			Product p3 = new Product("andr", "Murach's andr", 59.99m);

			Customer c1 = new Customer("Adrian", "Johnson", "AJ0001");
			Customer c2 = new Customer("Celina", "Saksith", "CS0020");
			

			MyConsole.PrintL("Goodbye=================================");
		}
	}
}
