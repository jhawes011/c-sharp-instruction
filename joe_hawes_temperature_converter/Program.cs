using static System.Runtime.InteropServices.JavaScript.JSType;

namespace joe_hawes_temperature_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter");

            string choice = "y";
            while (choice.ToLower() == "y")
            {
                Console.Write("Enter degrees in Fahrenheit: ");
                string input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }
                double fahrenheit = Convert.ToDouble(input);
                double roundedFahrenheit = Math.Round(fahrenheit, 2);
                Console.Write("Degrees in Celsius: " + Math.Round((fahrenheit - 32) * 5 / 9, 2));
                Console.WriteLine();
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();

            }

            Console.WriteLine("Goodbye----------------------");
        }
    }
}
