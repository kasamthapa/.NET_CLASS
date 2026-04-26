using System;

class Program {
    static void Main() {
        int n = 10;
        int a = 0, b = 1;

        Console.Write(a + " " + b + " ");

        for (int i = 2; i < n; i++) {
            int next = a + b;
            Console.Write(next + " ");
            a = b;
            b = next;
        }
    }
}
