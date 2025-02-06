namespace ch8_demo_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to collections");

			//just for reference
			Random rand = new Random(); //creates a new instance of the random class
			int dieRoll = rand.Next(1, 7);

			//-----------------------pg 257-------------------Lists
			List<int> numbers = new List<int>();
			numbers.Add(1);
			numbers.Add(2);
			numbers.Add(3);

			foreach (int i in numbers)
			{Console.WriteLine(i + " ");
			}
			Console.WriteLine("");
			List<string> names = new List<string>();
			names.Add("Jim");
			names.Add("Andy");
			names.Add("Nick");
			names.Add("Christian");
			names.Add("Adrian");
			names.Add("Sean");
			names.Add("Celina");
			names.Add("Joe");
			names.Add("Heath");

			names.Insert(4, "Test"); //expecting and index and a string. for loop to get access to the names
			foreach (string n in names)
			{
				Console.Write(n + " ");
			}
			
			Console.WriteLine(names);
			Console.WriteLine("Adrian?" +names.Contains("Adrian")); ///check if something is in the list
			names.Remove("Test"); //removes the name test
			foreach(string n in names)
			{
				Console.Write(n + " ");
			}
			Console.WriteLine("");

			// ---------------------------whats the index position for Celina? ---------------
			Console.WriteLine("Celina in position: " + names.BinarySearch("Celina"));
			Console.WriteLine("Celina in position: " + names.IndexOf("Celina"));


			Console.WriteLine("Goodbye---------------------------------");
		}
    }
}
