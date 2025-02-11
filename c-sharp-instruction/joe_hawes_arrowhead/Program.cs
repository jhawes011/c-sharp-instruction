namespace joe_hawes_arrowhead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Arrowhead controller.");

			do
			{
				Console.Write("Enter the size of the arrowhead: ");

				if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
				{
					if (size % 2 == 0) size++; // Ensure an odd number for symmetry-------------

					// Print the upper part of the arrow------------------------------------------
					for (int i = 1; i <= size / 2 + 1; i++)
					{
						Console.WriteLine(new string('>', i));
					}

					// Print the lower part of the arrow------------------------------------------
					for (int i = size / 2; i >= 1; i--)
					{
						Console.WriteLine(new string('>', i));
					}
				}
				else
				{
					Console.WriteLine("Invalid input. Please enter a positive integer.");
				}
				Console.WriteLine("Would you like to make another Arrowhead? y/n ");
			}
			while (Console.ReadLine().ToLower() == "y");
			Console.WriteLine("Goodbye=============================================");
			Console.WriteLine("====================================================");
		}
	}
}
