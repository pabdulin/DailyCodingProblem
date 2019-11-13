using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem006.Lib;

namespace Problem006.Tests
{
    /*
 * Daily Coding Problem: Problem #6 [Hard]
An XOR linked list is a more memory efficient doubly linked list. 
Instead of each node holding next and prev fields, it holds a field named both, which is an XOR of the next node and the previous node. 
Implement an XOR linked list; it has an add(element) which adds the element to the end, and a get(index) which returns the node at index.

If using a language that has no pointers (such as Python),
you can assume you have access to get_pointer and dereference_pointer functions that converts between nodes and memory addresses.
 */

    [TestClass]
    public class XorLinkedListTests
    {
        private int[] TestValues1 = new[] { 1004, 2003, 3025, 4123, -5000 };

        [TestMethod]
        public void AddTest()
        {
            var sut = new XorLinkedList();
            for (int i = 0; i < TestValues1.Length; i++)
            {
                Assert.AreEqual(i, sut.add(TestValues1[i]));
            }
        }

        [TestMethod]
        public void GetTest()
        {
            var sut = new XorLinkedList();
            for (int i = 0; i < TestValues1.Length; i++)
            {
                sut.add(TestValues1[i]);
            }
            for (int i = 0; i < TestValues1.Length; i++)
            {
                Assert.AreEqual(TestValues1[i], sut.get(i));
            }
        }
    }
}
