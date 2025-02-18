using ConsoleLibrary;
namespace LambdasDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================ Lambda Demo ================\n");
			List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// create a new list called squaredNums1
			// store the squared versions of all number
			List<int> squaredNums1 = numbers.Select(n => n * n).ToList();

			// create a new list called divThree1
			// store the nums from numbers that are evenly divisible by 3
			List<int> divThree1 = numbers.Where(n => n % 3 == 0).ToList();
			//Display results
			Console.WriteLine("Squared Numbers: " + string.Join(", ", squaredNums1));
			Console.WriteLine("Numbers Divisible by 3: " + string.Join(", ", divThree1));
		}
    }
}
