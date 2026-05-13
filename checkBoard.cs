using System;

class Program
{
    static void Main()
    {
        int n = 5;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
                Console.Write(" ");

            for (int j = 1; j <= n; j++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}