namespace joe_hawes_change_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the change calculator");
            Console.WriteLine();
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                Console.Write("Enter number of cents : ");
                
                int cents = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                int quarters = cents / 25;
                cents = cents % 25;
                int dimes = cents / 10;
                cents = cents % 10;
                int nickels = cents / 5;
                cents = cents % 5;
                int pennies = cents;
                Console.WriteLine("Quarters: " + quarters);
                Console.WriteLine("Dimes: " + dimes);
                Console.WriteLine("Nickels: " + nickels);
                Console.WriteLine("Pennies: " + pennies);
                Console.WriteLine();
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
            }






            Console.WriteLine("Goodbye ----------------------");
        }
    }
}
