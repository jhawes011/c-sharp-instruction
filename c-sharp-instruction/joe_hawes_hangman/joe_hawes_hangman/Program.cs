using ConsoleLibrary;
namespace joe_hawes_hangman
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyConsole.PrintL("MyConsole.Print($\"\\n==================== Welcome to the Hangman game! ====================\n");
			
			MyConsole.PrintL("\n==================== Thanks for playing! =========================");
		}

		public static string GetHangmanImage(int incorrectGuesses)
		{
			switch (incorrectGuesses)
			{
				case 6:
					return
						"""
						_____ 
						|   | D
						|   O  E
						|  /|\  A
						|  / \   D
						|______   
						""";
				case 5:
					return
						"""
						_____ 
						|   | 
						|   O 
						|  /|\
						|  / 
						|______
						""";
				case 4:
					return
						"""
						_____ 
						|   | 
						|   O 
						|  /|\
						|  
						|______
						""";
				case 3:
					return
						"""
						_____ 
						|   | 
						|   O 
						|  /|
						|  
						|______
						""";
				case 2:
					return
						"""
						_____ 
						|   | 
						|   O 
						|   |
						|  
						|______
						""";
				case 1:
					return
						"""
						_____ 
						|   | 
						|   O 
						|  
						|  
						|______
						""";
				case 0:
					return
						"""
						_____ 
						|   | 
						|
						|
						|
						|______
						""";
				default:
					return string.Empty;
			}

		}
		private static void HangmanImageTest()
		{
			Console.WriteLine("Testing DisplayHangman method:\n");
			int[] testCases = { 0, 1, 2, 3, 4, 5, 6 };
			foreach (int guesses in testCases)
			{
				Console.WriteLine($"Incorrect Guesses: {guesses}");
				Console.WriteLine(GetHangmanImage(guesses));
				Console.WriteLine();
			}
		}
	}
}
