

namespace ch12ClassesDemo
{
	public class MyConsole
	{
		public static int PromptInt(string prompt)
		{
			int result = 0;
			bool isValid = false;
			while (!isValid)
			{

				Print(prompt);
				if (Int32.TryParse(Console.ReadLine(), out result))
				{
					isValid = true;
				}
				else
				{
					PrintL("Error - invalid int.");

				}

			}
			return result;
		}
		public static string PromptString(string prompt)
		{
			Print(prompt);
			return Console.ReadLine();
		}
		public static void Print(string msg)
		{
			Console.Write(msg);
		}
		public static void PrintL(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}
