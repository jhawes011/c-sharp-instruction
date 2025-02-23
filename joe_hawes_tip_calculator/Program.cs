namespace joe_hawes_tip_calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PrintL("Welcome to the Tip Calculator \n -------------------------------------------------");
			string choice = "y";
			while (choice.ToLower() == "y")
			{
				double totalBill = GetTotalBill();

				double tipAmount = CalcTipAmount(totalBill);
				double totalAmount = CalculateTotalAmount(totalBill, tipAmount);



				PrintL("15%");
				PrintL($"Tip Amount:   ${Math.Round(tipAmount * 0.15, 2):0.00}");
				PrintL($"Total Amount: ${Math.Round(totalBill + (totalBill * 0.15), 2):0.00}");
				Console.WriteLine();

				PrintL("20%");
				PrintL($"Tip Amount:   ${Math.Round(totalBill * 0.20, 2):0.00}");
				PrintL($"Total Amount: ${Math.Round(totalBill + (totalBill * 0.20), 2):0.00}");
				Console.WriteLine();

				PrintL("25%");
				PrintL($"Tip Amount:   ${Math.Round(totalBill * 0.25, 2):0.00}");
				PrintL($"Total Amount: ${Math.Round(totalBill + (totalBill * 0.25), 2):0.00}");
				Console.WriteLine();

				Print("Would you like to calculate another tip? (y/n): ");
				choice = Console.ReadLine();
			}
			Console.WriteLine();
			PrintL("Goodbye --------------------------------------------");
		}
		static double CalculateTotalAmount(double totalBill, double tipAmount)
		{
			return totalBill + tipAmount;
		}
		static double CalcTipAmount(double totalBill)
		{
			double tipAmount = 0.15 * totalBill;

			return tipAmount;
		}

		static double GetTotalBill()
		{
			double totalBill;
			try
			{Console.WriteLine();
				Print("Cost of Meal: ");
				string input = Console.ReadLine();
				Console.WriteLine();
				if (double.TryParse(input, out totalBill))
				{
					break;
				}
				else
				{
					PrintL("Invalid input. Please enter a valid number.");
				}
				
			}
			catch (Exception e)
			{
				PrintL("Invalid input. Please enter a valid number.");
				totalBill = GetTotalBill();
			}
			
			return totalBill;
		}
		static void PrintL(string msg)
		{
			Console.WriteLine(msg);
		}
		static void Print(string msg)
		{
			Console.Write(msg);
		}
	}
}
