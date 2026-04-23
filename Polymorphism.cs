using System;

// Base class
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks.");
    }
}

// Derived class
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks.");
    }
}

// Another derived class
class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Program
{
    static void Main()
    {
        // Polymorphism in action (Method Overriding)
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myDog.Speak(); // Output: Dog barks.
        myCat.Speak(); // Output: Cat meows.
    }
}
