using System;
using ConsoleLibrary;
namespace ClassDemoPigDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pig Dice----------------------------");
			Random rand = new Random();
			string choice = "y";
			while (choice == "y")
				

			{
				int nbrGames = MyConsole.PromptInt("Number of games to play? ");
				int highScore = 0;
				int highScoreNumRolls = 0;
				for (int i = 0; i < nbrGames; i++)
				{
					int roll = 0;
					int score = 0;
					int rollCount = 0;
					
					while (roll != 1)
					{
						rollCount++;
						roll = rand.Next(1, 7);
						if (roll != 1)
						{
							score += roll;
						}
					}
					//highScore = (score > highScore) ? score : highScore;
					if (score > highScore)
					{
						highScore = score;
						highScoreNumRolls = rollCount;
					}
				}
				MyConsole.PrintL($"High score # of rolls: {highScoreNumRolls}");
				MyConsole.PrintL($"High score: {highScore}");
				choice = MyConsole.PromptReqString("Play again ? (y /n)", "y", "n");
				
			}
			Console.WriteLine("GOODBYE----------------------------");
		}
    }
}
