using ConsoleLibrary;

namespace joe_hawes_pig_dice
{
	public class Dice
	{
		private Random random = new Random();

		public int Roll()
		{
			return random.Next(1, 6);
		}
	}
}
