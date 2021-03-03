using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgoClassLibrary
{
    public class BubbleSort
    {
        public int[] BubbleSorting(int[] inputArray)
        {
            int arraylenth = inputArray.Length;
            for (int i = 0; i < arraylenth - 1; i++)
            {
                for (int j = 0; j < arraylenth - i - 1; j++)
                {
                    if (inputArray[j] > inputArray[j + 1])
                    {
                        // swap temp and arr[i] 
                        int temp = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = temp;
                    }

                }
            }
            Console.WriteLine("fegfs");
            return inputArray;
        }
    }
}
