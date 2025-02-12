using ConsoleLibrary;

namespace ClassDemoGuessingGame
{
	internal class Program
	{
		// constants
		private const int MIN_VAL = 1;
		private const int MAX_VAL = 100;
		static void Main(string[] args)
		{
			MyConsole.PrintL("Welcome to the Guessing Game!");
			MyConsole.PrintL("+++++++++++++++++++++++++++++");
			MyConsole.PrintL("");

			string choice = "y";
			Random rand = new Random();
			while (choice == "y")
			{
				// play game
				int theNumber = rand.Next(MIN_VAL, MAX_VAL + 1);
				int count = 0;
				int guess = 0;
				MyConsole.PrintL("I'm thinking of a number from " + MIN_VAL + " to " + MAX_VAL + ".\nTry to guess it.\n");
				
				// play game until guess == theNumber
				Game game = new Game();
				while (guess != theNumber)
				{
					guess = MyConsole.PromptInt("Enter number: ");
					count++;
					int diff = guess - theNumber;
					game.Diff = diff;
					game.Count = count;
					game.DisplayGuessMessage();
				}
				// prompt choice
				MyConsole.PrintL("");
				choice = MyConsole.PromptReqString("Try again? (y/n) ", "y", "n");
				MyConsole.PrintL("");
			}

			MyConsole.PrintL("Bye - come back again soon!");
		}
	}
}
