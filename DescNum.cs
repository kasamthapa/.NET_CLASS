using System;

class Program
{
    static void Main()
    {
        int n = 5;

        for (int i = n; i >= 1; i--)
        {
            for (int j = n; j >= n - i + 1; j--)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }
}