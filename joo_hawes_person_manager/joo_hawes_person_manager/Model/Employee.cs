using ConsoleLibrary;

namespace joe_hawes_person_manager.Model
{
	public class Employee : Person
	{
		public string Ssn { get; set; }

		public Employee() { }
		public Employee(string FirstName, string LastName, string Ssn)
			: base(FirstName, LastName)
		{
			this.Ssn = Ssn;
		}

		public override string DisplayText(string sep)
		{
			return $"{base.DisplayText(sep)} {Ssn}";
		}
		public static void CreateEmployee()
		{


			Employee employee = new Employee();
			employee.FirstName = MyConsole.PromptString("First Name: ");
			employee.LastName = MyConsole.PromptString("Last Name: ");
			employee.Ssn = MyConsole.PromptString("SSN: ");

			MyConsole.PrintL($"\nYou entered a new employee: \nName: {employee.FirstName} {employee.LastName} \nEmployee Ssn: {MaskSsn(employee.Ssn)}\n");
		}

		private static string MaskSsn(string ssn)
		{

			return new string('*', ssn.Length - 4) + ssn.Substring(ssn.Length - 4);
		}
	}
}
