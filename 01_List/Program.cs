namespace _01_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array
            /*
             *  Array : list of items of the same type, fixed size, and stored in contiguous memory locations.
             *          should be know that the size of the array at compile time and ensure that the size of the array is not changed at runtime.
             */
            int[] arr = new int[5]; // Declare an array of integers with a size of 5
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            //arr[5] = 6; // This will throw an IndexOutOfRangeException because the array has a fixed size of 5 => from 0 to 4
            int [] arr2 = { 1,2,3,4}; // Declare and initialize an array of integers with a size of 4



            #endregion
            #region List
            /*
             *  List : list of items of the same type, dynamic size, and stored in contiguous memory locations.
             *          should be know that the size of the list at runtime and ensure that the size of the list is not changed at compile time.
             */
            List<int> list = new List<int>(); // Declare a list of integers
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine("List Count: " + list.Count); // Output: List Count: 3
            Console.WriteLine("list elements: " + string.Join(", ", list)); // Output: list elements: 1, 2, 3
            list.Add(4);
            list.Add(5);
            Console.WriteLine("List Count: " + list.Count); // Output: List Count: 5
            Console.WriteLine("list elements: " + string.Join(", ", list)); // Output: list elements: 1, 2, 3 , 4, 5
            Console.WriteLine(list.Capacity); // Output: 8 => The capacity of the list is the number of elements that the list can hold before it needs to resize itself.
            list.Add(6);
            Console.WriteLine("List Count: " + list.Count); // Output: List Count: 6
            Console.WriteLine(list.Capacity);// Output: 8
            list.Add(7);
            Console.WriteLine("List Count: " + list.Count);// Output: List Count: 7
            Console.WriteLine(list.Capacity);// Output: 8
            list.Add(8);
            Console.WriteLine("List Count: " + list.Count);// Output: List Count: 8
            Console.WriteLine(list.Capacity);// Output: 8
            list.Add(9);
            Console.WriteLine(list.Capacity);// Output: 16 => The capacity of the list is doubled when the list needs to resize itself.
            list.Remove(5); // Remove the first occurrence of the specified element from the list
            list.RemoveAt(0); // Remove the element at the specified index from the list
            list.Contains(5);// Check if the list contains the specified element return true or false


            /*
             * List Performance :
             *                   1- Add : O(1) => Amortized constant time complexity, because the list may need to resize itself when it reaches its capacity.
             *                   2- Remove : O(n) => Linear time complexity, because the list needs to shift the elements after the removed element to fill the gap.
             *                   3- Contains : O(n) => Linear time complexity, because the list needs to iterate through the elements to find the specified element.
             *                 **4- Access : O(1) => Constant time complexity, because the list can access the elements by index in constant time.
             */


            #endregion
        }
    }
}
