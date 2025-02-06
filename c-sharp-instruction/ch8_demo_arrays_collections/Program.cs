namespace ch8_demo_arrays_collections
{
    internal class Program
    {
        static void Main(string[] args)
		{
			PrintL("welcome chapter 8 demos. arrays and collections");
			// -----------------------------------pg 231
			// ------------------------------------array of strings for names------------------------------
			string[] names = new string[9];
			names[0] = "Jim";
			names[1] = "Andy";
			names[2] = "Nick";
			names[3] = "Christian";
			names[4] = "Adrian";
			names[5] = "Sean";
			names[6] = "Celina";
			names[7] = "Heath";
			names[8] = "Joe";

			PrintL("names = " + names);
			PrintL(names[0]);
			for (int i = 0; i < names.Length; i++)
				{	
				PrintL("i: " + i + " name: " + names[i]);
				}
			
			//-------------------------------------------names[9] = "new person";---------------------------
			decimal[] prices = { 1.99m, 2.25m, 4.50m };
			for (int i = 0; i < prices.Length; i++)
			{
				PrintL("i: " + i + " price: " + prices[i]);
			}

			//-----------------------------------infer the type of an array--------------------------
			var grades = new[] { 95, 89,91,98 };
			int sum = 0;
			for (int i = 0; i < grades.Length; i++)
			{
				sum += grades[i];
			}
			PrintL("sum of grades: " + sum);
			PrintL("average of grades: " + sum / grades.Length);
			//---------------------------------------var stuff = new[] { "A", 5, 7.7}; array must be all of same type----------------

			string fullName = "John Doe";
			for (int i = 0; i < fullName.Length; i++)
			{
				Print(fullName[i] + " ");
			}
			PrintL("");

			// -----------------------for 'each' loop--------------------------------
			// ----------------------loop through names and print on one line
			foreach (string name in names)
			{
				Print(name + " ");
			}
			PrintL("");

			// ----------------------------p 239 rectangular array----------------------------
			// 3 x 4 grid
			// 1 2  3  4
			// 5 6  7  8
			// 9 10 11 12
			int[,] grid = new int[3, 4];
			grid[0, 0] = 1;
			grid[0, 1] = 2;
			grid[0, 2] = 3;
			grid[0, 3] = 4;
			grid[1, 0] = 5;
			grid[1, 1] = 6;
			grid[1, 2] = 7;
			grid[1, 3] = 8;
			grid[2, 0] = 9;
			grid[2, 1] = 10;
			grid[2, 2] = 11;
			grid[2, 3] = 12;

			// ----------------------print grid - loop for rows and loop for columns---------------
			string gridString = "";
			for (int i = 0; i < grid.GetLength(0); i++)
			{
				for (int j = 0; j < grid.GetLength(1); j++)
				{
					gridString += grid[i, j] + "\t ";
				}
				gridString += "\n";
			}
			Print(gridString);
			PrintL("");

			//-------------------------------sort by name-----------------------------------
			Array.Sort(names);
			foreach (string name in names)
			{
				PrintL(name + " ");
			}
			// ------------------------p255 collections----------------------------------------------

			PrintL("");
			PrintL("Goodbye-------------------------------------------");
		}
		static void PrintL(string msg)
		{
			Console.WriteLine(msg);
		}
		static void Print(string msg)
		{
			Console.Write(msg);
		}
	}
}
