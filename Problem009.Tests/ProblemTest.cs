using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem009.Lib;

namespace Problem009.Tests
{
    /*
     * This problem was asked by Airbnb.

Given a list of integers, write a function that returns the largest sum of non-adjacent numbers. Numbers can be 0 or negative.

For example, [2, 4, 6, 2, 5] should return 13, since we pick 2, 6, and 5. [5, 1, 1, 5] should return 10, since we pick 5 and 5.

Follow-up: Can you do this in O(N) time and constant space?
     */
    [TestClass]
    public class ProblemTest
    {
        [TestMethod]
        public void ReferenceTest1()
        {
            var refList = new[] { 2, 4, 6, 2, 5 };
            var result = Problem.LargestNonAdjacentNumbersSum(refList);
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void ReferenceTest2()
        {
            var refList = new[] { 5, 1, 1, 5 };
            var result = Problem.LargestNonAdjacentNumbersSum(refList);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void SingleTest()
        {
            var list = new[] { -2 };
            var result = Problem.LargestNonAdjacentNumbersSum(list);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TwoTest()
        {
            var list = new[] { 2, 10 };
            var result = Problem.LargestNonAdjacentNumbersSum(list);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TrickyTest1()
        {
            var list = new[] { 100, 1, -50, -10, 100 };
            var result = Problem.LargestNonAdjacentNumbersSum(list);
            Assert.AreEqual(200, result);
        }

        [TestMethod]
        public void TrickyTest2()
        {
            var list = new[] { 100, 1, 120, 100, 1, 100, 200 };
            var result = Problem.LargestNonAdjacentNumbersSum(list);
            Assert.AreEqual(421, result);
        }

        [TestMethod]
        public void TrickyTest3()
        {
            var list = new[] { 750, 1000, 750, 1 };
            var result = Problem.LargestNonAdjacentNumbersSum(list);
            Assert.AreEqual(1500, result);
        }

        [TestMethod]
        public void RandomTest1()
        {
            var list = new[] { 19, 31, 50, 100, 26, 60, 87, 89, 29, 94 };
            var result = Problem.LargestNonAdjacentNumbersSum(list);
            Assert.AreEqual(374, result);
        }

        [TestMethod]
        public void RandomTest2()
        {
            var list = new[] { 35, 7, 38, 30, 14, 57, 59, 16, 17, 100 };
            var result = Problem.LargestNonAdjacentNumbersSum(list);
            Assert.AreEqual(246, result);
        }
    }
}
