using Basics;
using Basics.Algorithms;
using Basics.Algorithms.Recursion;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

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

        /*
        [Fact]
        public void Recurency2()
        {
            try 
            {
                int finalNumber = 1;
                long result = ArrayHelpers.TotalSumRecursive(0, int.MaxValue, 0);
                Assert.Equal(finalNumber, result);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        */
    }
}