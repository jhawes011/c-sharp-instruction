
using ConsoleLibrary;

namespace joe_hawes_pig_dice
{
    public class Program
    {
		public void Start()
		{
			Console.WriteLine("Welcome to Pig Dice Game!");
			Console.WriteLine("Try to roll as high as possible, but beware of rolling a 1!");

			PigGame game = new PigGame();

			while (true)
			{
				Console.Write("# of times to play?: ");
				if (!int.TryParse(Console.ReadLine(), out int numGames))
				{
					Console.WriteLine("Please enter a valid number.");
					continue;
				}

				Console.WriteLine("Here we go….");
				game.PlayGames(numGames);
				game.ShowResults();

				Console.Write("Would you like to play again? (Y/N): ");
				string again = Console.ReadLine().Trim().ToLower();
				if (again != "y")
				{
					Console.WriteLine("Thanks for playing! Bye!");
					break;
				}
			}
		}

		static void Main()
		{
			Program controller = new Program();
			controller.Start();
		}
	}
}
