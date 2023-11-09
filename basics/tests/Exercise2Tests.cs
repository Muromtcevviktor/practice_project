using Basics;
using Basics.DataStructures;

namespace Tests
{
    public class Exercise2Tests
    {
        [Fact]
        public void Should_reverse_stack_correctly()
        {
            var _sut = new Exercise2();

            int stackSize = 5;

            Stack<int> inputStack = new Stack<int>(stackSize);

            Random r = new Random();

            var list = new List<int>(10);

            for(var i = 0; i < stackSize; i++)
            {
                list.Add(r.Next(1000));

                inputStack.Push(list[i]);
            }

            Stack<int> outputStack = _sut.ReverseStack(inputStack);

            //Assert outputStack logic
            
            Assert.Equal(stackSize, outputStack.Count);
            //Assert.Equal(list, reversedList.Reverse());

        }
    }
}
