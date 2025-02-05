namespace joe_hawes_factorial_calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Print("Welcome to the Factorial Calculator \n ");
			string choice = "y";
			while (choice == ("y"))
			{ try

				{
					Console.Write("Enter an integer that's greater than 0 and less than 10: ");
					Print("");
					int n = Convert.ToInt32(Console.ReadLine());
					long factorial = 1;
					for (int i = 1; i <= n; i++)
					{
						factorial = factorial * i;
					}
					Print("The factorial of " + n + " is " + factorial);
					Print("");
					Print("Continue? (y/n): ");
					choice = Console.ReadLine();
				}


				
				catch (Exception ex)
				{
					Print("*********************************** \n Error! Please enter a valid number \n \n" + ex.Message + "\n \n *****************************************");
					continue;
				}
			}


			Print("Goodbye----------------------------------------------------");	
		}
		static void Print(string msg)
			{
			Console.WriteLine(msg);
			}
	}
}