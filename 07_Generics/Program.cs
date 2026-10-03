namespace _07_Generics
{
    internal class Program
    {
        #region Without Generics
        public static void PrintInt(int value)
        {
            Console.WriteLine(value);
        }

        public static void PrintString(string value)
        {
            Console.WriteLine(value);
        }
        #endregion
        #region With Generics
        public static void Print<T>(T value)
        // <T> is a placeholder for any data type 
        // T is commonly used as a convention for generic type parameters, but you can use any valid identifier.
        {
            Console.WriteLine(value);
        }
        #endregion

        #region Where Constraint
        /*
         *  where Constraint : used to restrict the types that can be used as arguments for a generic type parameter.
         */
        public static void PrintWithConstraint<T>(T value) where T : class
        {
            Console.WriteLine("where T : class => " +value);
        }
        #endregion
        static void Main(string[] args)
        {
            #region Generics
            /*
             * Generics : That you write a class or method that can work with any data type. 
             *            It allows you to create a single class, method, or interface that can work with different data types without the need for multiple implementations.
             *            
             *            Acheive type safety, code reusability, and performance optimization.
             *                    1- Type Safety: Generics provide compile-time type checking, which helps catch type-related errors early in the development process. This reduces the risk of runtime errors and improves code reliability.
             *                    2- Code Reusability: Generics allow you to create a single implementation that can work with different data types. This promotes code reuse and reduces duplication, making your codebase more maintainable.
             *                    3- Performance Optimization: Generics can improve performance by avoiding the need for boxing and unboxing when working with value types. This can lead to more efficient memory usage and faster execution times.
             */
            Print<int>(42); // Output: 42
            Print<string>("Hello, Generics!"); // Output: Hello, Generics!
            #endregion
            #region Object vs Generics
            /*
             * Object vs Generics : 
             *                      1- Type Safety: Generics provide compile-time type checking, which helps catch type-related errors early in the development process. This reduces the risk of runtime errors and improves code reliability.
             *                      2- Code Reusability: Generics allow you to create a single implementation that can work with different data types. This promotes code reuse and reduces duplication, making your codebase more maintainable.
             *                      3- Performance Optimization: Generics can improve performance by avoiding the need for boxing and unboxing when working with value types. This can lead to more efficient memory usage and faster execution times.
             *                      
             ******* object accepts anything, but Generics accept anything while preserving its type
             */
            #endregion
            #region Where Constraint
            PrintWithConstraint<string>("Hello, Generics with Constraint!"); // Output: where T : class => Hello, Generics with Constraint!
            //PrintWithConstraint<int>(5); // Error: The type 'int' must be a reference type in order to use it as parameter 'T' in the generic method 'PrintWithConstraint<T>(T)'
            #endregion



        }
    }
}
