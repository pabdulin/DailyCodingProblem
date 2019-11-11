using System;
using System.Text;

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

        private const char ValueTag = '^';
        private const char LeftTag = '<';
        private const char RightTag = '>';
        private const string NullValue = "null";

        public static string Serialize(Node node, StringBuilder s)
        {
            if (node == null)
            {
                s.Append($"{NullValue}");
            }
            else
            {
                s.Append($"{ValueTag}{node.Val}");
                if (node.Left != null || node.Right != null)
                {
                    s.Append($"{LeftTag}");
                    Serialize(node.Left, s);
                    s.Append($"{RightTag}");
                    Serialize(node.Right, s);
                }
            }

            return s.ToString();
        }

        public static Node Deserialize(string treeStr)
        {
            if (treeStr == $"{NullValue}")
            {
                return null;
            }
            else
            {
                var leftIdx = treeStr.IndexOf(LeftTag);
                var rightIdx = treeStr.LastIndexOf(RightTag);
                if (leftIdx == -1 && rightIdx == -1)
                {
                    var valueStr = treeStr.Substring(1, treeStr.Length - 1);
                    return new Node(valueStr);
                }
                else
                {
                    var valueStr = treeStr.Substring(1, leftIdx - 1);
                    var leftSubtree = treeStr.Substring(leftIdx + 1, rightIdx - leftIdx - 1);
                    var rightSubtree = treeStr.Substring(rightIdx + 1, treeStr.Length - rightIdx - 1);
                    return new Node(valueStr, Deserialize(leftSubtree), Deserialize(rightSubtree));
                }
            }
        }
    }
}
