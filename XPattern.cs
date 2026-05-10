using System;

class Program
{
    static void Main()
    {
        int n = 5;

        for (int i = 1; i <= 2 * n - 1; i++)
        {
            for (int j = 1; j <= 2 * n - 1; j++)
            {
                if (j == i || j == 2 * n - i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}