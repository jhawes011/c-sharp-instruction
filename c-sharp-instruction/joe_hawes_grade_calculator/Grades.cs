

using System.Diagnostics;
using System.IO;

namespace joe_hawes_grade_calculator
{
	public class Grades
	{
		public int number;
		private string letterGrade = "";
		public void SetNumber(int number) => this.number = number;
		public int GetNumber(int number) => number;
		
		public string ToString()
		{
			return $"Grade letter: {letterGrade}";
		}

		public string GetLetter()
		{

			if (int.TryParse(Console.ReadLine(), out int number))
			{
				
				if (number <= 100 && number >= 90)
				{
					letterGrade = "A";
				}
				else if (number < 90 && number >= 80)
				{
					letterGrade = "B";
				}
				else if (number < 80 && number >= 70)
				{
					letterGrade = "C";
				}
				else if (number < 70 && number >= 60)
				{
					letterGrade = "D";
				}
				else
				{
					letterGrade = "F";
				}
				return letterGrade;
			}
			else
			{
				return $"Invalid input. Please enter a valid numerical grade. Try Again";
			}
			
			
		}
	}
}
