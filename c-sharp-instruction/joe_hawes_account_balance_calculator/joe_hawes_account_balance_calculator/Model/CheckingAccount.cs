using ConsoleLibrary;

namespace joe_hawes_account_balance_calculator.Model
{
	public class CheckingAccount : Account
	{
		public decimal MonthlyFee { get; set; }
		public CheckingAccount(decimal initialBalance, decimal fee) : base(initialBalance)
		{
			MonthlyFee = fee;
		}

		public void ApplyMonthlyFee()
		{
			Balance -= MonthlyFee;
		}
	}
}
