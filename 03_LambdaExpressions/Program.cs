namespace _03_LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lambda Expressions
            /*
             * Lambda expressions are a concise way to represent anonymous methods using a special syntax. 
             *                    They are often used in conjunction with delegates and LINQ queries.
             */
            Func<int, int, int> addLambda = (x, y) => x + y; // Lambda expression that takes two integers and returns their sum
            Action<string> printLambda = message => Console.WriteLine(message); // Lambda expression that takes a string and prints it
            Predicate<int> isEvenLambda = (x) => x % 2 == 0; // Lambda expression that takes an integer and returns true if it's even
            Console.WriteLine($"Add using Lambda: {addLambda(5, 3)}"); // Output: Add using Lambda: 8
            printLambda("Hello from Lambda!"); // Output: Hello from Lambda!
            Console.WriteLine(isEvenLambda(1));// Output: False
            //bool result = (x) => x > 10; // ERROR // Lambda expressions cannot be used as standalone statements;
                                                   //  They must be assigned to a delegate or used in a context that expects a delegate.
            #endregion
        }
    }
}
