namespace Ch04DemoNumbersStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Numbers and Strings Demo");
            int dayofweek = 5;
            decimal price = 11.99m;
            int quantity = 3;
            char letter = 'A';
            bool isValid = false;
            double interestRate = .0367;

            // constants
            const int DaysOfTheWeek = 7;
            const int DaysInNovember = 30;
            const int DAYS_IN_YEAR = 365;

            // arithmatic operators
            decimal LineItemTotal = price * quantity;
            int count = 0;
            count = count + 1;
            Console.WriteLine(count);


            Console.WriteLine("Bye");
        }
    }
}
