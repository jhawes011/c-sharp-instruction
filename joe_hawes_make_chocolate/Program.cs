namespace joe_hawes_make_chocolate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcoming to the chocolate making calculator \n ------------------------------------------------------------");
			string choice = "y";
			while (choice.ToLower() == "y")
			{
				Console.Write("Enter goal: ");
				if (int.TryParse(Console.ReadLine(), out int goal))
				{


					Console.Write("Enter number of big bars available: ");
					int.TryParse(Console.ReadLine(), out int bigBarsAvailable);
					Console.Write("Enter number of small bars available: ");
					int.TryParse(Console.ReadLine(), out int smallBarsAvailable);
					Console.WriteLine();

					int bigBarKilos = bigBarsAvailable * 5;
					int bigBarsNeeded = goal / 5;
					int remainderSmallBars = goal - bigBarKilos;
					int smallBarsNeeded = remainderSmallBars;
					if (smallBarsAvailable >= smallBarsNeeded)
					{
						
						if (remainderSmallBars > 0)
						{
							smallBarsNeeded = remainderSmallBars;
						}
						else
						{
							smallBarsNeeded = 0;
						}
						
						Console.WriteLine($"You will need {smallBarsNeeded} small bar(s) and {bigBarsNeeded} big bar(s) to get {goal} kilos of chocolate.\n");
						
						Console.WriteLine("Would you like to run another calculation? y/n");
						choice = Console.ReadLine();
					}
					else
					{

						Console.WriteLine($"Invalid input. Manufacturing {goal} kilos is not possible with the quantity of chocolate available.\n");
						
						Console.WriteLine("Would you like to run another calculation? y/n");
						choice = Console.ReadLine();
					}

				}
				else
				{
					Console.WriteLine("Invalid input. Please enter a valid integer.");
					return;
				}
			}
			Console.WriteLine("Goodbye----------------------------------------------");
			
		}


	}
}
