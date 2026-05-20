using OOP.Models.Animal;
using OOP.Models.Transport;
using OOP.Models.Person;
using OOP.Models.Account;

// 1-TASK — Animal System (Easy)
Dog dog = new Dog();
dog.Name = "Rex";
dog.Eat();
dog.Bark();
Cat cat = new Cat();
cat.Name = "Murka";
cat.Eat();
cat.Meow();


// 2-TASK — Transport System (Easy-Medium)
Car car = new Car();
car.Brand = "Audi";
car.Move();
car.Drive();
Bike bike = new Bike();
bike.Brand = "Yamaha";
bike.Move();
bike.Ride();
Train train = new Train();
train.Brand = "Talgo";
train.Move();
train.CarryPassengers();

// 4-TASK — Constructor va base() (Medium)
Student student = new Student("Ali", 5);
Teacher teacher = new Teacher("Hasan", "Math");

// 5-TASK — protected ishlatish (Medium)
Dog bobik = new Dog();
bobik.Name = "Bobik";
bobik.SetAge(24);
bobik.ShowAge();

// 7-TASK — Bank System (Strongest)
Account account = new Account();
account.Balance = 100;
account.Deposit(300);
account.ShowBalance();