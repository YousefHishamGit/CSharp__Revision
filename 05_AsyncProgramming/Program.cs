using System.Threading.Tasks;

namespace _05_AsyncProgramming
{
    internal class Program
    {
        #region Example
        static async Task RunExampleAsync()
        {
            Console.WriteLine($"[Sync] Started - {DateTime.Now:HH:mm:ss}");
            MakeCoffeeSync(); // Blocks the thread for a full 3 seconds
            Console.WriteLine($"[Sync] Finished - {DateTime.Now:HH:mm:ss}");

            Console.WriteLine();

            Console.WriteLine($"[Async] Started - {DateTime.Now:HH:mm:ss}");
            await MakeCoffeeAsync(); // Doesn't block the thread, just waits for the result
            Console.WriteLine($"[Async] Finished - {DateTime.Now:HH:mm:ss}");

            // Example of Task<T> which returns a value
            int age = await GetUserAgeAsync();
            Console.WriteLine($"User age: {age}");
        }

        // ------- Synchronous -------
        static void MakeCoffeeSync()
        {
            Console.WriteLine("Making coffee (Sync)...");
            Thread.Sleep(3000); // Actually blocks the thread for 3 seconds
            Console.WriteLine("Coffee ready (Sync)!");
        }

        // ------- Asynchronous, Task (no return value) -------
        static async Task MakeCoffeeAsync()
        {
            Console.WriteLine("Making coffee (Async)...");
            await Task.Delay(3000); // Frees the thread to do other work during these 3 seconds
            Console.WriteLine("Coffee ready (Async)!");
        }

        // ------- Asynchronous, Task<T> (returns a value of type T) -------
        static async Task<int> GetUserAgeAsync()
        {
            await Task.Delay(1000); // Simulates something like calling an API or a database
            return 25;
        }
        #endregion
        static async Task Main(string[] args)
        {
            #region Synchronous and Asynchronous Programming
            /*
             * Synchronous  programming is a programming paradigm where tasks are executed one after another, blocking the execution of subsequent tasks until the current task is completed.
             * Asynchronous programming allows tasks to run concurrently, enabling the program to continue executing other tasks while waiting for long-running operations to complete.
             * 
             */
            #endregion
            #region async and await
            /*
             * async and await are keywords in C# that facilitate asynchronous programming. 
             * The async keyword is used to define a method as asynchronous, while the await keyword is used to pause the execution of an async method until the awaited task completes.
             * 
             * we use them to improve the responsiveness of applications, especially in scenarios involving I/O-bound operations, such as file access, network requests, or database queries.
             *  Async does NOT mean the operation becomes faster BUT => Don't block the thread while waiting for I/O
             */

            #endregion
            #region DeadLock Problem
            /*
             * Deadlock is a situation in concurrent programming where two or more threads are blocked forever, each waiting for the other to release a resource. 
             *          This can occur when multiple threads hold locks on resources and attempt to acquire locks held by each other, creating a circular dependency.
             *          
             *          thread A waiting for thread B to release a resource, 
             *          while thread B is waiting for thread A to release a resource, 
             *          =>>resulting in both threads being blocked indefinitely.
             *          
             *****Deadlock happens when two operations are waiting for each other, so neither can continue. 
             *    In async code, blocking with { Result or Wait() } can cause deadlocks in environments with synchronization contexts, so we prefer { await } all the way.          
             */
            #endregion
            #region Task and Task<T>
            /*
             * Task represents an asynchronous operation that can be awaited, while Task<T> represents an asynchronous operation that returns a value of type T.
             * 
             * we use them to represent and manage asynchronous operations, allowing for better control over concurrency and enabling the use of async and await for improved code readability and maintainability.
             *  
             */
            #endregion
            #region example
            MakeCoffeeSync(); 
            await MakeCoffeeAsync();
            #endregion

            /*
             * 
               Task  → "أنا شغال في حاجة وهخلصها بعدين"
               async → "الميثود دي شغالة بالنظام ده"
               await → "استنى الحاجة دي هنا، ولما تخلص كمّل"
             */

        }
    }
}
