namespace OOP.Models.Account;

class Account
{
	private decimal _balance;

	public decimal Balance 
	{ 
		get
		{
			return _balance;
		}
		set
		{
			if (value >= 0)
			{
				_balance = value;
			}
		} 
	}

	public void Deposit(decimal amount)
	{
		if(amount < 0)
		{
			Console.WriteLine("Amount must be positive");
			return;
		}

		Balance += amount;
	}

	public void ShowBalance()
	{
		Console.WriteLine($"Balance is {this.Balance}");
	}
}