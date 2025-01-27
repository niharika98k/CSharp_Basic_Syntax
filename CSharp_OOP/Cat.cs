
using System;

public class Cat : Animal, IPet
{
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }

    public override void Describe()
    {
        Console.WriteLine($"This is a cat named {Name}. Cats are independent and curious.");
    }

    public void Play()
    {
        Console.WriteLine($"{Name} is chasing the laser pointer.");
    }
}
