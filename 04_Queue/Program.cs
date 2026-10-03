namespace _04_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Queue
            /*
             * Queue: is a collection that follows the First-In-First-Out (FIFO) principle, where elements are added to the end of the queue and removed from the front.
             *     
             *       -----------------------------------
             *   <= remove from front            <= adding from the end of the queue
             *       -----------------------------------
             * 
             */
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First"); // Add element to front of the queue
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            foreach (var item in queue)
            {
                Console.WriteLine(item); // Output: First, Second, Third
            }
            Console.WriteLine("Dequeue: " + queue.Dequeue()); // Remove and return the front element (First)
            foreach (var item in queue)
            {
                Console.WriteLine(item); // Output:  Second, Third
            }

            Console.WriteLine("Peek: " + queue.Peek()); // Return the front element without removing it (Second)
            foreach (var item in queue)
            {
                Console.WriteLine(item); // Output: Second, Third
            }

            #endregion
        }
    }
}
