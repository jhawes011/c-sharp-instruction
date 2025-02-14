using ConsoleLibrary;
using joe_hawes_account_balance_calculator.Model.Interfaces;

namespace joe_hawes_account_balance_calculator.Model
{
	public abstract class Account : Depositable, Withdrawable, Balanceable
	{
		public double Balance { get; set; }
		
		public Account(double initialBalance)
		{
			Balance = initialBalance;
		}
		public void Deposit(double amount)
		{
			if (amount > 0)
			Balance += amount;
		}
		public void Withdraw(double amount)
		{
			if (amount > 0 && amount <= Balance)
				Balance -= amount;
			else 
				MyConsole.PrintL("Error: Insufficient Funds Sucka!!!!!");
		}


	}
}
