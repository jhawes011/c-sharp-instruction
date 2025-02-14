using ConsoleLibrary;

namespace joe_hawes_account_balance_calculator.Model
{
	public class CheckingAccount : Account
	{
		public double MonthlyFee { get; set; }
		public CheckingAccount(double initialBalance, double fee) : base(initialBalance)
		{
			MonthlyFee = fee;
		}

		public void ApplyMonthlyFee()
		{
			Balance -= MonthlyFee;
		}
	}
}
