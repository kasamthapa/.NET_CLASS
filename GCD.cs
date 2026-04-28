using System;

class Program {
    static void Main() {
        int a = 24, b = 36;

        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine("GCD = " + a);
    }
}
