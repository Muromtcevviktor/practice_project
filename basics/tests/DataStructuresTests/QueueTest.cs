using Basics.DataStructures;
using Basics.Exceptions;
using StackOverflowException = Basics.Exceptions.StackOverflowException;

namespace Tests.DataStructuresTests
{
    public class QueueTests
    {
        [Fact]
        public void Should_remove_item_from_queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            //while()
            {

            }
            //int first = queue.Dequeue();
            





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

            foreach(int item in list)
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
