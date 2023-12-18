using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.DataStructures
{
    #region Support

    // Left child index:   2 * i + 1
    // Right child index:  2 * i + 2
    // Parent index:       (i - 1) / 2

    // question: line 52 - Operator > cannot be applied to operands of type T
    #endregion

    public class Heap<T>

    {
        private List<HeapItem<T>> list = new List<HeapItem<T>>();

        public int Count 
        {
            get 
            { 
                return list.Count; 
            } 
        }

        public T Peek() 
        {
            if(Count > 0)
            {
                return list[0].Value;
            }
            else
            {
                return default;
            }
        }

        public void Add(T item, int key)
        {
            list.Add(new HeapItem<T>() { Value = item, Key = key });

            var currentIndex = Count - 1; 

            var parentIndex = (currentIndex - 1) / 2;

            while(currentIndex > 0 && list[parentIndex].Key < list[currentIndex].Key)
            {
                Swap(currentIndex, parentIndex);

                currentIndex = parentIndex;
                parentIndex = (currentIndex - 1) / 2;
            }

        }
        public T Pop()
        {
            var result = list[0].Value;
            list[0] = list[Count - 1];
            list.RemoveAt(Count - 1);

            Sort(0);

            return result;
        }

        private void Sort(int currentIndex)
        {
            int maxIndex = currentIndex;
            int leftIndex;
            int rightIndex;

            while (currentIndex < Count)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if(leftIndex < Count && list[leftIndex].Key > list[maxIndex].Key)
                {
                    maxIndex = leftIndex;
                }

                if (rightIndex < Count && list[rightIndex].Key > list[maxIndex].Key)
                {
                    maxIndex = rightIndex;
                }

                if (currentIndex == maxIndex)
                {
                    break;
                }
                
                Swap(currentIndex, maxIndex);
                currentIndex = maxIndex;
            }

        }
        private void Swap(int currentIndex, int parentIndex)
        {
            var temp = list[currentIndex];
            list[currentIndex] = list[parentIndex];
            list[parentIndex] = temp;
        }
    }

    public class HeapItem<T>
    {
        public int Key { get; set; }
        public T Value { get; set; }
    }
}
