using System;

class Animal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine(Name + " is eating.");
    }
}


class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine(Name + " barks!");
    }
}

class Program
{
    static void Main()
    {
        
        Dog dog = new Dog();
        dog.Name = "Buddy";

        dog.Eat();  
        dog.Bark(); 
    }
}