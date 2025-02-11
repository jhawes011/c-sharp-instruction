﻿

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
		public int Sum()
		{
			return this.Die1.Value + this.Die2.Value;
		}
		public void Roll()
		{
			this.Die1.Roll();
			this.Die2.Roll();
		}
		public string GetRollResults()
		{
			string returnStr = ("Die1: " + Die1.Value +"\n");
			returnStr += "Die2: " + Die2.Value + "\n";
			returnStr += "Total: " + Sum() + "\n";
			if (Sum() == 2)
			{
				returnStr += "Snake Eyes!";

			}
			else if (Sum() == 12)
			{
				returnStr += "Box Cars!\n";
			}
			else if (Sum() == 7)
			{
				returnStr += "Craps!\n";
			}
			return returnStr;
		}
	}
}
