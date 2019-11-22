using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem012.Lib;

namespace Problem012.Tests
{
    /*
     * Daily Coding Problem: Problem #12 [Hard]
This problem was asked by Amazon.

There exists a staircase with N steps, and you can climb up either 1 or 2 steps at a time. 
Given N, write a function that returns the number of unique ways you can climb the staircase. 
The order of the steps matters.

For example, if N is 4, then there are 5 unique ways:

1, 1, 1, 1
2, 1, 1
1, 2, 1
1, 1, 2
2, 2

What if, instead of being able to climb 1 or 2 steps at a time, you could climb any number from a set of positive integers X? 
For example, if X = {1, 3, 5}, you could climb 1, 3, or 5 steps at a time.
     */
    [TestClass]
    public class ProblemTest
    {
        [TestMethod]
        public void ReferenceTest()
        {
            var result = Problem.NumberOfWays(4, new[] { 1, 2 });
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void SingleTest()
        {
            var result = Problem.NumberOfWays(4, new[] { 1 });
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CustomTest1()
        {
            var result = Problem.NumberOfWays(4, new[] { 1, 2, 3, 4 });
            Assert.AreEqual(5 + 2 + 1, result);
        }
    }
}
