namespace Problem006.Lib
{
    public class Node
    {
        public Node(object element, Node prev = null, Node next = null)
        {
            Element = element;
            if (prev == null && next == null)
            {
                prev = this;
                next = this;
            }
            var prevPtr = MemoryManager.get_pointer(prev);
            var nextPtr = MemoryManager.get_pointer(next);
            Link = prevPtr ^ nextPtr;
        }

        public object Element { get; }

        public int Link { get; private set; }

        public Node GetPrev(Node next)
        {
            var nextPtr = MemoryManager.get_pointer(next);
            return MemoryManager.dereference_pointer(nextPtr ^ Link);
        }

        public Node GetNext(Node prev)
        {
            var prevPtr = MemoryManager.get_pointer(prev);
            return MemoryManager.dereference_pointer(prevPtr ^ Link);
        }

        public void SetLink(Node prev, Node next)
        {
            var prevPtr = MemoryManager.get_pointer(prev);
            var nextPtr = MemoryManager.get_pointer(next);
            Link = prevPtr ^ nextPtr;
        }

        public override string ToString()
        {
            return $"Element: {Element}, Link: {Link}";
        }
    }
}
