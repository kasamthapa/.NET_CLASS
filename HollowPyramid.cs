using System;

class Program
{
    static void Main()
    {
        int n = 5;

        for (int i = 1; i <= n; i++)
        {
            // spaces
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            // stars and spaces
            for (int j = 1; j <= (2 * i - 1); j++)
            {
                if (j == 1 || j == (2 * i - 1) || i == n)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}