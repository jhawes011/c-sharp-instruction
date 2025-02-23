using System.Collections.Generic;
using ConsoleLibrary;

namespace Ch17ClassDemoProductManager
{
    internal class Program
    {
		static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {	
			

            Console.WriteLine("ch17 Demo for reading files");

			//program that provides CRUD features for products
			//Products will be stored in a txt file named products.txt

			//load products from file (into new list)
			products = ProductDB.GetProducts();
			//while command != 0
			//prompt command
			//perform an action: list or add product(S)
			int command = 9;
			while (command != 0)
			{
				DisplayMenu();
				command = MyConsole.PromptInt("Command: ");
				switch (command)
				{
					case 1:
						ListProducts();
						break;
					case 2:
						AddProduct();
						break;
					case 3:
						RemoveProduct();
						break;
					case 0:
						break;
					default:
						MyConsole.PrintL("Invalid Command. Try again.");
						break;
				}
			}





			Console.WriteLine("ch17 Demo for reading files");
		}

		private static void AddProduct()
		{
			MyConsole.PrintL("\nAdd Products:");
			MyConsole.PrintL("====================================");
			string code = MyConsole.PromptString("Code: ");
			string desc = MyConsole.PromptString("Description: ");
			decimal price = MyConsole.PromptDecimal("Price: ");
			Product p = new Product(code, desc, price);
			products.Add(p);
			ProductDB.SaveProducts(products);
			MyConsole.PrintL("+++++Products Added+++++");
		}

		private static void ListProducts()
		{
			MyConsole.PrintL("\nList Products:");
			MyConsole.PrintL("====================================");
			//could add check to see if list is not empty
			foreach (Product p in products)
			{
				MyConsole.PrintL(p.ToString());
			}
		}
		static void RemoveProduct()
		{
			MyConsole.PrintL("Enter product code to delete: ");
			string code = MyConsole.PromptString("Code: ");
			Product productToRemove = products.Find(p => p.Code == code);
			
			if (productToRemove != null)
			{
				products.Remove(productToRemove);
				ProductDB.SaveProducts(products);
				MyConsole.PrintL($"Product ({productToRemove}) successfully removed");
			}
			else
			{
				MyConsole.PrintL("No product listed by that code. Try again sucka!");
					return;
			}
			
		}

		static void DisplayMenu()
			{
				MyConsole.PrintL("\nCOMMAND MENU:");
				MyConsole.PrintL("1) List Products");
				MyConsole.PrintL("2) Add Product");
				MyConsole.PrintL("3) Remove Product");
				MyConsole.PrintL("0) Exit");
			}
    }
}
