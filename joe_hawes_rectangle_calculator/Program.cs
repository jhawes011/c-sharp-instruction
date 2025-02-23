using System.Transactions;

namespace joe_hawes_rectangle_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");

            string choice = "y";
            while (choice == "y")
            {
                Console.Write("Enter length: ".PadRight(15));
                
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter width: ".PadRight(15));
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Area: ".PadRight(15) + length * width);
                Console.WriteLine("Perimeter: ".PadRight(15) + ((length * 2) + (width * 2)));

                // could also used alias for math formulas:          double area = length * width; double perimeter = (length * 2) + (width * 2);


                Console.WriteLine();
                Console.Write("Continue? (y/n): ".PadRight(15));
                choice = Console.ReadLine();
            }
        }
    }
}
