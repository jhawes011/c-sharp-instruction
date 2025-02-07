using System.Text;

namespace ch9_dates_strings_demos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ch9 date strings");

			// what is the current date and time?-----------------
			DateTime now = DateTime.Now;
			DateTime today = DateTime.Today;

			// string contatenation---------------------------------
			PrintL("Now: " + now + ".");
			PrintL("Today: " + today);
			PrintL("");

			// string interolation--------------------------------
			PrintL($"Now: {now}.");
			PrintL($"Today: {today}.");
			PrintL("");

			// pg 277----------------------------------------------
			PrintL($"longDate: {now.ToLongDateString()}");
			PrintL($"shortDate: {now.ToShortDateString()}");
			PrintL($"longTime: {now.ToLongTimeString()}");
			PrintL($"shortTime: {now.ToShortTimeString()}");
			PrintL("");

			//pg 279 get information about a date------------------
			PrintL($"Month: {now.Month}");
			PrintL($"Day: {now.Day}");
			PrintL($"Year: {now.Year}");
			PrintL($"DayOfWeek: {now.DayOfWeek}");
			PrintL($"DayOfYear: {now.DayOfYear}");
			PrintL($"Days in month - 2025, 2: {DateTime.DaysInMonth(2025, 2)}");
			PrintL($"Leap year for 2028: {DateTime.IsLeapYear(2028)}");
			PrintL("");

			// pg281  manipulate dates and time (add, subtract, etc)-----
			// due date in 2 months
			DateTime dueDate = now.AddMonths(2);
			PrintL($"Due date in 2 months: {dueDate}");
			PrintL("");

			//halloween 2025 is..-----------------------------------------
			DateTime halloween = new DateTime(2025, 10, 31);
			PrintL($"Halloween 2025 is on a {halloween.DayOfWeek}.");
			PrintL("");

			//find if date is before or after another---------------------------
			PrintL($"Is halloween before now? {halloween > now}");
			PrintL("");

			//days until halloween
			PrintL($"Days until halloween: {(halloween - now).Days}"); // or TimeSpan timeToHalloween = halloween - now; PrintL($"Days until halloween: {timeToHalloween.Days}");
			PrintL("");


			//pg 285 Strings--------------------------------------------------
			// loop through characters in a string
			string sentence = "WooHoo! Today is Friday!";
			foreach (char c in sentence)
			{
				Print(c + "");
			}
			PrintL("");
			PrintL("");
		
			// hangman - creating an underscore version of a word-------------
			// word is "superman", the hiddenVersion would be "_ _ _ _ _ _ _ _"
			string word = "superman";
			string hiddenVersion = "";
			foreach (char c in word)
			{
				hiddenVersion += "_ ";
			}
			hiddenVersion = hiddenVersion.Trim();
			Print($"The word is {word}. --> ");
			PrintL(hiddenVersion);
			PrintL("");

			// p 293 string builder-------------------------------------------
			StringBuilder sb = new StringBuilder();
			sb.Append("Hello");
			sb.Append(", how ");
			sb.Append("are you?");
			PrintL(sb.ToString());

			//use indexed for loop----------------------------------property of an array is the length and property of a list is the count
			for (int i = 0; i < sb.Length; i++)
			{
				Print(sb[i] + "");
			}


			PrintL("");
			PrintL("Bye-------------------------------------");
		}


		static void PrintL(string message)
		{
			Console.WriteLine(message);
		}
		static void Print(string message)
		{
			Console.Write(message);
		}
	}
}
