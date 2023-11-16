using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Algorithms.Recursion
{
    public static class ArrayHelpers
    {
        public static void RecursiveReverse(this List<int> inputList, int currentIndex, int nextIndex)
        {
            if (inputList.Count == 1 || (currentIndex + 1) == nextIndex)
            {
                return;
            }
            else
            {
                int currentIndexValue = inputList[currentIndex];
                int nextIndexValue = inputList[nextIndex];
                inputList[nextIndex] = currentIndexValue;
                inputList[currentIndex] = nextIndexValue;
                inputList.RecursiveReverse(currentIndex + 1, nextIndex - 1);

            }
        }

        /*
        public static long TotalSumRecursive(long currentIteration, long n, long sum)
        {
            if (currentIteration == n)
            {
                return sum;
            }

            return TotalSumRecursive(currentIteration + 1, n, sum + (currentIteration + 1));
        }
        */
    }
}
