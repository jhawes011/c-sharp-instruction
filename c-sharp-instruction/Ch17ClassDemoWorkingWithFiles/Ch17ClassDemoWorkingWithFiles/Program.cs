using ConsoleLibrary;

namespace Ch17ClassDemoWorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintL("==================== Ch17 Class Demo - How to work with files =================");

			string dir = @"C:\C#\files\";
			if (!Directory.Exists(dir))
			{
				Directory.CreateDirectory(dir);
				MyConsole.PrintL("Directory created");
			}
			else
			{
				MyConsole.PrintL("dir already exists");
			}

			string path = dir + ("name.txt");
			if (!File.Exists(path))
			{
				File.Create(path);
				MyConsole.PrintL("File created");
			}
			else
			{
				MyConsole.PrintL("File already exists");
			}

			//write some names to the file
			//StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
			//writer.WriteLine("Adrian");
			//writer.WriteLine("Jim");
			//writer.WriteLine("Heath");
			//writer.WriteLine("Nick");
			//writer.WriteLine("Drew");
			//writer.Close();
			//MyConsole.PrintL("name writing done");

			MyConsole.PrintL("=== reading names.txt ===");
			StreamReader reader = new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
			List<string> lines = new List<string>();
			while (reader.Peek() != -1)
			{
				string row = reader.ReadLine() ?? "";       // ?? "" says if null then = empty string
				lines.Add(row);
			}
			reader.Close();

			foreach (string line in lines)
			{
				MyConsole.PrintL($"line = {line}");
			}



			MyConsole.PrintL("==================== Goodbye =================");
		}
    }
}
