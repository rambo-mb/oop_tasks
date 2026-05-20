namespace OOP.Models.Person;

class Person
{
	public string Name { get; set; }

	public Person(string name)
	{
		this.Name = name;
		Console.WriteLine($"Name: {this.Name}");
	}
}