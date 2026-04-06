using System;

class Car
{
    public string brand;
    public int speed;
    public static int carCount;


    static Car()
    {
        carCount = 0;
        Console.WriteLine("Static Constructor Called");
    }


    public Car()
    {
        brand = "Unknown";
        speed = 0;
        carCount++;
        Console.WriteLine("Default Constructor Called");
    }


    public Car(string b, int s)
    {
        brand = b;
        speed = s;
        carCount++;
        Console.WriteLine("Parameterized Constructor Called");
    }


    ~Car()
    {
        Console.WriteLine("Car object destroyed by Garbage Collector");
    }

    public void Display()
    {
        Console.WriteLine("Brand: " + brand + ", Speed: " + speed);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car c1 = new Car();
        c1.Display();

        Car c2 = new Car("Toyota", 120);
        c2.Display();

        Console.WriteLine("Total Cars: " + Car.carCount);



        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Garbage Collection Completed");
    }
}