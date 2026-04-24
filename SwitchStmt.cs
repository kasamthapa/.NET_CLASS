using System;

class Program {
    static void Main() {
        int day = 2;

        switch (day) {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }
    }
}
