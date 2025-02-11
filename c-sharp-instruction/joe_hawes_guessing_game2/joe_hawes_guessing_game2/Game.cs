using System;

using ConsoleLibrary;

namespace joe_hawes_guessing_game2
{
	public class Game
	{
		public static int GetInt(string prompt)
		{
			while (true)
			{
				MyConsole.Print(prompt);
				if (int.TryParse(Console.ReadLine(), out int result))
					return result;
				MyConsole.PrintL("Error! Invalid number. Try again.");
			}
		}


		public static string GetString(string prompt, string[] validValues = null)
		{
			while (true)
			{
				MyConsole.Print(prompt);
				string value = Console.ReadLine().Trim().ToLower();
				if (validValues == null || Array.Exists(validValues, v => v == value))
					return value;
				Console.WriteLine($"Error! Entry must be one of {string.Join(", ", validValues)}. Try again.");
			}
		}
		private int targetNumber;
		private int numGuesses;
		private Random random;

		public Game()
		{
			random = new Random();
			targetNumber = random.Next(1, 101);
			numGuesses = 0;
		}

		public void Play()
		{
			Console.WriteLine("I'm thinking of a number from 1 to 100.\nTry to guess it.");
			while (true)
			{
				int guess = GetInt("Enter number: ");
				numGuesses++;
				if (guess < targetNumber)
					Console.WriteLine("Too low! Guess again.");
				else if (guess > targetNumber)
					Console.WriteLine("Too high! Guess again.");
				else
				{
					Console.WriteLine($"You got it in {numGuesses} tries.");
					DisplayResult();
					break;
				}
			}
		}

		private void DisplayResult()
		{
			if (numGuesses == 1)
				Console.WriteLine("Great work! You are a mathematical wizard.");
			else if (numGuesses <= 5)
				Console.WriteLine("Not too bad! You've got some potential.");
			else
				Console.WriteLine("Better luck next time!");
		}
	}
}
		
	
