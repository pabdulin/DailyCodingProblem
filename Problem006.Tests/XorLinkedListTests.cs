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
        private const int TestValue1 = 976;
        private const int TestValue2 = 380;
        private const int TestValue3 = 202;
        private const int TestValue4 = 212;

        [TestMethod]
        public void AddTest()
        {
            var sut = new XorLinkedList();
            Assert.AreEqual(0, sut.add(TestValue1));
            Assert.AreEqual(1, sut.add(TestValue2));
            Assert.AreEqual(2, sut.add(TestValue3));
            //Assert.AreEqual(3, sut.add(TestValue4));
        }

        [TestMethod]
        public void GetTest()
        {
            var sut = new XorLinkedList();
            var index1 = sut.add(TestValue1);
            var index2 = sut.add(TestValue2);
            var index3 = sut.add(TestValue3);
            //var index4 = sut.add(TestValue4);
            Assert.AreEqual(TestValue1, sut.get(index1));
            Assert.AreEqual(TestValue2, sut.get(index2));
            Assert.AreEqual(TestValue3, sut.get(index3));
            //Assert.AreEqual(TestValue4, sut.get(index4));
        }
    }
}
