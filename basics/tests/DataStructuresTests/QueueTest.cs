using Basics.DataStructures;
using Basics.Exceptions;
using StackOverflowException = Basics.Exceptions.StackOverflowException;

namespace Tests.DataStructuresTests
{
    public class QueueTest
    {
        [Fact]
        public void Should_get_item_from_queue()
        {
            Queue<int> queue = new Queue<int>();

            for (int i = 1; i < 6; i++)
            {
                queue.Enqueue(i);
            }

            int firstItem = queue.Dequeue();

            Assert.Equal(1, firstItem);
            Assert.Equal(4, queue.Count());
        }
    }
}
