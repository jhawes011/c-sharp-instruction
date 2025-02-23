using System.Globalization;

namespace Ch5Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Chapter 5 Demos - while loops");

            // p. 155
            // while loop, counter and sum
            int i = 0;
            int sum = 0;
            // sum all values from 0 to 10
            while (i <= 10)
            {
                sum += i;
                //sum = sum + i;
                i++;
            }
            Console.WriteLine("sum = " + sum);

            // while loop for data validation
            bool success = false;
            int month = 0;
            // prompt user for month until they enter a valid month
            while (!success)
            {
                Console.WriteLine("Enter month #: ");
                month = Convert.ToInt32(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Invalid month # try again.");
                }
                else
                {
                    success = true;
                }
            }
            Console.WriteLine("Month entered: " + month);

            // while true
            // loop until even number is entered
            while (true)
            {
                Console.WriteLine("In a while true loop...");
                Console.Write("Enter an even #: ");
                int nbr = Convert.ToInt32(Console.ReadLine());
                if (nbr % 2 == 0)
                {
                    break;
                }
            }

            // p. 157 for loops
            // sum 0 to 10 w/ for loop
            sum = 0;
            string numberStr = "";
            for (i = 0; i <= 10; i++)
            {
                sum += i;
                numberStr += i + " ";
            }
            Console.WriteLine(numberStr);
            Console.WriteLine("sum = " + sum);

            // count 0 to 100 by 5
            for (i = 0; i <= 100; i += 5)
            {
                Console.WriteLine("i: " + i);
            }

            // count 99 to 0 by 3
            for (i = 99; i >= 0; i -= 3)
            {
                Console.WriteLine("i: " + i);
            }


            Console.WriteLine("Bye");
        }
    }
}
