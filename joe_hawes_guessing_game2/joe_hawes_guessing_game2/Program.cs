using ConsoleLibrary;

namespace joe_hawes_guessing_game2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyConsole.PrintL("Welcome to the Guess the Number Game");
			MyConsole.PrintL(new string('+', 50));

			while (true)
			{
				Game game = new Game();
				game.Play();
				string playAgain = Game.GetString("Try again? (y/n): ", new string[] { "y", "n" });
				if (playAgain == "n")
				{
					MyConsole.PrintL("Bye - Come back soon!");
					break;
				}
			}




		}
	}
}
