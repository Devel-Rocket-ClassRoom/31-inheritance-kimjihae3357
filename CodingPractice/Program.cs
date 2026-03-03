using System;
using System.ComponentModel;
using System.Xml.Serialization;
/*
// 1-1

Child child = new Child();
child.Greet();
child.Stydy();

class Parent
{
    public CodeIdentifier Greet()
    {
        Console.WriteLine("안녕하세요");
    }
}

class Child : Parent
{
    public viod Study()
    {
        Console.WriteLine("공부합니다.");
    }
}

// 1-2

Dog dog = new Dog();
dog.Name = "초코";
dog.Eat();
dog.Bark();

Cat cat = new Cat();
cat.Name = "나비";
cat.Eat();
cat.Meow();

class Animal
{
    public string Name;

    public void Eat()
    {
        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine($"{Name}이(가) 야옹 웁니다.");
    }
}

// 2

Product product = new Product { Name = "키보드", Price = 50000 };

Console.WriteLine(product.ToString());
Console.WriteLine(product.GetType());

class Product
{
    public string Name;
    public int Price;
}


// 3

Child child = new Child();
child.ShowValues();
Console.WriteLine(child.PublicValue);

class Parent
{
    private int _privateValue = 1;
    protected int _protectedValue = 2;
    public int PublicValue = 3;
}

class Child : Parent
{
    public void ShowValues()
    {
        Console.WriteLine(_protectedValue);
        Console.WriteLine(PublicValue);
    }
}



// 4

Manager manager = new Manager();
manager.ShowInfo();

class Employee
{
    protected string _department = "개발팀";
    public void ShowDepartment()
    {
        Console.WriteLine($"부서: {_department}");
    }
}

class Manager : Employee
{
    public void ShowInfo()
    {
        Console.WriteLine($"소속 부서: {base._department}");

        base.ShowDepartment();
    }
}

// 5-1

Student student = new Student("홍길동", 3);
Console.WriteLine($"이름: {student.Name}, 학년: {student.Grade}");

class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
        Console.WriteLine($"Person 생성자 호출: {name}");
    }
}

class Student : Person
{
    public int Grade;

    public Student(string name, int grade) : base(name)
    {
        Grade = grade;
        Console.WriteLine($"Student 생성자 호출: {grade}학년");
    }
}

// 5-2

Dog dog = new Dog();

class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal 기본 생성자");
    }
}

class Dog : Animal
{
    public Dog()
    {
        Console.WriteLine("Dog 생성자");
    }
}

// 6-1

Dog dog = new Dog { Name = "멍멍이" };
Animal animal = dog;
animal.Eat();


// 6-2

Dog dog = new Dog { Name = "멍멍이" };
Animal animal = dog;

Dog dog2 = (Dog)animal;
dog2.Bark();
*/
// 6-3

Animal animal = new Dog { Name = "멍멍이" };

if (animal is Dog)
{
    Dog dog = (Dog)animal;
    dog.Bark();
}

// 6-4

Animal animal = new Dog { Name = "멍멍이" };

if (animal is Dog dog)
{
    dog.Bark();
}

// 6-5

Animal animal = new CategoryAttribute { Name = "야옹이" };

Dog dog = animal as Dog;
if(dog != null)
{
    dog.Bark();
}
else
{
    Console.WriteLine("Dog 타입이 아닙니다.");
}

class Animal
{
    public string Name;
    public void Eat() => Console.WriteLine($"{Name}이(가) 먹습니다.");
}

class Dog : Animal
{
    public void Bark() => Console.WriteLine($"{Name}이(가) 짖습니다.");
}

// 7

Asset[] assets = new Asset[3];
assets[0] = new Stock { Name = "삼성전자", Shares = 100 };
assets[1] = new House { Name = "아파트", Mortgage = 300000000 };
assets[2] = new Stock { Name = "SK하이닉스", Shares = 50 };

foreach (Asset asset in assets)
{
    Console.WriteLine(asset.Name)
}
class Asset
{
    public string Name;
}

class Stock : Asset
{
    public int Shares;
}

class House : Asset
{
    public decimal Mortgage;
}

// 8-1

