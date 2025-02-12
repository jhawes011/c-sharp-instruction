using System.Numerics;
using ConsoleLibrary;

namespace joe_hawes_pig_dice
{
	public class PigGame
	{
		private int gamesPlayed = 0;
		private int highestScore = 0;

		public void PlayGames(int numGames)
		{
			for (int i = 0; i < numGames; i++)
			{
				Player player = new Player();
				player.Play();
				gamesPlayed++;
				highestScore = Math.Max(highestScore, player.TotalScore);
				Console.WriteLine($"Game {gamesPlayed} finished! Score: {player.TotalScore}, Rolls: {player.RollCount}");
			}
		}

		public void ShowResults()
		{
			Console.WriteLine($"Played {gamesPlayed} games");
			Console.WriteLine($"Highest Score is {highestScore}");
		}



	}
}
