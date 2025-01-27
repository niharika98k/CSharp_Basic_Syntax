
using System;

public class Dog : Animal, IPet
{
    public Dog(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Bark!");
    }

    public override void Describe()
    {
        Console.WriteLine($"This is a dog named {Name}. Dogs are loyal and friendly.");
    }

    public void Play()
    {
        Console.WriteLine($"{Name} is fetching the ball.");
    }
}
