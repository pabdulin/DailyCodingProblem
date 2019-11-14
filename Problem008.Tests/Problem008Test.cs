using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem008.Lib;

namespace Problem008.Tests
{
    /*
     * Daily Coding Problem: Problem #8 [Easy]
This problem was asked by Google.

A unival tree (which stands for "universal value") is a tree where all nodes under it have the same value.

Given the root to a binary tree, count the number of unival subtrees.

For example, the following tree has 5 unival subtrees:

   0
  / \
 1   0
    / \
   1   0
  / \
 1   1
     */
    [TestClass]
    public class Problem008Test
    {
        [TestMethod]
        public void ReferenceTest()
        {
            var tree = new Node(0,
                left: new Node(1), 
                right: new Node(0,
                    left: new Node(1, 
                        left: new Node(1), 
                        right: new Node(1)), 
                    right: new Node(0)));

            var result = Problem.CountInivalTrees(tree);
            Assert.AreEqual(5, result);
        }
    }
}
