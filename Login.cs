using System;

class Program
{
    static void Main()
    {
        string username = "admin";
        string password = "1234";

        Console.Write("Enter username: ");
        string user = Console.ReadLine();

        Console.Write("Enter password: ");
        string pass = Console.ReadLine();

        if (user == username && pass == password)
            Console.WriteLine("Login Successful");
        else
            Console.WriteLine("Invalid Credentials");
    }
}