using System;

class Program {
    static void Main() {
        string str = "hello world";
        int count = 0;

        foreach (char c in str) {
            if ("aeiouAEIOU".Contains(c))
                count++;
        }

        Console.WriteLine("Vowels: " + count);
    }
}
