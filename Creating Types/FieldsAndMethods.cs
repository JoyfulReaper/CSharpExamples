using System;
class Octopus // A class is a reference type
{
    // Fields: variables that are members of a class or a struct
    string name; // Name field
    public int age = 10; // Optional field initialization
    static readonly int legs = 8, eyes = 2; // declare two readonly fields at the same time. Readonly fields can not be changed after they are initialized
    public int HungerPercent {get; private set;} = 0; // Simple propertie

    // Instance methods
    public bool isHungry()
    {
        return hungerPercent > 60;
    }
    // Method consisting of a single expression can be expressed as an expression-bodied method
    public void Eat(int amount) => HungerPercent -= amount; 
    // Overloaded method (two methods with the same name)
    public void Eat(string amount) => HungerPercent -= Int32.Parse(amount);

    public void Digest(int amount) => HungerPercent += amount;

    public static void Main()
    {
        Octopus o = new Octopus();
        if (o.isHungry())
            Console.WriteLine("The octopus is hungry!\n");
        else
            Console.WriteLine("The octopus isn't hungry!\n");
        
        o.Digest(75);
        Console.WriteLine("The octopus is {0}% hungry", o.HungerPercent);
        Console.WriteLine("Feeding the octopus with an int...");
        o.Eat(10);
        Console.WriteLine("The octopus is {0}% hungry", o.HungerPercent);
        Console.WriteLine("Feeding the octopus with a string...");
        o.Eat("10");
        Console.WriteLine("The octopus is {0}% hungry", o.HungerPercent);
    }
}

