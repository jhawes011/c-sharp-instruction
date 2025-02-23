namespace joe_hawes_factorial_calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Print("Welcome to the Factorial Calculator \n ");
			string choice = "y";
			while (choice.ToLower() == "y")
			{
				long theNumber = GetLong("Enter an integer that's greater than 0 and less than 1000: ", 1, 1000);
				//long theFactorial = 1;
				//for (int i = 1; i <= theNumber; i++)
				//{
				//	//theFactorial = theFactorial * i;  or write as---->>
				//	theFactorial *= i;
				//}
				long theFactorial = 1;
				for (int i = 1; theFactorial > 0; i++)
				{
					theFactorial *= i;
					Print("i: " + i + " factorial: " + theFactorial);
				}
					Print("The factorial of " + theNumber + " is " + theFactorial);
				Print("----------------------------------------------------");
				Print("Continue? (y/n): ");
				choice = Console.ReadLine();
			}

			Print("Goodbye----------------------------------------------------");
		}
		private static long GetLong(string prompt, long min, long max)
		{
			long result = 0;
			bool isValid = false;
			while (!isValid)
			{
				Console.Write(prompt);
				if (!long.TryParse(Console.ReadLine(), out result))
				{
					Print("Error! Must be whole number. Try again.");
					continue;
				}
				if (result < min || result > max)
				{
					Print("Error! Number must be greater than 0 and less than 10.(" + min + "_" + max + ") Try again.");
				}
				else
				{
					isValid = true;
				}
			}
			return result;
		}
		static void Print(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}