namespace OOP.Models.Account;

class SavingAccount : Account
{
	public void AddInterest()
	{
		Balance += Balance * 0.1m;
	}
}