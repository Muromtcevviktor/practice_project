using Basics.DataStructures;
using Basics.Exceptions;
using StackOverflowException = Basics.Exceptions.StackOverflowException;

namespace Tests.DataStructuresTests
{
    public class LinkedListTests
    {
        [Fact]
        public void Should_return_number_under_given_index()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Node<int> node = list.GetItem(1);

            Assert.Equal(2, node.Value);
        }

        [Fact]
        public void Should_remove_number_from_List()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            bool result = list.RemoveItem(0);
            bool result1 = list.RemoveItem(1);

            Assert.True(result);
            Assert.True(result1);
            Assert.Equal(2, list.GetItem(0).Value);

        }

        [Fact]
        public void Foreach_in_the_List()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach(int item in list.Iterate())
            {
                Assert.True(item > 0);
            }

            bool result = list.RemoveItem(0);
            bool result1 = list.RemoveItem(1);

            Assert.True(result);
            Assert.True(result1);
            Assert.Equal(2, list.GetItem(0).Value);

        }



    }
}
