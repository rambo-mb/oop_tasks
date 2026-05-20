namespace OOP.Models.Transport;

class Train : Transport
{
	public void CarryPassengers()
	{
		Console.WriteLine($"{this.Brand} is carrying passengers");
	}
}