using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>() { "Kasam", "John", "Alex" };

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}