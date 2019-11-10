using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem003.Lib;

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
            var reference = new Node("root", new Node("left", new Node("left.left"), new Node("right")));
            var result = Problem.Deserialize(Problem.Serialize(reference));
            Assert.AreEqual("left.left", result.Left.Left.Val);
        }
    }
}
