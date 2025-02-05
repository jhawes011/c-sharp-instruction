namespace joe_hawes_table_of_powers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Print("Hello, Welcome to the Table of Powers");

			Print("");
			string choice = "y";
			while (choice.ToLower() == "y")
			{
				try
				{
					Console.Write("Please enter an integer:  ");
					int userInput = int.Parse(Console.ReadLine());

					for (int i = 1; i <= userInput; i++)
					{
						Console.WriteLine($"{i,-8}{i * i,-10}{i * i * i}");
					}

					Console.WriteLine("Would you like to continue? (y/n)");
					choice = Console.ReadLine();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error: " + ex.Message);
					Console.WriteLine("Please enter a valid integer");
				}
			}

			Print("Bye---------------------------------------------------------");
		}

		static void Print(string msg, string endLine = "\n")
		{
			Console.Write(msg + endLine);
		}
	}
	}

