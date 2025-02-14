using ConsoleLibrary;
using joe_hawes_account_balance_calculator.Model;
namespace joe_hawes_account_balance_calculator.UI
{
	internal class Program
	{
		static void Main(string[] args)
		{

			MyConsole.PrintL("Welcome to the Account Balance Calculator");
			CheckingAccount checking = new CheckingAccount(1000.00m, 1.00m);
			SavingsAccount savings = new SavingsAccount(1000.00m, 0.012m);

			MyConsole.PrintL($"Starting Balances \nChecking: {checking.Balance:0.00} \nSavings: {savings.Balance:0.00}\n");
			MyConsole.PrintL("Enter the transactions for the month \n");

			string continueTransaction = "y";
			while (continueTransaction == "y")
			{
				string transactionType = (MyConsole.PromptReqString("Withdraw or Deposit? (w/d): ", "w", "d"));
				string accountType = (MyConsole.PromptReqString("Checking or Savings? (c/s): ", "c", "s"));
				
				if (!decimal.TryParse(MyConsole.PromptString("Amount? : "), out decimal amount))
				{
					MyConsole.PrintL("Invalid amount entered.");
					return;
				}
				if (transactionType == "w")
				{
					if (accountType == "c")
						checking.Withdraw(amount);
					else if (accountType == "s")
						savings.Withdraw(amount);
				}
				else if (transactionType == "d")
				{
					if (accountType == "c")
						checking.Deposit(amount);
					else if (accountType == "s")
						savings.Deposit(amount);
				}
				continueTransaction = MyConsole.PromptReqString("Add another transaction? (y/n)", "y", "n");
			}
			
			checking.ApplyMonthlyFee();
			savings.ApplyInterest();
			MyConsole.PrintL("Monthly Payments and Fees =====================");
			MyConsole.PrintL($"Checking fee: ${checking.MonthlyFee:0.00}");
			MyConsole.PrintL($"Savings interest payment: ${savings.MonthlyInterestPayment:0.00} \n");
			MyConsole.PrintL("Final Balances ================================");
			MyConsole.PrintL($"Checking: ${checking.Balance:0.00}");
			MyConsole.PrintL($"Savings: ${savings.Balance:0.00}\n" + "======================================== Goodbye =================");
		}
	}
}
