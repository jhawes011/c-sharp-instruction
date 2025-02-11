

namespace Ch16ExDiceRoller
{
	public class Dice
	{
		public Die Die1 { get; set; }
		public Die Die2 { get; set; }
		public Dice()
		{
			this.Die1 = new Die();
			this.Die2 = new Die();
		}
	}
}
