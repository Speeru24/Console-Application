using System;

class Arrays
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Arrays..");

        int[] intArray = new int[5];
        intArray[0] = 45;
        intArray[1] = 5;
        intArray[2] = 25;
        intArray[3] = 35;
        intArray[4] = 15;

        sortArray(intArray);
        //Array.Sort(intArray);
        printArray(intArray);

        Console.WriteLine("\nReverse an Array...");
        Array.Reverse(intArray);
        printArray(intArray);
        Console.WriteLine();
        printUsingForEach(intArray);
        Array.Clear(intArray,2,2);//sETS index to default value
        printArray(intArray);

        int[] intArray2 = new int[5];
        Array.Copy(intArray, intArray2, intArray.Length);
        printArray(intArray2);
        Console.ReadLine();
    }
    
    public static void printArray(int[] intArray)
    {
        Console.Write("\nEntered Elements Are : ");

        for (int i = 0; i < intArray.Length; i++)
        {
            Console.Write(" " + intArray[i]);
        }
        
    }

    public static void sortArray(int[] intArray)
    {
        Console.Write("\nEntered Elements Are : 45 5 25 35 15");
        
        Console.Write("\nSort Elements Are : ");
        int temp;
        for (int i = 0; i < intArray.Length; i++)
        {
            for (int j = 0; j < intArray.Length - 1; j++)
            {
                if (intArray[j] > intArray[j + 1])
                {
                    temp = intArray[j];
                    intArray[j] = intArray[j + 1];
                    intArray[j + 1] = temp;
                }
            }
        }
    }

    static void printUsingForEach(int[] intArray)
    {
        foreach(int i in intArray)
        {
            Console.Write(i + " ");
        }
    }
}