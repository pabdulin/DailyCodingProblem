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
    public class IsUnivalTest
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

            var result = IsUnivalTestOnThisNode(tree);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SingleTest()
        {
            var tree = new Node(1);
            var result = IsUnivalTestOnThisNode(tree);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TwoTest()
        {
            var tree = new Node(1, new Node(1));
            var result = IsUnivalTestOnThisNode(tree);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ThreeTest1()
        {
            var tree = new Node(1, new Node(1, new Node(1)));
            var result = IsUnivalTestOnThisNode(tree);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ThreeTest2()
        {
            var tree = new Node(1, new Node(1, new Node(0)));
            var result = IsUnivalTestOnThisNode(tree);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ThreeTest3()
        {
            var tree = new Node(1, new Node(0, new Node(1)));
            var result = IsUnivalTestOnThisNode(tree);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ThreeTest4()
        {
            var tree = new Node(1, new Node(1), new Node(1));
            var result = IsUnivalTestOnThisNode(tree);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ThreeTest5()
        {
            var tree = new Node(1, new Node(0), new Node(0));
            var result = IsUnivalTestOnThisNode(tree);
            Assert.AreEqual(0, result);
        }

        private static int IsUnivalTestOnThisNode(Node node)
        {
            return Problem.IsUnival(node, node.Val);
        }
    }
}
