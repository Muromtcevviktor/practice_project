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
    public class List
    {
        private int[] _numbers;
        private int _stackPointer;

        public List(int size)
        {
            if (size <= 0)
            {
                throw new StackInitializationException("Size must be bigger than 0");
            }

            _numbers = new int[size];
            _stackPointer = 0;
        }

        public void Push(int number)
        {
            if (_stackPointer == _numbers.Length)
            {
                throw new Basics.Exceptions.StackOverflowException("");
            }
            _numbers[_stackPointer] = number;

            _stackPointer++;
        }

        public int Pop()
        {
            if (_stackPointer == 0)
            {
                throw new InvalidStackAccessException("Stack is empty");
            }

            int number = _numbers[_stackPointer - 1];

            _numbers[_stackPointer - 1] = 0;

            if (_stackPointer > 0)
            {
                _stackPointer--;
            }

            return number;
        }

        public bool IsEmpty
        {
            get
            {
                return _stackPointer == 0;
            }
        }

        public int SizeStack
        { get { return _numbers.Length; } }
    }


    public class Node<T>
    {
        public T? Value { get; set; }
        public Node<T>? Next { get; set; }
    }

    public class LinkedList<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            return Iterate().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Iterate().GetEnumerator();
        }

        Node<T>? head;
        //Node<T>? tail;

        protected IEnumerable<T> Iterate()
        {
            Node<T> currentElement = head!;

            while (currentElement != null)
            {
                yield return currentElement.Value!;
                currentElement = currentElement.Next!;
            }

        }
        public void Add(T item)
        {
            if (head == null)
            {
               head = new Node<T> { Value = item };
            }
            else
            {
                Node<T> currentElement = head;

                while (currentElement != null)
                {
                    if (currentElement.Next == null)
                    {
                        currentElement.Next = new Node<T> { Value = item };
                        break;
                    }
                    else
                    {
                        currentElement = currentElement.Next!;
                    }
                }
            }
        }

        public Node<T> GetItem(int index)
        {
            if (index == 0 && head != null)
            {
                return head;
            }
            else if (index > 0 && head != null) //TODO: homework  
            {
                Node<T> currentItem = head;
                int currentIndex = 0;

                while (currentIndex < index && currentItem != null)
                {
                    currentItem = currentItem.Next!;
                    currentIndex++;
                }

                if (currentIndex == index)
                {
                    return currentItem!;
                }
                else
                {
                  throw new IndexOutOfRangeException("Node for given index does not exist.");
                }  
            }
            else
            {
                throw new IndexOutOfRangeException("Node for given index does not exist.");
            }  
        }

        public bool RemoveItem(int index)
        {
            Node<T> currentItem = head!;
            Node<T> previousItem = null!;
            Node<T> nextItem = null!;
            int currentIndex = 0;

            if (currentItem != null)
            {
                while (currentIndex < index)
                {
                    previousItem = currentItem;
                    currentItem = currentItem.Next!;
                    if(currentItem!.Next == null)
                    {
                        nextItem = null!;
                    }
                    else
                    {
                        nextItem = currentItem.Next!;
                    }
                    
                    currentIndex++;
                }

                if (index == 0)
                {
                    head = currentItem.Next;
                    return true;
                }

                if (currentIndex == index)
                { 
                   previousItem!.Next = nextItem!;
                   return true;
                }            
            }
                return false;
            
        }


    }
}