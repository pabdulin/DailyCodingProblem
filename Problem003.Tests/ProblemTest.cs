using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem003.Lib;
using System.Text;

namespace Problem003.Tests
{
    /* Daily Coding Problem: Problem #3 [Medium]
Given the root to a binary tree, implement serialize(root), which serializes the tree into a string, and deserialize(s), which deserializes the string back into the tree.
For example, given the following Node class

class Node:
def __init__(self, val, left=None, right=None):
self.val = val
self.left = left
self.right = right

The following test should pass:

node = Node('root', Node('left', Node('left.left')), Node('right'))
assert deserialize(serialize(node)).left.left.val == 'left.left'
*/

    [TestClass]
    public class ProblemTest
    {
        [TestMethod]
        public void TestReference()
        {
            var reference = new Node("root", left: new Node("left", new Node("left.left")), right: new Node("right"));
            var refSerialized = Problem.Serialize(reference, new StringBuilder());
            var refDeserialized = Problem.Deserialize(refSerialized);
            Assert.AreEqual("left.left", refDeserialized.Left.Left.Val);
        }

        [TestMethod]
        public void TestJustRoot()
        {
            var testTree = new Node("root");
            var treeSerialized = Problem.Serialize(testTree, new StringBuilder());
            var treeDeserialized = Problem.Deserialize(treeSerialized);
            Assert.AreEqual("root", treeDeserialized.Val);
        }

        [TestMethod]
        public void TestNull()
        {
            Node testTree = null;
            var treeSerialized = Problem.Serialize(testTree, new StringBuilder());
            var treeDeserialized = Problem.Deserialize(treeSerialized);
            Assert.IsNull(treeDeserialized);
        }
    }
}
