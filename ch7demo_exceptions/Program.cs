namespace ch7demo_exceptions{
	    internal class Program{
            static void Main(string[] args)
			{	Console.WriteLine("Chapter 7, exceptions and data validation");

				
			int nbr1 = 0;
			while (true)
			{
				Console.WriteLine("Enter an integer. ");
				if (!Int32.TryParse(Console.ReadLine(), out nbr1))
				{
					Console.WriteLine("You did not enter an integer. ");

				}
				else
				{
					break;
				}

				Console.WriteLine("You entered: " + nbr1);




			}
				Console.WriteLine("Bye -------------------------------------");
			}
			
		}
}
