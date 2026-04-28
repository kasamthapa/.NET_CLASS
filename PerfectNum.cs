using System;

class Program {
    static void Main() {
        int num = 28;
        int sum = 0;

        for (int i = 1; i < num; i++) {
            if (num % i == 0) {
                sum += i;
            }
        }

        if (sum == num)
            Console.WriteLine("Perfect Number");
        else
            Console.WriteLine("Not Perfect Number");
    }
}
