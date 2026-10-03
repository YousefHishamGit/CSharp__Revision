namespace _03_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HashSet
            /*
             *  HashSet: is a collection that contains unique elements and provides fast lookups, additions, and deletions.
             */

            HashSet<int> uniqueNumbers = new HashSet<int>();
            uniqueNumbers.Add(1);
            uniqueNumbers.Add(2);
            uniqueNumbers.Add(3);
            uniqueNumbers.Add(3);
            uniqueNumbers.Add(2);
            foreach (var number in uniqueNumbers)
            {
                Console.WriteLine(number); // Output: 1, 2, 3 (duplicates are ignored)
            }
            Console.WriteLine("Count: " + uniqueNumbers.Count); // Output: Count: 3
            Console.WriteLine("Sum of elements: " + uniqueNumbers.Sum()); // Output: Sum of elements: 6
            #endregion

            #region SortedSet
            /*
             *  SortedSet => HasSet + Sorting
             */
            #endregion
        }
    }
}
