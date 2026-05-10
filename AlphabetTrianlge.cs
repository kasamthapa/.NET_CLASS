using System;

class Program
{
    static void Main()
    {
        for (char i = 'A'; i <= 'E'; i++)
        {
            for (char j = 'A'; j <= i; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }
    }
}