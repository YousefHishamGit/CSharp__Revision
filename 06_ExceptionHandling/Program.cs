namespace _06_ExceptionHandling
{
    internal class Program
    {
        #region Custom Exception
        public class InsufficientBalanceException : Exception
        {
            public InsufficientBalanceException(string message)
                : base(message)
            {
            }
        }
        public class BankAccount
        {
            public decimal Balance { get; set; }

            public void Withdraw(decimal amount)
            {
                if (amount > Balance)
                {
                    throw new InsufficientBalanceException(
                        "You don't have enough balance.");
                }

                Balance -= amount;
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Exception Handling
            /*
             * Exception handling is a mechanism in programming that allows developers to manage and respond to runtime errors 
             * or exceptional conditions that may occur during the execution of a program.
             * 
             *  **=> Error happens => catch it => handle it => continue the program execution**
             *  **=> Exception handling is not preventing errors from occurring, but it provides a structured way to deal with them when they do.**
             *  
             */

            #region try-catch-finally
            /*
             * try: The code that might throw an exception is placed inside the try block.
             * catch: If an exception occurs in the try block, the control is transferred to the catch block. You can have multiple catch blocks to handle different types of exceptions.
             * finally: The code inside the finally block will ALWAYS execute, regardless of whether an exception occurred or not. It's typically used for cleanup activities, like closing files or releasing resources.
             */
            #region Error Handling Example
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]); // This will throw an IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex) // This catch block will handle the specific exception type
            {
                Console.WriteLine($"ERROR---Caught an exception: {ex.Message}");
            }
            catch (Exception ex) // This catch block will handle any other general exceptions=> Exception is the base class for all exceptions
            {
                Console.WriteLine($"ERROR---Caught a general exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("ERROR---This will always execute.");

            }
            #endregion
            Console.WriteLine("---------------------------------------------------");
            #region Without Exception Handling Example
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[0]); 
            }
            catch (IndexOutOfRangeException ex) 
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Caught a general exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("This will always execute.");

            }
            #endregion
            #endregion

            #region throw
            /*
             * throw: Used to signal the occurrence of an exception. It can be used to throw a new exception or re-throw an existing one.
             *        I make the Error happen and I throw it to the caller to handle it.
             */
            Console.WriteLine("========Throw Example:=====");
            int age = -5;
            try
            {
                if (age < 0)
                {
                    throw new ArgumentOutOfRangeException("age", "Age cannot be negative.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }

            #endregion
            #endregion


            #region Custom Exception
            /*
             * Custom Exception: You can create your own exception classes by inheriting from the base Exception class. 
             *                   This allows you to define specific exception types that are meaningful to your application.
             *                   User-defined exceptions can provide more context and clarity about the nature of the error, making it easier to handle specific scenarios in your code.
             * 
             */

            Console.WriteLine("\n========Custom Exception Example:=====");

            BankAccount account = new BankAccount
            {
                Balance = 500
            };

            try
            {
                account.Withdraw(1000);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion
            #region Validation vs Exception Handling
            /*
             * validation: Validation is the process of checking input data against a set of rules or criteria before processing it.
             * Exception handling: Exception handling is the process of responding to runtime errors or exceptional conditions that occur during program execution [during Runtime].
             * 
             * **Validation checks whether input or data satisfies the business and format rules before processing. 
             * **Exception handling deals with unexpected runtime errors that occur during program execution.
             */
            #endregion
        }
    }
    }
