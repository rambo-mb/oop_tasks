namespace OOP.Models.Animal;

class Animal
{
	public string Name { get; set; } 
	protected int Age { get; set; }

	public void Eat()
	{
		Console.WriteLine($"{this.Name} is eating");
	}
}