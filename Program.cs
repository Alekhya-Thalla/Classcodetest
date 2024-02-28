
/*
Author: Alekhya Thalla
Date: 2/28/2020
Comments: This C# Console Application code demonstrates the
    Selection Sort and Bubble Sort Algorithms. No input
    is required for the script. It will execute without 
    input against two pre-populated arrays.
*/
class Program
{
    static void Main(string[] args)
    {
      
        int[] numbers = { 5, 72, 3, 14, 7, 1 };
        BubbleSort(numbers);

        Console.WriteLine("Sorted numbers using Bubble Sort:");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}

