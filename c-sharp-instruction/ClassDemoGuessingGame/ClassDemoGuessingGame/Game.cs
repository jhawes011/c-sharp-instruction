using ConsoleLibrary;

namespace ClassDemoGuessingGame
{
	public class Game
	{
		public int Count { get; set; }
		public int Diff { get; set; }
		 public void DisplayGuessMessage()
		{
			if (Diff == 0)
			{
				DisplayWinnerMessage();
			}
			else if (Diff < -10)
			{
				MyConsole.PrintL("Way too low! Guess again.");
			}
			else if (Diff < 0)
			{
				MyConsole.PrintL("Too low! Guess again.");
			}
			else if (Diff > 10)
			{
				MyConsole.PrintL("Way too high! Guess again.");
			}
			else if (Diff > 0)
			{
				MyConsole.PrintL("Too high! Guess again.");
			}
		}

		private void DisplayWinnerMessage()
		{
			MyConsole.PrintL("You got it in " + Count + " tries.");
			if (Count <= 3)
			{
				MyConsole.PrintL("Great work! You are a mathematical wizard.");
			}
			else if (Count <= 7)
			{
				MyConsole.PrintL("Not too bad! You've got some potential.");
			}
			else
			{
				MyConsole.PrintL("What took you so long? Maybe you should take some lessons.");
			}
		}



	}
}
