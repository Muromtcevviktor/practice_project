using Basics.DataStructures;
using Basics.Exceptions;
using StackOverflowException = Basics.Exceptions.StackOverflowException;

namespace Tests.DataStructuresTests
{
    public class StackTests
    {
        [Fact]
        public void Should_add_number_to_stack()
        {
            Stack stack = new Stack(10);

            int number = 10;

            stack.Push(number);

            int number2 = stack.Pop();

            Assert.Equal(number, number2);
        }

        [Fact]
        public void Should_adding_to_stack_fail_when_stackoverflow()
        {
            int size = 10;
            Stack stack = new Stack(size);

            for (int i = 0; i < size; i++)
            {
                stack.Push(i);
            }

            Assert.Throws<StackOverflowException>(() => stack.Push(size + 1));
        }

        [Fact]
        public void Should_re_stack_correctly()
        {
            int size = 10;
            Stack stack = new Stack(size);

            for (int i = 0; i < size; i++)
            {
                stack.Push(i);
            }

            for (int i = size - 1; i >= 0; i--)
            {
                int number = stack.Pop();

                Assert.Equal(i, number);
            }

            for (int i = 0; i < size; i++)
            {
                stack.Push(i + 1);
            }


            for (int i = size - 1; i >= 0; i--)
            {
                int number = stack.Pop();

                Assert.Equal(i + 1, number);
            }
        }

        [Fact]
        public void Should_fail_when_popping_empty_stack()
        {
            Stack stack = new Stack(10);

            Assert.Throws<InvalidStackAccessException>(() => stack.Pop());
        }

        [Fact]
        public void Should_fail_when_creating_stack_with_invalid_size()
        {
            Assert.Throws<StackInitializationException>(() => new Stack(0));

            Assert.Throws<StackInitializationException>(() => new Stack(-1));
        }

        [Fact]
        public void Stack_Generic()
        {
            StackGeneric<int> stack = new StackGeneric<int>(5);

            stack.Push(10);
            stack.Push(11);
            stack.Push(12);
            stack.Push(13);
            stack.Push(14);

            stack.Pop();
        }


        [Fact]
        public void Stack_Generic_2()
        {
            StackGeneric<TestItem> stack = new StackGeneric<TestItem>(5);

            stack.Push(new TestItem() {Value = 10});
            stack.Push(new TestItem() {Value = 11});
            stack.Push(new TestItem() {Value = 12});
            stack.Push(new TestItem() {Value = 13});
            stack.Push(new TestItem() {Value = 14});


            stack.Pop();
        }

    }
}
