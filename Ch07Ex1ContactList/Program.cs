namespace Ch07Ex1ContactList
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Welcome to the Contact List application");
			Console.WriteLine("====================================================");

			do
			{
				Contact contact = new Contact();

				Console.Write("Enter first name: ");
				contact.SetFirstName(Console.ReadLine());

				Console.Write("Enter last name: ");
				contact.SetLastName(Console.ReadLine());

				Console.Write("Enter email: ");
				contact.SetEmail(Console.ReadLine());

				Console.Write("Enter phone: ");
				contact.SetPhone(Console.ReadLine());

				Console.WriteLine(contact.DisplayContact());

				Console.Write("Continue? (y/n): ");
			} while (Console.ReadLine().Trim().ToLower() == "y");

			Console.WriteLine("Goodbye------------------------------------------------------\n-------------------------------------------------");
		}
    }
}
