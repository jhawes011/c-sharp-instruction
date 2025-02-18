using ConsoleLibrary;
namespace joe_hawes_hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintL("MyConsole.Print($\"\\n==================== Welcome to the Hangman game! ====================");

			
			


			MyConsole.PrintL("\n==================== Thanks for playing! =========================");
        }
		public static string GetHangmanImage()
		{
			
			return hangmanImage;
		}
		public int incorrectGuesses;
		public static string GetHangmanImage(int stage)
		{
			
			switch (stage)
			{
				case 0:
					return
						"-----  \r\n" +
						"|   |  \r\n" +
						"|   O  \r\n" +
						"|  /|\\\r\n" +
						"|  / \\\r\n" +
						"|\r\n-------\r\n";
				case 1:
					return
						"-----  \r\n" +
						"|   |  \r\n" +
						"|   O  \r\n" +
						"|  /|\\\r\n" +
						"|    \\\r\n" +
						"|\r\n-------\r\n";
				case 2:
					return
						"-----  \r\n" +
						"|   |  \r\n" +
						"|   O  \r\n" +
						"|  /|\\\r\n" +
						"|      \r\n" +
						"|\r\n-------\r\n";
				case 3:
					return
						"-----  \r\n" +
						"|   |  \r\n" +
						"|   O  \r\n" +
						"|   |\\\r\n" +
						"|      \r\n" +
						"|\r\n-------\r\n";
				case 4:
					return
						"-----  \r\n" +
						"|   |  \r\n" +
						"|   O  \r\n" +
						"|   |  \r\n" +
						"|      \r\n" +
						"|\r\n-------\r\n";
				case 5:
					return
						"-----   \r\n" +
						"|   |   \r\n" +
						"|   O   \r\n" +
						"|       \r\n" +
						"|       \r\n" +
						"|\r\n-------\r\n";
				case 6:
					return
						"-----  \r\n" +
						"|   D  \r\n" +
						"|   E  \r\n" +
						"|   A  \r\n" +
						"|   D  \r\n" +
						"|\r\n-------\r\n";
				default:
					return string.Empty;
			}
			// select image, each with int variable
		}
}
