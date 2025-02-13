using System.Runtime.Intrinsics.X86;
using ConsoleLibrary;

namespace joe_hawes_person_manager.Model
{
	public class Customer : Person
	{
		public string CustomerNumber { get; set; }
		public Customer() { }
		public Customer(string firstName, string lastName, string customerNumber)
			: base(firstName, lastName)
		{
			CustomerNumber = CustomerNumber;
		}



		public override string DisplayText(string sep)
		{
			return $"{base.DisplayText(sep)}{CustomerNumber}";
		}

		public static void CreateCustomer()
		{

			Customer customer = new Customer();
			
			customer.FirstName = MyConsole.PromptString("First Name: ");
			customer.LastName = MyConsole.PromptString("Last Name: ");
			customer.CustomerNumber = MyConsole.PromptString("Customer Number: ");

			MyConsole.PrintL($"\nYou entered a new customer:\nName: {customer.FirstName} {customer.LastName} \nCustomer Number: {customer.CustomerNumber}\n");
		}
	}
}
