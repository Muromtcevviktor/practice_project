using Basics.DataStructures;
using Basics.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using StackOverflowException = Basics.Exceptions.StackOverflowException;

namespace Tests.DataStructuresTests
{
    public class HeapTest
    {
        [Fact]
        public void Should_pop_first_item_from_heap()
        {
            var heap = new Heap<int>();
            /*
            Random rnd = new Random();

            for (int i = 1; i < 16; i++)
            {
                heap.Add(rnd.Next(1, 50));
            }
            */

            List<int> lists = new List<int>(){ 2, 32, 14, 11, 25, 7, 16, 29, 35 };
            var sortedList = lists.OrderByDescending(a => a).ToList();
            
            foreach(var item in lists)
            {
                heap.Add(item, item);
            }

            foreach(var item in sortedList)
            {
                var max = heap.Pop();
                Assert.Equal(item, max);
            }
        }
    }
}
