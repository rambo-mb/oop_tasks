namespace OOP.Models.Account;

class CreditAccount : Account
{
	public void TakeCreadit(decimal amount)
	{
		Balance += amount;
	}
}