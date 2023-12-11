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
    public class PriorityQueue<T>
    {
        private Heap<T> heap = new Heap<T>();

        public int Count => heap.Count;

        public T Peek()
        {
            return heap.Peek();
        }

        public void Enqueue(T item, int priority)
        {
            heap.Add(item, priority);
        }

        public T Dequeue()
        {
            return heap.Pop();
        }
    }

}