namespace _01_Delegates
{
    internal class Program
    {
        #region Declaration of a delegate
        public delegate int MyDelegate(int x, int y);
        // This delegate can point to any method that takes two integers as parameters and returns an integer.
        public delegate void MyVoidDelegate(string message);
        // This delegate can point to any method that takes a string as a parameter and returns void.

        // multicast delegate can be created by using the same delegate type and adding multiple methods to it.
        public delegate void MyMulticastDelegate(string message);
        #endregion
        #region Built-in Delegates
        //Func => A delegate that points to a method that returns a value and can take parameters. The last type parameter specifies the return type, and the preceding type parameters specify the input parameters.
        Func<int, int, int> addFunc = Add; // Func delegate that takes two integers and returns an integer
        Func<int, int, int> subtractFunc = Subtract; // Func delegate that takes two integers and returns an integer
        Func<string, string> toUpperFunc = s => s.ToUpper(); // Func delegate that takes a string and returns a string
        //========================
        //Action => A delegate that points to a method that does not return a value (void) and can take parameters. The type parameters specify the input parameters.
        Action<string> printAction = PrintMessage; // Action delegate that takes a string and returns void
        Action<int, int> printSumAction = (x, y) => Console.WriteLine($"Sum: {x + y}"); // Action delegate that takes two integers and returns void
        //========================
        //Predicate => A delegate that points to a method that returns a boolean value and takes one parameter Only. The type parameter specifies the input parameter.
        Predicate<int> isEvenPredicate = x => x % 2 == 0; // Predicate delegate that takes an integer and returns a boolean
        Predicate<string> isEvenLength= s => s.Length % 2 == 0; // Predicate delegate that takes a string and returns a boolean 


        #endregion
        #region Some Functions
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        #endregion
        static void Main(string[] args)
        {
            #region Delegates
            /*
             * Delegates are a type that represents references to methods with a specific parameter list and return type.
             * why use delegates?
             *      ==> Delegates are used to pass methods as arguments to other methods. This is particularly useful for implementing callback methods and event handling.
             *      
             */
            MyDelegate addDelegate = new MyDelegate(Add);
            Console.WriteLine($"Add: {addDelegate(5, 3)}"); // Output: Add: 8


            #endregion
            #region Multicast Delegate
            /*
             * multicast delegates are delegates that can hold references to more than one method. 
             *                     When a multicast delegate is invoked, it calls all the methods it references in the order they were added.
             */
            MyMulticastDelegate multicastDelegate = new MyMulticastDelegate(PrintMessage);
            multicastDelegate += PrintMessage; // Adding the same method again for demonstration
            multicastDelegate("Hello, World!"); // Output: Hello, World! (printed twice)

            #endregion

        }
    }
}
