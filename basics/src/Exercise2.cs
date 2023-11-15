using Basics.DataStructures;
using Basics.Exceptions;

namespace Basics
{
    public class Exercise2
    {
        public Stack ReverseStack(Stack stack)
        {
            Stack reverseStack = new Stack(stack.SizeStack);
            
            while (!stack.IsEmpty)
            {
                reverseStack.Push(stack.Pop());
            }

            return reverseStack;

        }
    }
}
