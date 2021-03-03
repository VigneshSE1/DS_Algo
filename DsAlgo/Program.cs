using System;

namespace DsAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int find = 10;

            int result = BinarySearch(arr, 0, n - 1, find);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index " + result);
        }
        static int BinarySearch(int[] arr, int leftIndex, int rightIndex, int findElement)
        {
            if (rightIndex >= leftIndex)
            {
                int midIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (arr[midIndex] == findElement)
                    return midIndex; 

                if (arr[midIndex] > findElement)
                    return BinarySearch(arr, leftIndex, midIndex - 1, findElement);

                return BinarySearch(arr, midIndex + 1, rightIndex, findElement);
            }
            return -1;
        }
    }
}
