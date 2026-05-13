using System;

class Program
{
    static void Main()
    {
        int n = 5;

        // upper
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");

            for (int j = 1; j <= i; j++)
                Console.Write(j + " ");

            Console.WriteLine();
        }

        // lower
        for (int i = 2; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");

            for (int j = 1; j <= i; j++)
                Console.Write(j + " ");

            Console.WriteLine();
        }
    }
}