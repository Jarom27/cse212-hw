using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adding items with the same priority and this needs to work as a normal queue
    // Expected Result: Task1, Task2, Task3
    // Defect(s) Found: The first one was that PriorityQueue starts with index 1 instead of 0
    // Second: The queue was comparing the index >= but it is necessary to use > 
    // Third: The queue didn't remove the first element.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task 1", 4);
        priorityQueue.Enqueue("Task 2", 4);
        priorityQueue.Enqueue("Task 3", 4);

        string result = priorityQueue.Dequeue();
        Assert.AreEqual("Task 1", result);
        string result2 = priorityQueue.Dequeue();
        Assert.AreEqual("Task 2", result2);
        string result3 = priorityQueue.Dequeue();
        Assert.AreEqual("Task 3", result3);
    }

    [TestMethod]
    // Scenario: Test it throws an Exception when the queue is empty
    // Expected Result: A exception is generated
    // Defect(s) Found: No one, the queue is throwing an exception when it don't have an item
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            string task = priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
    [TestMethod]
    // Add more test cases as needed below.
    // Scenario: Adding items with the different priorities and this needs to give the highest one first
    // Expected Result: Task 2, Task 3, Task 1
    // Defect(s) Found: No one the test passed successful
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task 1", 2);
        priorityQueue.Enqueue("Task 2", 4);
        priorityQueue.Enqueue("Task 3", 3);

        string result = priorityQueue.Dequeue();
        Assert.AreEqual("Task 2", result);
        string result2 = priorityQueue.Dequeue();
        Assert.AreEqual("Task 3", result2);
        string result3 = priorityQueue.Dequeue();
        Assert.AreEqual("Task 1", result3);
    }
    [TestMethod]
    // Add more test cases as needed below.
    // Scenario: Adding items with the different priorities, but adding more items with minimum values at beginning
    // and this needs to give the highest one first, and then works as a normal queue with the lowest priorities tasks
    // Expected Result: Task 5, Task 3, Task 6, Task 1, Task 2 Task 4
    // Defect(s) Found: No one the test passed successful
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Task 1", 2);
        priorityQueue.Enqueue("Task 2", 2);
        priorityQueue.Enqueue("Task 3", 3);
        priorityQueue.Enqueue("Task 4", 2);
        priorityQueue.Enqueue("Task 5", 4);
        priorityQueue.Enqueue("Task 6", 3);

        string result = priorityQueue.Dequeue();
        Assert.AreEqual("Task 5", result);
        string result2 = priorityQueue.Dequeue();
        Assert.AreEqual("Task 3", result2);
        string result3 = priorityQueue.Dequeue();
        Assert.AreEqual("Task 6", result3);
        string result4 = priorityQueue.Dequeue();
        Assert.AreEqual("Task 1", result4);
        string result5 = priorityQueue.Dequeue();
        Assert.AreEqual("Task 2", result5);
        string result6 = priorityQueue.Dequeue();
        Assert.AreEqual("Task 4", result6);
    }
}