namespace joe_hawes_batting_statistics
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Batting Statistics \n ---------------------------------------");
			
			string choice = "y";
			while (choice.ToLower() == "y")
			{
				Console.Write("Enter the number of times at bat: ");
				int atBats = Convert.ToInt32(Console.ReadLine());
				if (atBats > 0 && atBats < 30)
				{

					Console.WriteLine();
					Console.WriteLine("0=out, 1=single, 2=double, 3=triple, 4=home run");
					Console.WriteLine();
				List<int> atBatResults = new List<int>(new int[atBats]);

				for (int i = 0; i < atBats; i++)
				{
					Console.Write("Result for at-bat " + (i + 1) + ": ");
					atBatResults[i] = Convert.ToInt32(Console.ReadLine());
				}
				Console.WriteLine();

				double battingAverage = atBatResults.Count(result => result > 0) / (double)atBats;
				Console.Write("Batting Average: " + battingAverage.ToString("F3"));
				Console.WriteLine();

				double sluggingPercent = atBatResults.Sum() / (double)atBats;
				Console.WriteLine("Slugging Percent: " + sluggingPercent.ToString("F3"));
				Console.WriteLine();

				Console.WriteLine("Do you want to enter another player? (y/n): ");
				choice = Console.ReadLine();
				}
				else
				{
					Console.WriteLine("Please enter a number between 1 and 30");
					Console.WriteLine();
					continue;
				}
				
			}
			

			Console.WriteLine("GOODBYE ------------------------------------------- ");
		}
	}
}
