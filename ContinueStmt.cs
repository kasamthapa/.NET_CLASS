using System;

class Program {
    static void Main() {
        for (int i = 1; i <= 5; i++) {
            if (i == 3) {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}
