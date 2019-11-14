namespace Problem008.Lib
{
    public class Node
    {
        public int Val { get; }
        public Node Left { get; }
        public Node Right { get; }

        public Node(int val, Node left = null, Node right = null)
        {
            Val = val;
            Left = left;
            Right = right;
        }
    }
}