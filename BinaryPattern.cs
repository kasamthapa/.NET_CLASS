using System;

class Program
{
    static void Main()
    {
        int n = 5;

        for (int i = 1; i <= n; i++)
        {
            int num = i % 2;

            for (int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num = 1 - num;
            }

            Console.WriteLine();
        }
    }
}