using ConsoleLibrary;

namespace joe_hawes_person_manager
{
	public class Employee : Person
	{
		public int Ssn { get; set; }

		public Employee() { }
		public Employee(string FirstName, string LastName, int Ssn)
			: base(FirstName, LastName)
		{
			this.Ssn = Ssn;
		}

		public string DisplayText(string sep)
		{
			return $"{base.DisplayText(sep)} {Ssn}";
		}
	}
}
