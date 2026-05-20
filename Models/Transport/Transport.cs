namespace OOP.Models.Transport;

class Transport
{
	public string Brand { get; set; }

	public void Move()
	{
		Console.WriteLine("Transport is moving");
	}
}