namespace joe_hawes_student_registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawMessage = """
                Student Registration Form

                """;
            Console.WriteLine(rawMessage);

            Console.Write("Enter your first name: " );         
            string n1 = (Console.ReadLine());
            Console.Write("Enter your last name: " );
            string n2 = (Console.ReadLine());
            string fullName = n1;
            fullName += " ";
            fullName += n2;
            Console.Write("Enter year of birth: ");
            string bd = (Console.ReadLine());
            string lastName = bd;
            Console.WriteLine("Welcome " + fullName + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + n1 + "*" + bd);






        }
    }
}
