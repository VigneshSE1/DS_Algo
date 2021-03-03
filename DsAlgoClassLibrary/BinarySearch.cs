using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgoClassLibrary
{
    public class BinarySearch
    {
        public int RBinarySearch(int[] arr, int leftIndex, int rightIndex, int findElement)
        {
            if (rightIndex >= leftIndex)
            {
                int midIndex = leftIndex + (rightIndex - leftIndex) / 2;

                if (arr[midIndex] == findElement)
                {
                    return midIndex;
                }

                if (arr[midIndex] > findElement)
                {
                    return RBinarySearch(arr, leftIndex, midIndex - 1, findElement);
                }

                return RBinarySearch(arr, midIndex + 1, rightIndex, findElement);
            }
            return -1;
        }
    }
}
