using System;

class Program {
    static void Main() {
        int[] arr = { 1, 2, 2, 3, 4, 4 };
        
        for (int i = 0; i < arr.Length; i++) {
            bool isDuplicate = false;

            for (int j = 0; j < i; j++) {
                if (arr[i] == arr[j]) {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
                Console.Write(arr[i] + " ");
        }
    }
}
