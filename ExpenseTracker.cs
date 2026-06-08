using System;

class Program
{
    static void Main()
    {
        double total = 0;

        while (true)
        {
            Console.Write("Enter expense (0 to stop): ");
            double expense = double.Parse(Console.ReadLine());

            if (expense == 0)
                break;

            total += expense;
        }

        Console.WriteLine($"Total Expenses: Rs. {total}");
    }
}