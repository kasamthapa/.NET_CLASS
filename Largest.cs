using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 12, 3, 21, 8 };

        int largest = numbers[0]; // assume first element is largest

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num; // update largest
            }
        }

        Console.WriteLine("Largest number is: " + largest);
    }
}
