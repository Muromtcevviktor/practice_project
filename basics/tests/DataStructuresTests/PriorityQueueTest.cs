using Basics.DataStructures;
using Basics.Exceptions;
using StackOverflowException = Basics.Exceptions.StackOverflowException;

namespace Tests.DataStructuresTests
{
    public class PriorityQueueTest
    {
        [Fact]
        public void Should_enqueue_and_dequeue_items_from_priority_queue()
        {
            PriorityQueue<int> priorityQueue = new PriorityQueue<int>();

            for(int i = 1; i < 11; i++)
            {
                priorityQueue.Enqueue(i, i);
            }

            Assert.Equal(10, priorityQueue.Dequeue());
            Assert.Equal(9, priorityQueue.Dequeue());
        }

        [Fact]
        public void Peek_should_return_front_item_without_removing_it()
        {
            PriorityQueue<int> priorityQueue = new PriorityQueue<int>();

            for (int i = 1; i < 11; i++)
            {
                priorityQueue.Enqueue(i, i);
            }

            Assert.Equal(10, priorityQueue.Peek());  // Highest priority item
            Assert.Equal(10, priorityQueue.Count);     // Queue should remain unchanged
        }
    }
}
