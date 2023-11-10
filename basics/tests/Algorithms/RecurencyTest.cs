using Basics;
using Basics.Algorithms;
using Basics.Algorithms.Recursion;
using System.Collections.Generic;

namespace Tests.Algorithms
{
    public class RecurencyTest
    {
        [Fact]

        public void Recurency()
        {
            List<int> list = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            list.RecursiveReverse(0, list.Count - 1);
        }
    }
}