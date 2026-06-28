using System;
using System.Timers;

class Program
{
    // Pet stats
    static string petName = "Gloop";
    static int hunger = 50; // 0 = starving, 100 = full
    static int happiness = 50; // 0 = sad, 100 = thrilled

    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Virtual Pet!");
        Console.Write("Name your pet: ");
        string inputName = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(inputName)) petName = inputName;

        // Set up a timer that ticks every 3 seconds to drain stats
        System.Timers.Timer timer = new System.Timers.Timer(3000);
        timer.Elapsed += GameTick;
        timer.Start();

        // Game Loop
        while (hunger > 0)
        {
            DrawPet();
            Console.WriteLine($"1. Feed {petName} (+20 Hunger)");
            Console.WriteLine($"2. Play with {petName} (+20 Happiness)");
            Console.WriteLine("3. Do nothing");
            Console.Write("Choose an action: ");
            
            string choice = Console.ReadLine();

            if (choice == "1") hunger = Math.Min(100, hunger + 20);
            if (choice == "2") happiness = Math.Min(100, happiness + 20);
        }

        timer.Stop();
        Console.Clear();
        Console.WriteLine($"RIP. {petName} has run away due to neglect. 😢");
    }

    // This runs automatically every 3 seconds
    static void GameTick(object sender, ElapsedEventArgs e)
    {
        hunger -= 10;
        happiness -= 5;

        if (hunger <= 0)
        {
            Console.Clear();
            Console.WriteLine($"Game Over! Press ENTER to exit.");
            Environment.Exit(0); 
        }

        // Refresh the screen automatically when stats change
        DrawPet();
    }

    static void DrawPet()
    {
        Console.Clear();
        Console.WriteLine($"=== {petName}'s Status ===");
        Console.WriteLine($"Hunger:    {hunger}/100");
        Console.WriteLine($"Happiness: {happiness}/100");
        Console.WriteLine("=========================\n");

        // Change how the pet looks based on happiness
        if (happiness > 60)
            Console.WriteLine("   (^_^)  *wags tail*");
        else if (happiness > 30)
            Console.WriteLine("   (._.) ");
        else
            Console.WriteLine("   (T_T)  *whines*");

        Console.WriteLine("\n-------------------------");
    }
}