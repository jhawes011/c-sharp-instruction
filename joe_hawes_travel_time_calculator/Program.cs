namespace joe_hawes_travel_time_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator");
            Console.WriteLine("");
            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter miles: ".PadRight(15));
                double miles = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter miles per hour: ".PadRight(15));
                double mph = Convert.ToDouble(Console.ReadLine());
                double hours = miles / mph;
                double hoursRemainder = hours % 1;
                double minutes = hoursRemainder * 60;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Estimated travel time");
                Console.WriteLine("---------------------");
                Console.WriteLine("Hours: " + Math.Floor(hours));
                Console.WriteLine("Minutes: " + Math.Round(minutes));
                Console.WriteLine("");
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
            }






            Console.WriteLine("Goodbye--------------------");
        }
    }
}
