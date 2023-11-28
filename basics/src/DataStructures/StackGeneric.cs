using Basics.Exceptions;

namespace Basics.DataStructures
{
    public class StackGeneric<T>
    {
        private T[] _items;
        private int _stackPointer;

        public StackGeneric(int size)
        {
            if (size <= 0)
            {
                throw new StackInitializationException("Size must be bigger than 0");
            }

            _items = new T[size];
            _stackPointer = 0;
        }

        public void Push(T item)
        {
            if (_stackPointer == _items.Length)
            {
                throw new Basics.Exceptions.StackOverflowException("");
            }
            _items[_stackPointer] = item;

            _stackPointer++;
        }

        public T Pop()
        {
            if (_stackPointer == 0)
            {
                throw new InvalidStackAccessException("Stack is empty");
            }

            T item = _items[_stackPointer - 1];

            _items[_stackPointer - 1] = default(T)!;

            if (_stackPointer > 0)
            {
                _stackPointer--;
            }

            return item;
        }

        public bool IsEmpty
        {
            get
            {
                return _stackPointer == 0;
            }
        }

        public int SizeStack
        { get { return _items.Length; } }
    }
}