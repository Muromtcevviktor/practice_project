using Basics.Exceptions;

namespace Basics.DataStructures
{
    public class Stack
    {
        private int[] _numbers;
        private int _stackPointer;

        public Stack(int size)
        {
            if (size <= 0)
            {
                throw new StackInitializationException("Size must be bigger than 0");
            }

            _numbers = new int[size];
            _stackPointer = 0;
        }

        public void Push(int number)
        {
            if (_stackPointer == _numbers.Length)
            {
                throw new Basics.Exceptions.StackOverflowException("");
            }
            _numbers[_stackPointer] = number;

            _stackPointer++;
        }
        public int Pop()
        {
            if(_stackPointer == 0)
            {
                throw new InvalidStackAccessException("Stack is empty");
            }

            int number = _numbers[_stackPointer - 1];

            _numbers[_stackPointer - 1] = 0;

            if (_stackPointer > 0)
            {
                _stackPointer--;
            }

            return number;
        }
    }
}
