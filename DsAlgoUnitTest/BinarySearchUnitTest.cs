using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAlgoUnitTest
{
    [TestClass]
    class BinarySearchUnitTest
    {
        [TestMethod]
        public void TestBinarySearch()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int find = 10;
            var xx =  BinarySearch(int[] arr, int leftIndex, int rightIndex, int findElement);
            Console.WriteLine(xx);
            Assert.IsTrue(true);
        }
    }

}
