using Basics.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Security;
using System.Security.Principal;

namespace Basics.DataStructures
{
    public class Queue<T>
    {
        private LinkedList<T> list = new LinkedList<T>();
        public void Enqueue(T item)
        {
            list.Add(item);
        }

        public void Dequeue(T item) 
        {
            list.GetItem(0);

        }



        
    }
}