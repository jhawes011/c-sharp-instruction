using ConsoleLibrary;

namespace joe_hawes_account_balance_calculator.Model
{
	public class SavingsAccount : Account
	{
		public double MonthlyInterestRate { get; set; }
		public double MonthlyInterestPayment { get; private set; }

		public SavingsAccount(double initialBalance, double interestRate) :  base(initialBalance)
		{ 
			MonthlyInterestRate = interestRate;
			
		}


		public void ApplyInterest()
		{
			MonthlyInterestPayment = Balance * MonthlyInterestRate;
			Balance = MonthlyInterestPayment + Balance;
		}
		 
	}
}
