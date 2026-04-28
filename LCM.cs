using System;

class Program {
    static void Main() {
        int a = 12, b = 15;
        int max = (a > b) ? a : b;

        while (true) {
            if (max % a == 0 && max % b == 0) {
                Console.WriteLine("LCM = " + max);
                break;
            }
            max++;
        }
    }
}
