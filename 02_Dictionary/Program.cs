namespace _02_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary
            /*
             * Dictionary: is a collection of key-value pairs, where each key is unique and maps to a specific value. 
             *             The Dictionary class provides fast lookups, additions, and deletions of elements based on their keys.
             */
            Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();
            keyValuePairs.Add(1, "One");
            keyValuePairs.Add(2, "Two");
            Console.WriteLine(keyValuePairs[1]); // Output: One
            keyValuePairs[2] = "Second"; // Update value for key 2
            //keyValuePairs.Add(1, "First"); // This will throw an exception because key 1 already exists
            //Console.WriteLine(keyValuePairs[5]); // This will throw an exception because key 5 does not exist
            // To avoid exceptions, you can use TryGetValue method
            if (keyValuePairs.TryGetValue(5, out string value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Key not found.");
            }
            // or try and catch block
            try
            {
                Console.WriteLine(keyValuePairs[5]);
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("After exception");
            //search for a key in the dictionary
            if (keyValuePairs.ContainsKey(1))
            {
                Console.WriteLine("Key 1 exists in the dictionary.");
            }
            else
            {
                Console.WriteLine("Key 1 does not exist in the dictionary.");
            }
            // search by hashing => o(1) time complexity

            //search for a value in the dictionary
            if (keyValuePairs.ContainsValue("One"))
            {
                Console.WriteLine("Value 'One' exists in the dictionary.");
            }
            else
            {
                Console.WriteLine("Value 'One' does not exist in the dictionary.");
            }
            //search by linear search => o(n) time complexity like List<T> or Array

            #endregion

            #region SortedDictionary 
            /*
             * SortedDictionary => Dictionary + sorting by Key
             * 
             */
            #endregion
        }
    }
}
