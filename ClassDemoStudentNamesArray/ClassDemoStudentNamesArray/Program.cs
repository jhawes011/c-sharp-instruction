using ConsoleLibrary;
namespace ClassDemoStudentNamesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Array Demo");

			int nbrStudents = MyConsole.PromptInt("Number of students: ");
			string[] studentsArray = new string[nbrStudents];

			for (int i = 0; i < nbrStudents; i++)
			{
				string name = MyConsole.PromptString($"Student Name[{i}]: ");
				studentsArray[i] = name;
			}

			string names = "";
			foreach (string name in studentsArray)
			{
				names += name + "|";
			}
			MyConsole.PrintL(names);



        }





    }
}
