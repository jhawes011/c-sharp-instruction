

namespace Ch16ExDiceRoller
{
	public class Die
	{
		public int Value { get; set; }

		public Die() 
		{
			this.Value = 0;
		}

		public void Roll()
		{
			Random R = new Random();
			this.Value = R.Next(1, 7);
		}
		
	}
}
