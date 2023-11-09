using Basics.DataStructures;
using Basics.Exceptions;

namespace Basics
{
    public class Exercise2
    {
        public Stack<int> ReverseStack(Stack<int> stack)
        {
            Stack<int> reverseStack = new Stack<int>(stack.Count);
            
            while (stack.Count > 0)
            {
                reverseStack.Push(stack.Pop());
            }

            return reverseStack;

        }
    }
}
