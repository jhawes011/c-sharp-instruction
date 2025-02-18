using ConsoleLibrary;
using joe_hawes_hangman.Model;

namespace joe_hawes_hangman
{
	internal class Program : HangmanWords
	{
		static void Main(string[] args)
		{
			HangmanWords hangman = new HangmanWords();
			MyConsole.PrintL("\n==================== Welcome to the Hangman game! ====================\n");
			DisplayHangmanRules();

	
			string choice = "y";
			while (choice.ToLower() == "y")
			{
				int incorrectGuesses = 0;
				bool wordGuessed = false;
				string randomWord = GetRandomWord();
				string hiddenWord = GetHiddenWord(randomWord);
				string display = "";
				
				
				
				

				while (incorrectGuesses < 6 && (wordGuessed != true))
				{
					
					MyConsole.PrintL("Test Hint: " + randomWord);
					MyConsole.PrintL(hiddenWord);
					List<string> lettersGuessed = new List<string>();
					lettersGuessed.Add(MyConsole.PromptString("Enter your letter guess: \n"));
					MyConsole.PrintL(hangman.DisplayGuessedLetters(lettersGuessed));
					GetHangmanImage(incorrectGuesses);
				}

				

				choice = MyConsole.PromptString("\nPlay another round? (y/n): ");
			}
			
			
			
			MyConsole.PrintL("\n==================== Thanks for playing! =========================\n");

				
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
		static void DisplayHangmanRules()
		{
			Console.WriteLine("===== HANGMAN RULES =====");
			Console.WriteLine("1. A secret word is chosen.");
			Console.WriteLine("2. You see blanks for each letter (_ _ _ _).");
			Console.WriteLine("3. Guess one letter at a time.");
			Console.WriteLine("4. If correct, the letter appears in the word.");
			Console.WriteLine("5. If wrong, a part of the hangman is drawn.");
			Console.WriteLine("6. Win by guessing the full word before the hangman is completed and you are DEAD!");
			Console.WriteLine("============ Good Luck !! =============\n");
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
