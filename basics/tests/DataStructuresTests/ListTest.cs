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
            Basics.DataStructures.LinkedList<int> list = new Basics.DataStructures.LinkedList<int>();
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
            Basics.DataStructures.LinkedList<int> list = new Basics.DataStructures.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            bool result = list.RemoveItem(1);

            Assert.True(result);
            Assert.Equal(1, list.GetItem(0).Value);
            Assert.Equal(3, list.GetItem(1).Value);

        }

      

    }
}
