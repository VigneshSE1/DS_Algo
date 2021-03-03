using Microsoft.VisualStudio.TestTools.UnitTesting;
using DsAlgoClassLibrary;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int[] bubbleSortArray = { 91, 90, 34, 9, 4 };
            int[] crtBubbleSortArray = { 4, 9, 34, 90, 91 };
            int n = arr.Length;
            int find = 10;
            DsAlgoClassLibrary.BinarySearch b = new DsAlgoClassLibrary.BinarySearch();
            DsAlgoClassLibrary.BubbleSort bubble = new DsAlgoClassLibrary.BubbleSort();

            //int result = b.RBinarySearch(arr, 0, n - 1, find);
            int[] bubbleSortResult = bubble.BubbleSorting(bubbleSortArray);
            
            
            
            CollectionAssert.AreEqual(bubbleSortResult, crtBubbleSortArray);
        }
    }
}
