using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++) // rows
        {
            for (int j = 1; j <= 5; j++) // columns
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}