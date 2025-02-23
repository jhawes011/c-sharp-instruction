namespace LeetCode01TwoSum
{
	internal class Program
	{
		static void Main(string[] args)
		{
		
			Console.WriteLine("TwoSum LeetCode Challenge--------------------\n------------------------------------------------------");
			
			
			Console.Write("Enter Target: ");
			string input = Console.ReadLine();
			int target = int.Parse(input);
			Console.WriteLine();
			Console.WriteLine();
			
			int[] nums = { 2, 7, 11, 15 };
			int[] result = TwoSum(nums, target);

			
			if (result.Length == 2)
			{
					Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
			}
			else
			{
				Console.WriteLine("No solution found.");
			}

		}
		static int[] TwoSum(int[] nums, int target)
		{
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[j] == target - nums[i])
					{
						return new int[] { i, j };

					}
				}			
			} 
			return new int[0] { };	
		}
		
	}
}
