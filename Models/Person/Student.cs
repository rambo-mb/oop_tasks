namespace OOP.Models.Person;

class Student : Person
{
	public int Grade { get; set; }

	public Student(string name, int grade) : base(name)
	{
		this.Grade = grade;
		Console.WriteLine($"Grade: {this.Grade}");
	}
}