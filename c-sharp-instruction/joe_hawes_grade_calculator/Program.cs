namespace joe_hawes_grade_calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("-------Welcome to the Grade Converter------");

			do
			{
				Grades grade = new Grades();

				Console.WriteLine("Enter your numerical grade: ");
				
				Console.WriteLine();
				Console.WriteLine(grade.ToString());
				Console.WriteLine();
				Console.Write("Convert another grade? (y/n): ");
			}
			while (Console.ReadLine().Trim().ToLower() == "y");
			Console.WriteLine();
			Console.WriteLine("Goodbye----------------------------------");
		}
	}
}
