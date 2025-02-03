namespace joe_hawes_interest_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Interest Calculator!");
            Console.WriteLine();
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                Console.Write("Enter loan amount: ");
                double loanAmount = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter interest rate: ");
                
                double interestRate = Convert.ToDouble(Console.ReadLine());
                double interest = (loanAmount * interestRate);
                string loanAmount2 = (loanAmount.ToString("C"));
                string sum = ((loanAmount + interest).ToString("C"));
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Total loan amount: " + sum);
                Console.WriteLine(("Interest rate: " + ((interestRate*100) + "%")));
                Console.WriteLine("Interest: " + (Math.Round(interest, 3)).ToString("C"));
                Console.WriteLine();
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("--------------------Goodbye! ------------------------");
        }
    }
}
