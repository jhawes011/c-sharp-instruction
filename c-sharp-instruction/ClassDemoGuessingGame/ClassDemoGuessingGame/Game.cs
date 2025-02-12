using ConsoleLibrary;

namespace ClassDemoGuessingGame
{
	public class Game
	{
		 public void DisplayGuessMessage(int count, int diff)
		{
			if (diff == 0)
			{
				DisplayWinnerMessage(count);
			}
			else if (diff < -10)
			{
				MyConsole.PrintL("Way too low! Guess again.");
			}
			else if (diff < 0)
			{
				MyConsole.PrintL("Too low! Guess again.");
			}
			else if (diff > 10)
			{
				MyConsole.PrintL("Way too high! Guess again.");
			}
			else if (diff > 0)
			{
				MyConsole.PrintL("Too high! Guess again.");
			}
		}

		private void DisplayWinnerMessage(int count)
		{
			MyConsole.PrintL("You got it in " + count + " tries.");
			if (count <= 3)
			{
				MyConsole.PrintL("Great work! You are a mathematical wizard.");
			}
			else if (count <= 7)
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
