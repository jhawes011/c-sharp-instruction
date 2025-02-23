
using System.Diagnostics;
using ConsoleLibrary;

namespace Ch15ClassDemoInterfaces
{
	internal class Customer : Summarizable

	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string CustomerNumber { get; set; }
		public Customer(string firstName, string lastName, string customerNumber)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.CustomerNumber = customerNumber;




		}

		public string GetSummeryDetails()
		{
			string summary = $"Customer: ({CustomerNumber}) {LastName}, {FirstName}";
			return summary ;
		}
	}
}
