using Basics.DataStructures;
using Basics.Exceptions;
using System;
using StackOverflowException = Basics.Exceptions.StackOverflowException;

namespace Tests.DataStructuresTests
{
    public class HeapTest
    {
        [Fact]
        public void Should_pop_first_item_from_heap()
        {
            var heap = new Heap();
            /*
            Random rnd = new Random();

            for (int i = 1; i < 16; i++)
            {
                heap.Add(rnd.Next(1, 50));
            }
            */
            heap.Add(2);
            heap.Add(32);
            heap.Add(14);
            heap.Add(11);
            heap.Add(25);
            heap.Add(7);
            heap.Add(16);
            heap.Add(29);
            heap.Add(35);

            heap.Peek();
            Assert.Equal(35, 35);

            heap.Pop();
            Assert.Equal(8, heap.Count);
        }
    }
}
