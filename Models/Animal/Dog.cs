namespace OOP.Models.Animal;

class Dog : Animal
{
	public void Bark()
	{
		Console.WriteLine($"{this.Name} is barking");
	}

	public void SetAge(int age)
	{
		this.Age = age;
	}

	public void ShowAge()
	{
		Console.WriteLine($"{this.Name} is {this.Age}");
	}
	
}