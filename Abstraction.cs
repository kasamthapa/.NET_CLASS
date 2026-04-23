using System;

// Abstract class
abstract class Shape
{
    public abstract void Draw(); // Abstract method

    public void Display()
    {
        Console.WriteLine("Displaying the shape.");
    }
}

// Derived class
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Program
{
    static void Main()
    {
        // Cannot instantiate an abstract class
        // Shape shape = new Shape(); // Error

        // Can instantiate a derived class
        Shape circle = new Circle();
        circle.Draw();   // Output: Drawing a circle.
        circle.Display(); // Output: Displaying the shape.
    }
}