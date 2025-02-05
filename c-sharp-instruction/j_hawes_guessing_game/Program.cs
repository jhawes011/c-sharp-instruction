namespace j_hawes_guessing_game
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Print("Welcome to the Random Number Guessing Game! \n" + "++++++++++++++++++++++++++++++++++++++++++++++");
			Print("");
			string choice = "y";
			Random rand = new Random();
			while (choice == "y")
			{
				int theNumber = rand.Next(1, 101);
				int count = 0;
				int guess = 0;
				Print("I'm thinking of a number between 1 and 100. \n Try to guess it.\n");
				while (guess != theNumber)

				{
					guess = GetNumber("Enter number: ");
					count++;
					int diff = guess - theNumber;
					if (diff == 0)
					{
						Print("You got it in " + count + " tries ");
						if (count <= 3)
						{
							Print("Great work! math genius");
						}
						else if (count <= 7)
						{
							Print("Not too bad.");

						}
						else
						{
							Print("What took you so long?");
						}
					}
					else if (diff < -10)
					{
						Print("Way too low. Guess again.");
					}
					else if (diff < 0)
					{
						Print("Too low. Guess again.");
					}
					else if (diff > 10)
					{
						Print("Way too high. Guess again.");
					}
					else
					{
						Print("Too high. Guess again.");
					}
				}
				Print("");
				choice = GetRequiredString("Do you want to play agin? (y/n): ", "y", "n");
				Print("");
			}
			Print("Bye - Come again soon!");


			static void Print(string msg)
			{
				Console.WriteLine(msg);
			}

			static string GetRequiredString(string prompt, string val1, string val2)
			{
				string str = "";
				while (true)
				{
					Console.Write(prompt);
					str = Console.ReadLine().Trim();
					if (str == "")
					{
						Print("Error - entry is required.");
					}
					else if (str != val1 && str != val2)
					{
						Print("Error - entry must be " + val1 + " or " + val2 + ".");
					}
					else
					{
						break;
					}
				}
				return str;
			}

			static int GetNumber(string prompt)
			{
				int nbr = 0;
				bool success = false;
				while (!success)
				{
					Console.Write(prompt);
					if (int.TryParse(Console.ReadLine(), out nbr) && nbr >= 1 && nbr <= 100)
					{
						success = true;
					}
					else
					{
						Print("Invalid number. Please enter a number between 1 and 100.");
					}
				}
				return nbr;
			}
		}
	}
}
