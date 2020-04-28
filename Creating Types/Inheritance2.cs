using System;

public class Animal
{
    public string Name
        { private set; get; }
    public bool Shedding
        { set; get; } = false;

    public int Legs
        { private set; get; } = 4;

    public Animal(string name) => Name = name;
    public Animal() => Name = "Un-named";
}

public class Cat : Animal
{
    public Cat() : base() {}
    public Cat(string name) : base(name) {}
}

public class Dog : Animal
{
    public Dog() : base() {}
    public Dog(string name) : base(name) {}
}

public class Inheritance2
{
    public static void Main()
    {
        Cat meowser = new Cat();
        Dog shelly = new Dog("Shelly");

        Console.WriteLine($"meowser.Name: {meowser.Name}");
        Console.WriteLine($"shelly.Name: {shelly.Name}");
        Console.WriteLine($"meowser.Legs: {meowser.Legs}");
        Console.WriteLine($"shelly.Legs: {shelly.Legs}");
        shelly.Shedding = true;
        Console.WriteLine($"meowser.Shedding: {meowser.Shedding}");
        Console.WriteLine($"shelly.Shedding: {shelly.Shedding}");

        // Polymorphism
        Console.WriteLine();
        Cat cat = new Cat("Loopy");
        Dog dog = new Dog("Doopy");
        DisplayAnimalName(cat);
        DisplayAnimalName(dog);
    }

    public static void DisplayAnimalName(Animal animal)
    {
        System.Console.WriteLine($"The {nameof(animal)} is named {animal.Name}");
    }
}