using System;

namespace Problem006.Lib
{
    /*
     * Daily Coding Problem: Problem #6 [Hard]
An XOR linked list is a more memory efficient doubly linked list. 
Instead of each node holding next and prev fields, it holds a field named both, which is an XOR of the next node and the previous node. 
Implement an XOR linked list; it has an add(element) which adds the element to the end, and a get(index) which returns the node at index.

If using a language that has no pointers (such as Python),
you can assume you have access to get_pointer and dereference_pointer functions that converts between nodes and memory addresses.
     */
    public class XorLinkedList
    {
        private Node _head;
        private Node _prev;
        private int count = -1;

        public int add(object element)
        {
            if (_head == null)
            {
                _head = new Node(element);
                _prev = _head;
            }
            else
            {
                var prev = _prev;
                var next = _head;
                var toAdd = new Node(element, prev, next);
                var tempNext = next.GetNext(prev: _head);
                var tempPrev = prev.GetPrev(next: _head);

                prev.SetBoth(prev: tempPrev, next: toAdd);
                next.SetBoth(prev: toAdd, next: tempNext);
                _prev = toAdd;

                // CLASSIC
                //var prev = _head.Prev;
                //var next = _head;
                //var toAdd = new NodeClassic(element, prev, next);
                //prev.Next = toAdd;
                //next.Prev = toAdd;
            }

            count += 1;
            return count;
        }

        public object get(int index)
        {
            var count = 0;
            var cur = _head;
            var prev = _prev;
            while (true)
            {
                if (count == index)
                {
                    return cur.Element;
                }
                var next = cur.GetNext(prev: prev);
                prev = cur;
                cur = next;
                if (cur == _head)
                {
                    throw new ArgumentException("Not enough elements");
                }
                count += 1;

                // CLASSIC
                //if (count == index)
                //{
                //    return cur.Element;
                //}
                //cur = cur.Next;
                //if (cur == _head)
                //{
                //    throw new ArgumentException("Not enough elements");
                //}
                //count += 1;
            }
        }
    }

    public class Node
    {
        public Node(object element, Node prev = null, Node next = null)
        {
            Element = element;
            if (prev == null && next == null)
            {
                prev = next = this;
            }
            var prevPtr = MemoryManager.get_pointer(prev);
            var nextPtr = MemoryManager.get_pointer(next);
            BothPtr = prevPtr ^ nextPtr;
        }

        public object Element { get; }
        public int BothPtr { get; set; }

        //public Node GetPrev(int nextPtr)
        //{
        //    return MemoryManager.dereference_pointer(nextPtr ^ BothPtr);
        //}
        public Node GetPrev(Node next)
        {
            var nextPtr = MemoryManager.get_pointer(next);
            return MemoryManager.dereference_pointer(nextPtr ^ BothPtr);
        }
        //public Node GetNext(int prevPtr)
        //{
        //    return MemoryManager.dereference_pointer(prevPtr ^ BothPtr);
        //}
        public Node GetNext(Node prev)
        {
            var prevPtr = MemoryManager.get_pointer(prev);
            return MemoryManager.dereference_pointer(prevPtr ^ BothPtr);
        }

        public void SetBoth(Node prev, Node next)
        {
            var prevPtr = MemoryManager.get_pointer(prev);
            var nextPtr = MemoryManager.get_pointer(next);
            BothPtr = prevPtr ^ nextPtr;
        }

        public override string ToString()
        {
            return $"Element: {Element}, Link: {BothPtr}";
        }
    }

    public class NodeClassic
    {
        public NodeClassic(object element, NodeClassic prev = null, NodeClassic next = null)
        {
            Element = element;
            if (prev == null && next == null)
            {
                prev = this;
                next = this;
            }
            Prev = prev;
            Next = next;
        }

        public object Element { get; }
        public NodeClassic Prev { get; set; }
        public NodeClassic Next { get; set; }
    }
}
