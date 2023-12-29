using Basics.Exceptions;

namespace Basics.DataStructures
{
    public class StackObject
    {
        private object[] _objects;
        private int _stackPointer;

        public StackObject(int size)
        {
            if (size <= 0)
            {
                throw new StackInitializationException("Size must be bigger than 0");
            }

            _objects = new object[size];
            _stackPointer = 0;
        }

        public void Push(object @object)
        {
            if (_stackPointer == _objects.Length)
            {
                throw new Basics.Exceptions.StackOverflowException("");
            }
            _objects[_stackPointer] = @object;

            _stackPointer++;
        }

        public object Pop()
        {
            if (_stackPointer == 0)
            {
                throw new InvalidStackAccessException("Stack is empty");
            }

            object objects = _objects[_stackPointer - 1];

            _objects[_stackPointer - 1] = 0;

            if (_stackPointer > 0)
            {
                _stackPointer--;
            }

            return objects;
        }

        public bool IsEmpty
        {
            get
            {
                return _stackPointer == 0;
            }
        }

        public int SizeStack
        { get { return _objects.Length; } }
    }
}