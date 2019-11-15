using System;

namespace Problem008.Lib
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
    public class Problem
    {
        public static int CountInivalTrees(Node root)
        {
            var result = CountRec(root);
            return result;
        }

        private static int CountRec(Node node, int count = 0)
        {
            if (node == null)
            {
                return count;
            }

            var isUnival = IsUnival(node, node.Val);

            //leaf is unival
            if (node.Left == null && node.Right == null)
            {
                return count + isUnival;
            }

            if (node.Left != null)
            {
                count = CountRec(node.Left, count + isUnival);
                isUnival = 0;
            }
            if (node.Right != null)
            {
                count = CountRec(node.Right, count + isUnival);
            }

            return count;
        }

        public static int IsUnival(Node node, int val)
        {
            if (node.Val != val)
            {
                return 0;
            }

            if (node.Left != null)
            {
                if (IsUnival(node.Left, val) == 0)
                {
                    return 0;
                }
            }
            if (node.Right != null)
            {
                if (IsUnival(node.Left, val) == 0)
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}
