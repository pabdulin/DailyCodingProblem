using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem005.Lib;

namespace Problem005.Tests
{
    /*
 * Daily Coding Problem: Problem #5 [Medium]
cons(a, b) constructs a pair, and car(pair) and cdr(pair) returns the first and last element of that pair.
For example, car(cons(3, 4)) returns 3, and cdr(cons(3, 4)) returns 4.
Given this implementation of cons:
def cons(a, b):
def pair(f):
    return f(a, b)
return pair

Implement car and cdr.
 */

    [TestClass]
    public class ProblemTest
    {
        [TestMethod]
        public void ReferenceTestCar()
        {
            var result = Problem.car(Problem.cons(3, 4));
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void ReferenceTestCdr()
        {
            var result = Problem.cdr(Problem.cons(3, 4));
            Assert.AreEqual(4, result);
        }
    }
}
