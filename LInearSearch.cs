using System;

class Program {
    static void Main() {
        int[] arr = { 10, 20, 30, 40 };
        int target = 30;
        bool found = false;

        foreach (int num in arr) {
            if (num == target) {
                found = true;
                break;
            }
        }

        Console.WriteLine(found ? "Found" : "Not Found");
    }
}
