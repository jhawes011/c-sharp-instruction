using ConsoleLibrary;
namespace joe_hawes_animal_counter
{
    internal class AnimalCounterApp
    {
	
        static void Main(string[] args)
        {
            MyConsole.PrintL("============Welcome to the Animal Counter==============!");

			MyConsole.PrintL("Counting Alligators...");
			Alligator alligator = new Alligator();
			Count(alligator, 8);
			MyConsole.PrintL("");

			MyConsole.PrintL("Counting Sheep...");
			Sheep sheep = new Sheep("Blackie");
			Count(sheep, 20);
		}


		private static void Count(ICountable c, int maxCount)
		{
			c.ResetCount();
			for (int i = 0; i < maxCount; i++)
			{
				c.IncrementCount();
				MyConsole.PrintL(c.GetCountString());
			}
		}
    }
}
