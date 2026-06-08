using System;

class Program
{
    static void Main()
    {
        string[] books =
        {
            "C# Basics",
            "Data Structures",
            "Database Systems",
            "Web Development",
            "Machine Learning"
        };

        Console.Write("Enter book name: ");
        string search = Console.ReadLine();

        bool found = false;

        foreach (string book in books)
        {
            if (book.Equals(search, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                break;
            }
        }

        Console.WriteLine(found ? "Book Found" : "Book Not Found");
    }
}