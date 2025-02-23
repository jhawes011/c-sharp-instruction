

namespace joe_hawes_pig_dice
{
	public class Player
	{
		public int TotalScore { get; private set; }
		public int RollCount { get; private set; } // Fixed declaration
		private Dice dice = new Dice();

		public void Play()
		{
			TotalScore = 0;
			RollCount = 0;

			while (true)
			{
				int roll = dice.Roll();
				RollCount++;

				if (roll == 1)
				{
					Console.WriteLine("You rolled a 1! Game over.");
					break;
				}

				TotalScore += roll;
				Console.WriteLine($"Rolled a {roll}, total score: {TotalScore}");
			}
		}
	}
}
