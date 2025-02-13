using System.Runtime.Intrinsics.X86;
using ConsoleLibrary;

namespace joe_hawes_person_manager
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Person() { }
		public Person(string FirstName, string LastName)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
		}

		public virtual string DisplayText(string sep)
		{
			return $"{FirstName}{sep}{LastName}";
		}
		public static string WelcomeBanner(string msg)
		{
			Console.WriteLine("================Welcome to the Person Manager====================================\n" +
			"===========================================================\n" +
			"====================================\n\n");
			return msg;
		}
	}
}
