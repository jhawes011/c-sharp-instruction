using ConsoleLibrary;
namespace LambdasDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyConsole.PrintL("================ Lambda Demo ================\n");
			List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			
			// store the squared versions of all number
			List<int> squaredNums1 = new List<int>();
			foreach (int value in numbers)
			{
				squaredNums1.Add(Square(value));
			}
			

			
			// store the nums from numbers that are evenly divisible by 3
			List<int> divThree1 = new List<int>();
			foreach (int value in numbers)
			{
				if (value % 3 == 0)
				{
					divThree1.Add(value);
				}
			}
			DisplayListAsString(squaredNums1, "squaredNums1 using foreach loop");

			// do this again using a method as a paremeter
			List<int> squaredNums2 = numbers.Select(Square).ToList();
			DisplayListAsString(squaredNums2, " squaredNums2 Using a method as parameter");

			// do this again using a lambda expression
			List<int> squaredNums3 = numbers.Select(n => n * n).ToList();
			DisplayListAsString(squaredNums3, " squaredNums3 Using a Lambda expression");


			DisplayListAsString(divThree1, "Divthree List (1)");

			List<int> divThree2 = numbers.FindAll(IsDivisibleByThree).ToList();//using .FindAll

			//dot this again using a lambda expression
			List<int> divThree3 = numbers.Where(n => n % 3 == 0).ToList();  //using .Where
			DisplayListAsString(divThree3, "DivThree3 using lambda expression");
		}
		public static bool IsDivisibleByThree(int x)
		{
			return x % 3 == 0;

		}
		public static int Square(int value)
			{ return value * value; }
		public static void DisplayListAsString(List<int> numbers, string header)
		{
			string result = "========================================\n";
			result += header + "\n";
			result += "========================================\n";
			foreach (var value in numbers)
			{
				result += value.ToString() + " ";
			}
			result += "\n";
			MyConsole.PrintL(result);
		}
	}
}
