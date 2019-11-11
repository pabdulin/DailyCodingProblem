using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem004.Lib;

namespace Problem004.Tests
{
    /*
     * Daily Coding Problem: Problem #4 [Hard]

Given an array of integers, find the first missing positive integer in linear time and constant space. In other words, find the lowest positive integer that does not exist in the array. The array can contain duplicates and negative numbers as well.
For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
You can modify the input array in-place.
     */

    [TestClass]
    public class ProblemTest
    {
        [TestMethod]
        public void ReferenceTest1()
        {
            var data = new[] { 3, 4, -1, 1 };
            var result = Problem.FindMissing(data);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ReferenceTest2()
        {
            var data = new[] { 1, 2, 0 };
            var result = Problem.FindMissing(data);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FullSequenceTest()
        {
            var data = new[] { 1, 2, 3, 4, 5 };
            var result = Problem.FindMissing(data);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void SingleValidTest()
        {
            var data = new[] { -1, -2, 3, -4, -5 };
            var result = Problem.FindMissing(data);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void NoneValidTest()
        {
            var data = new[] { -1, -2, -3, -4, -5 };
            var result = Problem.FindMissing(data);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void DuplicateTest()
        {
            var data = new[] { 1, 1, 1, 1, 1 };
            var result = Problem.FindMissing(data);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void LargeGapTest()
        {
            var data = new[] { 1, 1, 1, 1, 10000 };
            var result = Problem.FindMissing(data);
            Assert.AreEqual(2, result);
        }
    }
}
