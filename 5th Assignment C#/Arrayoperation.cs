using System;
namespace ArrayOperation
{
    class Arrayoperation
    {
        static void Main(string[] args)
        {
            // Creating an array  
            int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
            // Creating an empty array  
            int[] arr2 = new int[6];
            // Displaying length of array  
            Console.WriteLine("length of first array: " + arr.Length);
            // Sorting array  
            Array.Sort(arr);
            Console.Write("First array elements: ");
            // Displaying sorted array  
            PrintArray(arr);
            Array.Reverse(arr);
            Console.Write("\nFirst Array elements in reverse order: ");
            PrintArray(arr);
            Array.Copy(arr, arr2, 5);
            Console.WriteLine("\n copied elements ");
            PrintArray(arr2);
            Console.WriteLine("\n Array Clear");
            Array.Clear(arr,0,arr.Length);
            PrintArray(arr);
        }
        // User defined method for iterating array elements  
        static void PrintArray(int[] arr)
        {
            foreach (Object elem in arr)
            {
                Console.Write(elem + " ");
            }
        }
    }
}