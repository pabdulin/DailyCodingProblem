using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem007.Lib;

namespace Problem007.Tests
{
    /*
 * Daily Coding Problem: Problem #7 [Medium]
This problem was asked by Facebook.

Given the mapping a = 1, b = 2, ... z = 26, and an encoded message, count the number of ways it can be decoded.

For example, the message '111' would give 3, since it could be decoded as 'aaa', 'ka', and 'ak'.

You can assume that the messages are decodable. For example, '001' is not allowed.
 */

    [TestClass]
    public class ProblemTest
    {
        [TestMethod]
        public void ReferenceTest()
        {
            var result = Problem.CountPossibleWaysToDecode("111");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AnotherTest1()
        {
            var result = Problem.CountPossibleWaysToDecode("1111");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void AnotherTest2()
        {
            var result = Problem.CountPossibleWaysToDecode("1511");
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void AnotherTest3()
        {
            var result = Problem.CountPossibleWaysToDecode("262");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SingleTest()
        {
            var result = Problem.CountPossibleWaysToDecode("2");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void EmptyTest()
        {
            var result = Problem.CountPossibleWaysToDecode("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void LongTest()
        {
            var result = Problem.CountPossibleWaysToDecode("1111111");
            Assert.AreEqual(21, result);
        }
    }
}
