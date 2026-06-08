using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        bool hasUpper = password.Any(char.IsUpper);
        bool hasLower = password.Any(char.IsLower);
        bool hasDigit = password.Any(char.IsDigit);
        bool hasSpecial = password.Any(ch => !char.IsLetterOrDigit(ch));

        if (password.Length >= 8 && hasUpper && hasLower && hasDigit && hasSpecial)
            Console.WriteLine("Strong Password");
        else
            Console.WriteLine("Weak Password");
    }
}