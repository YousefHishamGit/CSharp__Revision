namespace _04_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ
            /*
             * LINQ (Language Integrated Query) is a set of features in C# that allows you to query collections of data in a more readable and concise way. 
             *                                  
             */
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 10, 9, 8, 7, 6 };
            int evenCount = numbers.Count(n => n % 2 == 0); // Count even numbers using LINQ
            //without LINQ
            int EvenCountWithoutLINQ = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    EvenCountWithoutLINQ++;
                }
            }
            var result = numbers.Where(n => n % 2 == 0).Select(n => n * n); // Get squares of even numbers using LINQ
            foreach (var square in result)
            {
                Console.WriteLine(square); // Output: 4, 16, 100, 64, 36
            }
            var sortedNumbers = numbers.OrderBy(n => n); // Sort numbers in ascending order using LINQ
            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number); // Output: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            }
            Console.WriteLine("================");

            var groupedNumbers = numbers.GroupBy(n => n % 2 == 0); // Group numbers by even and odd using LINQ
            foreach (var group in groupedNumbers)
            {
                Console.Write(group.Key ? "Even numbers:" : "Odd numbers:");
                foreach (var number in group)
                {
                    Console.Write(number + " ,");
                }
                Console.WriteLine();
            }

            #endregion
            #region Most Common LINQ Methods
            /*
             *  
                Where
                Select
                OrderBy
                OrderByDescending
                ThenBy
                First
                FirstOrDefault
                Single
                SingleOrDefault
                Any
                All
                Count
                Sum
                Average
                Min
                Max
                Contains => is used to check if a collection contains a specific element return bool.
                Find => is used to find the first element in a collection that matches a specified condition return first element.
             */
            #endregion
            #region LINQ Query Syntax vs Method Syntax
            var products = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
            //Method Syntax
            var methodSyntaxResult = products.Where(p => p.StartsWith("A")).Select(p => p.ToUpper()).ToList();
            //Query Syntax
            var querySyntaxResult = (from p in products
                                     where p[0]== 'A'
                                     select p.ToUpper()).ToList();
            #endregion
            #region IEnumerable vs IQueryable
            /*
             * IEnumerable is used for in-memory collections and LINQ to Objects, 
             * IQueryable is used for out-of-memory collections and LINQ to SQL or Entity Framework.
             * 
             *    IEnumerable → Execute in memory
                  IQueryable → Build/translate query for the data source
             */
            #endregion
            #region AsEnumerable vs AsQueryable
            /*
             * AsEnumerable is used to treat a collection as an IEnumerable, 
             * AsQueryable is used to treat a collection as an IQueryable.
             * 
             *    AsEnumerable → Treats the collection as IEnumerable
                  AsQueryable → Treats the collection as IQueryable
             */
            #endregion
            #region async and await with LINQ
            /*
             * async and await can be used with LINQ to perform asynchronous operations on collections, 
             * allowing for non-blocking execution and improved performance in scenarios involving I/O-bound operations.
             * 
             *    async → Marks a method as asynchronous
                  await → Waits for the completion of an asynchronous operation
             */
            #endregion
        }
    }
}
