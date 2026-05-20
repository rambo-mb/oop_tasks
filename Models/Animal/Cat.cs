namespace OOP.Models.Animal;

class Cat : Animal
{
	public void Meow()
	{
		Console.WriteLine($"{this.Name} is meowing");
	}
}