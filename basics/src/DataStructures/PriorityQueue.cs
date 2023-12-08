using Basics.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Security;
using System.Security.Principal;

namespace Basics.DataStructures
{
    public class PriorityQueue
    {
        private Heap heap = new Heap();

        public int Count => heap.Count;

        public int? Peek()
        {
            return heap.Peek();
        }

        public void Enqueue(int item)
        {
            heap.Add(item);
        }

        public int Dequeue()
        {
            return heap.Pop();
        }
    }

}