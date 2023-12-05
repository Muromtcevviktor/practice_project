using Basics;
using Basics.DataStructures;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Tests
{
    public class Exercise2Tests
    {
        [Fact]
        public void Should_reverse_stack_correctly()
        {
            var _sut = new Exercise2();

            int stackSize = 5;

            Stack inputStack = new Stack(stackSize);

            Random r = new Random();

            var list = new List<int>(10);

            for (var i = 0; i < stackSize; i++)
            {
                list.Add(r.Next(1000));

                inputStack.Push(list[i]);
            }

            Stack outputStack = _sut.ReverseStack(inputStack);

            //Assert outputStack logic
            Assert.Equal(stackSize, outputStack.SizeStack);

            for (int i = 0; i < list.Count; i++)
            {
                Assert.Equal(list[i], outputStack.Pop());
            }

        }

        [Fact]
        public void Should_create_stack_object()
        {
            var _sut = new Exercise2();

            int stackSize = 10;

            StackObject inputStack = new StackObject(stackSize);

            Random r = new Random();

            var list = new List<object>(10);

            inputStack.Push(5);
            inputStack.Push(1.5);
            inputStack.Push(new List<int>());

            object one = inputStack.Pop();

            if (one is List<double>)
            {
                List<double>? myList = one as List<double>;
            }
            double two = (double)inputStack.Pop();
            int three = (int)inputStack.Pop();

        }
    }
}

