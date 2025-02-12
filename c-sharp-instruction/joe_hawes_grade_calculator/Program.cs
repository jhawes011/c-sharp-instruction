using ConsoleLibrary;
namespace joe_hawes_grade_calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("-------Welcome to the Grade Converter------");

			string choice = "y";
			while (choice == "y")
			{ //** change request(CR): Need MyConsole.PromptInt(string prompt, int min, int max)
				int numericGrade = MyConsole.PromptInt("Enter numerical grade: ", 0, 100);
				Grade grade = new Grade(numericGrade);
				MyConsole.PrintL("LetterGrade: " + grade.GetLetter());
				// ** CR: PromptString - Validates empty string, y, n


				choice = MyConsole.PromptReqString("Continue? (y/n)", "y", "n").ToLower();
			}
			Console.WriteLine();
			Console.WriteLine("Goodbye----------------------------------");
		}
	}
}
