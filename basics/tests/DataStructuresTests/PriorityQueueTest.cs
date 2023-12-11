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
            PriorityQueue priorityQueue = new PriorityQueue();

            priorityQueue.Enqueue(10);
            priorityQueue.Enqueue(5);
            priorityQueue.Enqueue(20);
            priorityQueue.Enqueue(13);
            priorityQueue.Enqueue(8);
            priorityQueue.Enqueue(17);

            Assert.Equal(20, priorityQueue.Dequeue());
            Assert.Equal(17, priorityQueue.Dequeue());
        }

        [Fact]
        public void Peek_should_return_front_item_without_removing_it()
        {
            PriorityQueue priorityQueue = new PriorityQueue();

            priorityQueue.Enqueue(10);
            priorityQueue.Enqueue(5);
            priorityQueue.Enqueue(20);
            priorityQueue.Enqueue(13);
            priorityQueue.Enqueue(8);
            priorityQueue.Enqueue(17);

            Assert.Equal(20, priorityQueue.Peek());  // Highest priority item
            Assert.Equal(6, priorityQueue.Count);     // Queue should remain unchanged
        }
    }
}
