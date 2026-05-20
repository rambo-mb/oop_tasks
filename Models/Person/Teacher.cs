namespace OOP.Models.Person;

class Teacher : Person
{
	public string Subject { get; set; }

	public Teacher(string name, string subject) : base(name)
	{
		this.Subject = subject;
		Console.WriteLine($"Subject: {this.Subject}");
	}
}