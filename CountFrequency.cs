using System;

class Program {
    static void Main() {
        int[] arr = { 1, 2, 2, 3, 1 };

        for (int i = 0; i < arr.Length; i++) {
            int count = 1;
            bool visited = false;

            for (int k = 0; k < i; k++) {
                if (arr[i] == arr[k]) {
                    visited = true;
                    break;
                }
            }

            if (visited) continue;

            for (int j = i + 1; j < arr.Length; j++) {
                if (arr[i] == arr[j]) {
                    count++;
                }
            }

            Console.WriteLine(arr[i] + " appears " + count + " times");
        }
    }
}
