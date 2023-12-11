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
    public class Queue<T>
    {
        private LinkedList<T> queueList = new LinkedList<T>();

        public void Enqueue(T item)
        {
            queueList.Add(item);
        }

        public T Dequeue()
        {
            if (Count() == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T item = queueList.GetItem(0).Value;
            queueList.RemoveItem(0);
            return item;
        }

        public int Count()
        {
            return queueList.Count();
        }
    }
}