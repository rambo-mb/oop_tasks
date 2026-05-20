namespace OOP.Models.Transport;

class Car : Transport
{
	public void Drive()
	{
		Console.WriteLine($"{this.Brand} is driving");
	}
}