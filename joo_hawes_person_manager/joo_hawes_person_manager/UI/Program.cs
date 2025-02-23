
using ConsoleLibrary;
using joe_hawes_person_manager.Model;
namespace joe_hawes_person_manager.UI
{
	public class Program
	{
		static void Main(string[] args)
		{

			Person.WelcomeBanner("");
			string result = "";
			string choice = "y";
			while (choice == "y")
			{
				result = MyConsole.PromptReqString("Create customer or employee? (c/e): \n", "c", "e");
				if (result == "c")
				{
					Customer.CreateCustomer();
				}
				else if (result == "e")
				{
					Employee.CreateEmployee();
				}
				choice = MyConsole.PromptString("Enter another person? (y/n): \n");

			}
			MyConsole.PrintL("Goodbyee==================================================================");
		}



	}
}
