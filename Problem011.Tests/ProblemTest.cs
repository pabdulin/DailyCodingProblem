using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem011.Lib;
using System;
using System.Linq;

namespace Problem011.Tests
{
    /*
     * Daily Coding Problem: Problem #11 [Medium]
This problem was asked by Twitter.

Implement an autocomplete system. That is, given a query string s and a set of all possible query strings, return all strings in the set that have s as a prefix.

For example, given the query string de and the set of strings [dog, deer, deal], return [deer, deal].

Hint: Try preprocessing the dictionary into a more efficient data structure to speed up queries.
     */
    [TestClass]
    public class ProblemTest
    {
        [TestMethod]
        public void ReferenceTest()
        {
            var sut = new AutocompleteSystem(new string[] { "dog", "deer", "deal" });
            var result = sut.Query("de");
            ArraysEqual(result, new string[] { "deer", "deal" });
        }

        [TestMethod]
        public void SingleTest()
        {
            var sut = new AutocompleteSystem(new string[] { "d", "a", "deer", "deal" });
            var result = sut.Query("d");
            ArraysEqual(result, new string[] { "d", "deer", "deal" });
            result = sut.Query("a");
            ArraysEqual(result, new string[] { "a" });
        }

        [TestMethod]
        public void NotFoundTest()
        {
            var sut = new AutocompleteSystem(new string[] { "d", "a", "deer", "deal" });
            var result = sut.Query("n");
            ArraysEqual(result, new string[] { });
        }

        [TestMethod]
        public void EmptyTest()
        {
            var sut = new AutocompleteSystem(new string[] { "d", "a", "deer", "deal" });
            var result = sut.Query("");
            ArraysEqual(result, new string[] { });
        }

        [TestMethod]
        public void OtherTest1()
        {
            var sut = new AutocompleteSystem(new string[] { "", "d", "a", "deer", "deal", "buzzword", "buz1word" });
            var result = sut.Query("buzz");
            ArraysEqual(result, new string[] { "buzzword" });
        }

        private static void ArraysEqual(string[] actual, string[] expected)
        {
            Assert.AreEqual(expected.Length, actual.Length);
            foreach (var expectedItem in expected)
            {
                Assert.IsTrue(actual.Contains(expectedItem));
            }
        }
    }
}
