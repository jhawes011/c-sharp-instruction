using ConsoleLibrary;
namespace Ch14demoInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
			string name = "bob";
            Console.WriteLine("ch14 INHERITANCE");
			MyConsole.PrintL(name.ToString());
			MyConsole.PrintL(name);
			int nbr1 = 11;
			MyConsole.PrintL(nbr1 + nbr1.ToString());

			Movie m1 = new Movie(1, "Test Movie", 2000, "PG", "Test Director");
			Movie m2 = new Movie(2, "Test Movie2", 2002, "PG2", "Test Director2");
			Movie m3 = new Movie(3, "Test Movie", 2000, "PG", "Test Director");
			MyConsole.PrintL(m1.ToString());

			int nbr2 = 11;
				MyConsole.PrintL($"nbr1 == nbr2? {nbr1 == nbr2}");  //true
			MyConsole.PrintL($"m1 == m2? {m1 == m2}");  //false
			MyConsole.PrintL($"m1 == m3? {m1 == m3}");  //true

			string str1 = "abc";
			string str2 = "abc";
			MyConsole.PrintL($"str1 == str2? {str1 == str2}");  //true

			Movie m4 = m3;
			MyConsole.PrintL($"m3 == m4? {m3 == m4}");
			//create instances of product
			//Product p1 = new Product("C#", "Murach's C#", 54.99m);
			//MyConsole.PrintL(p1.GetDisplayText("|"));

			Book b1 = new Book("java", "murach's Java", 49.99m, "Joel Murach");
			MyConsole.PrintL(b1.GetDisplayText("|"));

			Software s1 = new Software("vs", "Visual Studio", 0.0m, "8.0");
			MyConsole.PrintL(s1.GetDisplayText("|"));

			Book b2 = new Book("C#", "Murach's C#", 54.99m, "Mike Murach");
			Book b3 = new Book("andr", "Murach's android", 59.99m, "Joel Murach");

			//put books and software into a list and print a summary
			List<Product> products = new List<Product>();
			products.Add(b1);
			products.Add(b2);
			products.Add(s1);
			products.Add(b3);

			MyConsole.PrintL("-----------Products Summary");
			foreach (Product p in products)
			{
				MyConsole.PrintL(p.GetDisplayText("|"));
			}

			MyConsole.PrintL("Bye===========================================");
		}
    }
}
