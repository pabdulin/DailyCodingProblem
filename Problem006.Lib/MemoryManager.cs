using System.Collections.Generic;

namespace Problem006.Lib
{
    public static class MemoryManager
    {
        public const int NullPtr = 0;
        private static readonly Dictionary<int, Node> Memory = new Dictionary<int, Node>();

        public static int get_pointer(Node n)
        {
            var result = n.Element.GetHashCode();
            Memory[result] = n;
            return result;
        }

        public static Node dereference_pointer(int ptr)
        {
            return Memory[ptr];
        }
    }
}
