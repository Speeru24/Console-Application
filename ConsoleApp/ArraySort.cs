using System;

public class Program {
    public static void Main () {
        int[] arr = { 9, 6, -3, 1, 7, 1, 4 };

        for (int a = 0; a < arr.Length; a++)
            Console.Write (arr[a] + ' ');
        Console.WriteLine ();

        // i =0 -> 
        // i = 2 -> skip 
        for (int i = 0; i < arr.Length; i++) {
            {
                if (arr[i] > 0) {
                    for (int j = 1; j < arr.Length; j++) {
                        {
                            // 9 > 6  -> {6,9,-3,1,7,1,4}
                            // 6 > -3 -> skip {6,9,-3,1,7,1,4}
                            // 6 > 1  -> {1,9,-3,6,7,1,4}
                            // 1 > 7 -> skip
                            if (arr[j] > 0) {
                                if (arr[i] > arr[j]) {
                                    {
                                        var number = arr[i];
                                        arr[i] = arr[j];
                                        arr[j] = number;
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }

        for (int a = 0; a < arr.Length; a++)
            Console.Write (arr[a]);
        Console.ReadLine ();
    }
}