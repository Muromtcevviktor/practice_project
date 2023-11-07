using Basics;
using Basics.DataStructures;

namespace Tests
{
    public class Exercise2Tests
    {
        [Fact]
        public void Should_reverse_stack_correctly()
        {
            int stackSize = 10;

            Stack inputStack = new Stack(stackSize);

            Random r = new Random();

            var list = new List<int>(10);

            for(var i = 0; i < stackSize; i++)
            {
                list.Add(r.Next());

                inputStack.Push(list[i]);
            }

            Stack outputStack = new Exercise2().ReverseStack(inputStack);

            //Assert outputStack logic
        }
    }
}
