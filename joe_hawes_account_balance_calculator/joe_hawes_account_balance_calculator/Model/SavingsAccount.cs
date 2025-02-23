using ConsoleLibrary;

namespace joe_hawes_account_balance_calculator.Model
{
	public class SavingsAccount : Account
	{
		public decimal MonthlyInterestRate { get; set; }
		public decimal MonthlyInterestPayment { get; private set; }

		public SavingsAccount(decimal initialBalance, decimal interestRate) :  base(initialBalance)
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
