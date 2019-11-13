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
        private int listCount = -1;

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

                prev.SetLink(prev: tempPrev, next: toAdd);
                next.SetLink(prev: toAdd, next: tempNext);
                _prev = toAdd;
            }

            listCount += 1;
            return listCount;
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
                    throw new ArgumentException("Not enough elements in list (unexpected head while iterating).");
                }
                count += 1;
            }
        }
    }
}
