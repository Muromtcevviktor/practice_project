using Basics;
using Basics.Algorithms;

namespace Tests.Algorithms
{
    public class FibonacciTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]

        public void Shoudl_return_correct_Fibonacci_number(int n, int expectedNumber)
        {
            Assert.Equal(FibonacciCalculator.Fibonacci(expectedNumber), FibonacciCalculator.Fibonacci(n)); 
        }
    }
}