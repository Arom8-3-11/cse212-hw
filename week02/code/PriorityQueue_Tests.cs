using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add a low, medium, and high priority item in that order.
    // Expected Result: Items are stored in enqueue order, then the highest priority item is returned
    // first and removed from the queue.
    // Defect(s) Found: The last item was skipped while looking for the highest priority, and the
    // returned item was not removed from the queue.
    public void TestPriorityQueue_HighestPriorityAndRemoval()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        // Enqueue always appends, even when the new item has a higher priority.
        Assert.AreEqual("[Low (Pri:1), Medium (Pri:5), High (Pri:10)]", priorityQueue.ToString());
        // Dequeue selects by priority and removes the selected item from the queue.
        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("[Low (Pri:1), Medium (Pri:5)]", priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Add two items with the same highest priority, separated by a lower-priority item.
    // Expected Result: The earlier high-priority item is returned first, followed by the later one.
    // Defect(s) Found: Equal priorities selected the item later in the queue instead of following FIFO.
    public void TestPriorityQueue_EqualPrioritiesUseFifo()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First high", 10);
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Second high", 10);

        // The first high-priority item must win the tie because it arrived first.
        Assert.AreEqual("First high", priorityQueue.Dequeue());
        Assert.AreEqual("Second high", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Remove an item from an empty queue.
    // Expected Result: An InvalidOperationException with the message "The queue is empty." is thrown.
    // Defect(s) Found: No defect found; the expected exception and message are already provided.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        // Capture the exception so its required message can be checked too.
        var exception = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}