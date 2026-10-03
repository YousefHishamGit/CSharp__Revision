namespace _05_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Stack
            /*
             * Stack: is a collection that follows the Last-In-First-Out (LIFO) principle, where elements are added and removed from the top of the stack.
             * 
             * 
             *  add and remove from the top of the stack 
             *  
             *          |    |
             *          |    |
             *          |    |
             *          |    |
             *          ------
             */
            Stack<string> stack = new Stack<string>();
            stack.Push("First"); // Add element to the top of the stack
            stack.Push("Second");
            stack.Push("Third");
            foreach (var item in stack)
            {
                Console.WriteLine(item); // Output: Third, Second, First
            }
            Console.WriteLine("Pop: " + stack.Pop()); // Remove and return the top element (Third)
            foreach (var item in stack)
            {
                Console.WriteLine(item); // Output: Second, First
            }
            Console.WriteLine("Peek: " + stack.Peek()); // Return the top element without removing it (Second)
            foreach (var item in stack)
            {
                Console.WriteLine(item); // Output: Second, First
            }
            #endregion
        }
    }
}
