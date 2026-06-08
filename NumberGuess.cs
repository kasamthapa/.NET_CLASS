using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secret = random.Next(1, 101);

        int guess;

        do
        {
            Console.Write("Guess a number (1-100): ");
            guess = int.Parse(Console.ReadLine());

            if (guess < secret)
                Console.WriteLine("Too low!");
            else if (guess > secret)
                Console.WriteLine("Too high!");

        } while (guess != secret);

        Console.WriteLine("Correct! You guessed it.");
    }
}