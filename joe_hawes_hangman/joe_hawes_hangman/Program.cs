using ConsoleLibrary;
using System.Collections.Generic;
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
				List<string> lettersGuessed = new List<string>();

				// Initialize hiddenWord with underscores
				string hiddenWord = new string('_', randomWord.Length);

				while (incorrectGuesses < 6 && !wordGuessed)
				{
					MyConsole.PrintL(GetHangmanImage(incorrectGuesses));
					MyConsole.PrintL("Test Hint: " + randomWord);
					MyConsole.PrintL("Current Word: " + hiddenWord);

					MyConsole.PrintL("Enter your letter guess: ");
					string userGuess = Console.ReadLine().ToLower();

					// Check if letter was already guessed
					if (lettersGuessed.Contains(userGuess))
					{
						MyConsole.PrintL("You already guessed that letter. Try again.");
						continue;
					}

					lettersGuessed.Add(userGuess);

					// Update hiddenWord
					string updatedHiddenWord = DisplayGuessedLetters(randomWord, hiddenWord, userGuess);

					// If no changes, it means the letter was incorrect
					if (updatedHiddenWord == hiddenWord)
					{
						incorrectGuesses++;
					}

					hiddenWord = updatedHiddenWord;

					// Check if the word is fully guessed
					if (!hiddenWord.Contains('_'))
					{
						wordGuessed = true;
						MyConsole.PrintL("Congratulations! You guessed the word: " + randomWord);
					}
				}

				if (!wordGuessed)
				{
					MyConsole.PrintL(GetHangmanImage(6)); // Show full hangman
					MyConsole.PrintL("Game Over! The word was: " + randomWord);
				}

				choice = MyConsole.PromptString("\nPlay another round? (y/n): ");
			}

			MyConsole.PrintL("\n==================== Thanks for playing! =========================\n");
		}

		// This method correctly updates the hiddenWord with guessed letters
		public static string DisplayGuessedLetters(string word, string hiddenWord, string userGuess)
		{
			char[] charsWord = word.ToCharArray();
			char[] charsHiddenWord = hiddenWord.ToCharArray();

			for (int i = 0; i < word.Length; i++)
			{
				if (userGuess[0] == charsWord[i])
				{
					charsHiddenWord[i] = userGuess[0];
				}
			}
			return string.Join(" ",charsHiddenWord);
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
	



