using System;

namespace Problem003.Lib
{
    public static class Problem
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

        public static string Serialize(Node root)
        {
            return string.Empty;
        }

        public static Node Deserialize(string treeStr)
        {
            return new Node(string.Empty);
        }
    }
}
