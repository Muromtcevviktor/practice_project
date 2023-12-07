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

    public class Heap

    {
        private List<int> list = new List<int>();

        public int Count 
        {
            get 
            { 
                return list.Count; 
            } 
        }

        public int? Peek() 
        {
            if(Count > 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public void Add(int item)
        {
            list.Add(item);

            var currentIndex = Count - 1; 

            var parentIndex = (currentIndex - 1) / 2;

            while(currentIndex > 0 && list[parentIndex] < list[currentIndex])
            {
                Swap(currentIndex, parentIndex);

                currentIndex = parentIndex;
                parentIndex = (currentIndex - 1) / 2;
            }

        }
        public int Pop()
        {
            var result = list[0];
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

                if(leftIndex < Count && list[leftIndex] > list[maxIndex])
                {
                    maxIndex = leftIndex;
                }

                if (rightIndex < Count && list[rightIndex] > list[maxIndex])
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
}
