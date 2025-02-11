using ConsoleLibrary;

namespace Ch16ExDiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
			MyConsole.PrintL("Welcome to the Dice Roller Game-------------------------");

			//initialize choice with a prompt - Roll the Dice?
			string choice = MyConsole.PromptString("Roll the Dice? (y/n): ");
			while (choice == "y")
			{
				Dice dice = new Dice();
				dice.Roll();
				MyConsole.PrintL(dice.GetRollResults());
				choice = MyConsole.PromptString("Roll again? (y/n): ");
			}

			//while choice == y-------------------------------------------------
				//roll die1 and die2
				//display total and specialmsg
				//prompt continue?


			MyConsole.PrintL("Goodbye---------------------------");
        }
    }
}
