using ConsoleLibrary;
using joe_hawes_account_balance_calculator.Model.Interfaces;

namespace joe_hawes_account_balance_calculator.Model
{
	public abstract class Account : IDepositable, IWithdrawable, IBalanceable
	{
		public decimal Balance { get; set; }
		
		public Account(decimal initialBalance)
		{
			Balance = initialBalance;
		}
		public void Deposit(decimal amount)
		{
			if (amount > 0)
			Balance += amount;
		}
		public void Withdraw(decimal amount)
		{
			if (amount > 0 && amount <= Balance)
				Balance -= amount;
			else 
				MyConsole.PrintL("Error: Insufficient Funds Sucka!!!!!");
		}


	}
}
