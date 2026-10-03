using System.Text;

namespace _02_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array
            /*
             * Collection of related data of same data types
             * ==> Array is reference data type 
             * ====> data stored in heap in sequantial blocks
             */
            int[] intArr = [1, 2, 3, 3, 4, 5];
            string[] stringArr = ["frist", "second", "third"];
            /*
             * to declare Array => datatype[] nameTheVariable;
             * is zero index
             */
            Console.WriteLine(stringArr[0]);//frist
            Console.WriteLine(stringArr[1]);//second
            Console.WriteLine(stringArr[2]);//third
            /*
             * Note=> string is Array of Characters
             */
            #region Types of Array
            #region Single Dimensional Array
            int[] arr1 = [1, 2, 3, 4, 5]; // declare and allocate memory for 5 integers
            Console.WriteLine($"Length of arr1 = {arr1.Length}"); // Length of arr1 = 5
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"arr1[{i}] = {arr1[i]}  ");
            }
            Console.WriteLine("==================================");

            #endregion
            #region Multi Dimensional Array
            int[,] arr2 = new int[3, 4] // declare and allocate memory for 3 rows and 4 columns
            {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11,12 }
                //Act as Array of Single Dimensional Array ==> then each single array[rows] should have the same size
            };
            Console.WriteLine($"Length of arr2 = {arr2.Length}"); // Length of arr2 = 12
            Console.WriteLine($"Number of rows in arr2 = {arr2.GetLength(0)}"); // Number of rows in arr2 = 3
            Console.WriteLine($"Number of columns in arr2 = {arr2.GetLength(1)}"); // Number of columns in arr2 = 4
            //GetLength(dimension) => return the length of the specified dimension (0 for rows and 1 for columns)
            for (int i = 0; i < arr2.GetLength(0); i++) // iterate over rows
            {
                for (int jD = 0; jD < arr2.GetLength(1); jD++) // iterate over columns
                {
                    Console.Write($"arr2[{i},{jD}] = {arr2[i, jD]}  ");
                }
                Console.WriteLine();
            }

            #endregion
            #region Jagged Array
            int[][] arr3 = new int[3][]; // declare and allocate memory for 3 rows
            arr3[0] = new int[2] { 1, 2 }; // allocate memory for 2 columns in row 0
            arr3[1] = new int[3] { 3, 4, 5 }; // allocate memory for 3 columns in row 1
            arr3[2] = new int[4] { 6, 7, 8, 9 }; // allocate memory for 4 columns in row 2
            // each row can have different number of columns
            Console.WriteLine($"Length of arr3 = {arr3.Length}"); // Length of arr3 = 3 => number of rows (the only constant Number )
            //Console.WriteLine(arr3.GetLength(0));
            //Console.WriteLine(arr3.GetLength(1)); // compile time error => because arr3 is array of arrays not multi dimensional array
            for (int i = 0; i < arr3.Length; i++) // iterate over rows
            {
                for (int jD = 0; jD < arr3[i].Length; jD++) // iterate over columns in row i
                {
                    Console.Write($"arr3[{i}][{jD}] = {arr3[i][jD]}  ");
                }
                Console.WriteLine();
            }
            #endregion
            #endregion


            #endregion
        }
    }
}
