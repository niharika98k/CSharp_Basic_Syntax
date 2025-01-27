
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Buddy");
        Cat cat = new Cat("Whiskers");

        List<Animal> animals = new List<Animal> { dog, cat };

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            animal.Describe();

            if (animal is IPet pet)
            {
                pet.Play();
            }

            Console.WriteLine();
        }
    }
}
