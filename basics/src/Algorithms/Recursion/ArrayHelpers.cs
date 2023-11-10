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
    }
}
