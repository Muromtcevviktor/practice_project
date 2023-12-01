using Basics;
using System.Collections.Generic;

namespace Tests
{
    public class FibonacciTests
    {
        [Fact]
        public void Test1()
        {
            var _sut = new Exercise1();

            List<int> numbers = new List<int>() { 9, 9, 9, 2, 1, 1, 3, 3, 4, 4 };

            var stats = _sut.GetStatistics(numbers);

            Assert.Equal(3, stats[9]);
            Assert.Equal(1, stats[2]);
            Assert.Equal(2, stats[1]);
            Assert.Equal(2, stats[3]);
            Assert.Equal(2, stats[4]);

        }
    }
}