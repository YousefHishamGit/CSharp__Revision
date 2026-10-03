using System.Text;

namespace _01_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Data Types
            ///*
            // * => Data Types
            // * [struct - Class - Enum - interface]
            // * 
            // * struct / Enum => Value Type (primitive Data type)
            // * Class / interface => Reference Type (Non-primitive Data type)
            // * ==================
            // *  Value Type  : data is stored in Stack Memory due to its small size and fast access time.(and we know the size that it need to store  in Compiler time) [فبعرف احجزلها اماكن ]
            // *  ====
            // *  reference Type : data is stored in Heap Memory due to its large size and slower access time.(and we don't know the size that it need to store in Compiler time) 
            // *  =============================
            // *  value type : int - float - double - char - bool..... => are a built in structs  
            // * 
            // * reference type : string - array - class - interface - object => are a built in classes
            // * 
            // * =======================================================

            // */
            //int a = 10; // value type
            //int b = a; // value type
            //b = 20;
            //Console.WriteLine($"a = {a} , b = {b}"); // a = 10 , b = 20
            //                                         // value type => data is stored in Stack Memory
            //                                         // a has it own memory location in stack 
            //                                         // b has it own memory location in stack
            //                                         //any changes in b will not affect a and vise versa
            //double x = 1000.5;
            //double y = x;
            //y = 2000.5;
            //Console.WriteLine($"x = {x} , y = {y}"); // x = 1000.5 , y = 2000.5

            //Console.WriteLine("===========================================================");

            //string name1 = "Ahmed"; // reference type
            //string name2 = name1; // reference type
            //name2 = "Mohamed";
            //Console.WriteLine($"name1 = {name1} , name2 = {name2}"); // name1 = Ahmed , name2 = Mohamed
            //                                                         // reference type => data is stored in Heap Memory
            ///*
            // * string is a reference type but it behaves like a value type because it is immutable (cannot be changed)
            // * what it means by immutable => once the string is created it cannot be changed
            // * Any changes to the string will CREATE A NEW STRING in the heap memory and the reference will point to the new string
            // */
            //Console.WriteLine("===========================================================");

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Hello");
            //StringBuilder stringBuilder2 = stringBuilder;
            //stringBuilder2.Append(" World");
            //Console.WriteLine($"stringBuilder = {stringBuilder} , stringBuilder2 = {stringBuilder2}"); // stringBuilder = Hello World , stringBuilder2 = Hello World
            ///*
            // * string builder is a reference type and it is mutable (can be changed)
            // * act as string but it is mutable [Built-in class]
            // * any changes to the string builder will affect the original string builder
            // * due to they refer to the same memory location in the heap
            // * [يعني هو مكان واحد الاتنين بيغيروا فيه اخر تغير هو الهيفضل]
            // * 
            // */
            //Console.WriteLine("===========================================================");
            //int sz;
            //Console.Write("Enter the size of the array: ");
            //sz = int.Parse(Console.ReadLine());
            //int[]arr = new int[sz]; // reference type
            ///*
            // * here we don't know the size of the array in compile time
            // * depend on user input
            // * then it will be stored in heap memory because heap is larger than stack 
            // * i will sure that i can save space for this array
            // */
            ////string str; => here i just used 4 btes in stack memory to store the reference(Address) of the string object in heap memory
            //Console.WriteLine("===========================================================");
            //object obj1 = 100; // value type
            //object obj2 = obj1; // value type
            //obj2 = 200;
            //Console.WriteLine($"obj1 = {obj1} , obj2 = {obj2}"); // obj1 = 100 , obj2 = 200
            //object[] objArr = new object[3];
            //objArr[0] = 10; // value type
            //objArr[1] = "Hello"; // reference type
            //objArr[2] = 20.5; // value type
            //foreach (var item in objArr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("===========================================================");
            ///*
            // * object is the base class for all data types in C#
            // * can be value type or reference type (by using Boxing and Unboxing) [هنتكلم عليهم بعدين]
            // * 
            // */

            //dynamic d = 100; // value type
            //Console.WriteLine($"d = {d} , Type of d = {d.GetType()}"); // d = 100 , Type of d = System.Int32
            //d = "Hello"; // reference type
            //Console.WriteLine($"d = {d} , Type of d = {d.GetType()}"); // d = Hello , Type of d = System.String
            //Console.WriteLine($"string lenth = {d.Length}"); // string length = 5
            //d = 123;
            ////Console.WriteLine($"string lenth = {d.Length}"); // Runtime Error
            //object o = 100; // value type
            //                //Console.WriteLine($"string lenth = {o.Length}"); // Compile Time Error

            ///*
            // * Dynamic is a data type that can hold any type of data(built-in reference)
            // * dynamic is resolved at runtime not at compile time 
            // * but object is resolved at compile time
            // * that it is the big difference between dynamic and object
            // */


            /*
             * Dynamic AND Var
             * Dynamic => resolved at runtime
             * Var => resolved at compile time and should be initialized
             * Dynamic => can be re-assigned to any type of data
             * Var => cannot be re-assigned to another type of data
             * Dynamic => Based on Last Value Assigned
             * Var => Based on First Value Assigned
             */
            //var v; // Compile Time Error => because var should be initialized
            //dynamic d;// can be initialized or not

            #endregion
            #region Casting
            /*
             *==> What is the casting ?
             * it means that convert one data type to another data type
             *=======
             *there are two types of casting
             *--Implicit Casting (automatically) [smaller to larger]
             *=> safe not risky
             *--Explicit Casting (manually) [larger to smaller]
             *=> risky may cause data loss
             */
            int num = 100;
            double dNum = num; // Implicit Casting (automatically) [smaller to larger]
            Console.WriteLine($"num = {num} , dNum = {dNum}"); // num = 100 , dNum = 100
            //int num2 = dNum; // Compile Time Error
            int num2 = (int)dNum; // Explicit Casting (manually) [larger to smaller]

            dNum = 100.5;
            num2 = (int)dNum;
            //loss data after the decimal point just take the integer part
            Console.WriteLine($"dNum = {dNum} , num2 = {num2}"); // dNum = 100.5 , num2 = 100   
            Console.WriteLine("===========================================================");

            /*
             * Two keywords of safe casting
             * [is | as ]
             * is => to check if the object is of a specific type (check only ) 
             * as => to convert the object to a specific type (check and convert) => if it converted it will return the object else will return null
             * 
             * ====> why safe casting ?
             * because they will not return an exception if the casting is not possible
             */
            object obj = "Hello";
            if (obj is string)
            {
                Console.WriteLine($"obj is string and its value is {obj}");
            }
            else
            {
                Console.WriteLine("obj is not string");
            }
            string str = obj as string;
            if (str != null)
            {
                Console.WriteLine($"obj is string and its value is {str}");
            }
            else
            {
                Console.WriteLine("obj is not string");
            }
            //int n = obj as int; // Compile Time Error => because int is a value type not the casting
            int? n = obj as int?; // Nullable int => that can hold null value if casting is not possible

            if (n != null)
            {
                Console.WriteLine($"obj is int and its value is {n}");
            }
            else
            {
                Console.WriteLine("obj is not int");
            }
            /*
             * is => can work with value type and reference type
             * is when work with value type make boxing to check the type
             * 
             * as => can work with reference type or nullable value type
             * 
             * nullable value type => is a value type that can hold null value
             * ex: int? , double? , bool? ...
             * same as int but can also hold null value
             * AND SOON
             */
            Console.WriteLine("===========================================================");
            #region Boxing and Unboxing
            /*
             * Boxing is implicit casting from value type to reference type
             * Unboxing is explicit casting from reference type to value type
             * ===> Expensive operations (costly in terms of performance Bottlenecks) -> due to Heap (Allocation Overhead), Data Copying , Garbage Collection Pressure , Runtime Type Checking
             * ==> should be avoided as much as possible by using Generics
             */
            int val = 100; // value type
            object objVal = val; // Boxing (Implicit casting) from value type to reference type
            Console.WriteLine($"val = {val} , objVal = {objVal}"); // val = 100 , objVal = 100
            int val2 = (int)objVal; // Unboxing (Explicit casting) from reference type to value type
            Console.WriteLine($"objVal = {objVal} , val2 = {val2}"); // objVal = 100 , val2 = 100

            #endregion
            #region Nullable Types
            /*
             * Nullable Types => is a value type that can hold null value
             * ex: int? , double? , bool? ...
             * same as int but can also hold null value
             * 
             * why we need nullable types ?
             * because sometimes we need to represent the absence of a value
             * ex: in databases, a column may have null values
             * 
             * how to declare a nullable type ?
             * by using ? after the value type
             * 
             * how to check if a nullable type has a value or not ?
             * by using HasValue property or by comparing it to null
             * 
             * how to get the value of a nullable type ?
             * by using Value property or by using the null-coalescing operator (??)
             * 
             */
            string s = null;
            /*
            // there are tow warnigs
            //1- warning CS8600: Converting null literal or possible null value to non-nullable type.
            //2- warning CS8602: Dereference of a possibly null reference.
             frist one => told me that you can't put null in non-nullable data type
             second one => told me that you can't use the variable s because it may be null

            */
            string? s2 = null; // solve the frist warning by using nullable reference type
            //==============================
            //solve second warning by using one of the following methods
            Console.WriteLine($"length of s2 ={s2?.Length}"); // return Null
            // it called null conditional operator (?.) or [null propagation]
            //=> check if s2 is not null then get the length else return null
            Console.WriteLine($"length of s2={s2?.Length ?? 0}"); // return 0
                                                                  // it called null coalescing operator (??)
                                                                  //=> check if s2 is not null then get the length else return 0

            #endregion

            #region take Input from User
            Console.WriteLine("Enter name");
            string? name = Console.ReadLine();
            /*
             * when i take input we takse it as string only
             */
            Console.WriteLine($"name = {name}");
            Console.WriteLine("Enter age");
            int age;
            //3 ways to convert string to int
            age = int.Parse(Console.ReadLine()); // may throw exception if the input is not a valid integer
            age = Convert.ToInt32(Console.ReadLine()); // if the input is null it will return 0
            bool isParsed = int.TryParse(Console.ReadLine(), out age); // if the input is not a valid integer it will return false and result will be 0
            //=> safe way is TryParse
            //As soon as with all data types
            if (isParsed)
            {
                Console.WriteLine($"age = {age}");
            }
            else
            {
                Console.WriteLine("Invalid age input");
            }
            #endregion

            #endregion
            #region Operators
            /*
             * Operators => special symbols that perform operations on operands
             * 
             * Types of Operators
             * 1- Unary Operators =>  ++ -- 
             * 2- Arithmetic Operators => + - * / % ++ --
             * 3- Assignment Operators => = += -= *= /= %=
             * 4- Comparison Operators => == != > < >= <=
             * 5- Logical Operators => && || !
             * 6- Bitwise Operators => & | ^ ~ << >>
             * 7- Other Operators => ?: sizeof typeof checked unchecked
             * 
             */
            //Unary Operators
            int a1 = 10, b1 = 3;
            Console.WriteLine($"a1 = {a1} , b1 = {b1}");
            Console.WriteLine("After using Unary Operators");
            Console.WriteLine($"++a1 = {++a1} , --b1 = {--b1}"); // pre-increment and pre-decrement
            // ++a1 = a1++ => a1 = a1 + 1 
            // --b1 = b1-- => b1 = b1 - 1
            //++a1= a1++ => if only in a single line not in multiple lines (inside many operations)
            // ++a1 => called pre-increment
            // a1++ => called post-increment
            //======================
            //Arithmetic Operators
            int a2 = 10, b2 = 3;
            Console.WriteLine($"a2 = {a2} , b2 = {b2}");
            Console.WriteLine("After using Arithmetic Operators");
            Console.WriteLine($"a2 + b2 = {a2 + b2}"); // Addition
            Console.WriteLine($"a2 - b2 = {a2 - b2}"); // Subtraction
            Console.WriteLine($"a2 * b2 = {a2 * b2}"); // Multiplication
            Console.WriteLine($"a2 / b2 = {a2 / b2}"); // Division
            Console.WriteLine($"a2 % b2 = {a2 % b2}"); // Modulus
            //======================
            //Assignment Operators
            int a3 = 10, b3 = 3;
            Console.WriteLine($"a3 = {a3} , b3 = {b3}");
            Console.WriteLine("After using Assignment Operators");
            a3 += 5; // a3 = a3 + 5 ==> act as two operations (Arithmetic + Assignment)
            // and make the Arithmetic operation first then the assignment operation
            b3 *= 2; // b3 = b3 * 2
            Console.WriteLine($"a3 = {a3} , b3 = {b3}");
            //======================
            //Comparison Operators
            int a4 = 10, b4 = 3;
            Console.WriteLine($"a4 = {a4} , b4 = {b4}");
            Console.WriteLine("After using Comparison Operators");
            Console.WriteLine($"a4 == b4 : {a4 == b4}"); // Equal
            Console.WriteLine($"a4 != b4 : {a4 != b4}"); // Not Equal
            Console.WriteLine($"a4 > b4 : {a4 > b4}"); // Greater Than
            Console.WriteLine($"a4 < b4 : {a4 < b4}"); // Less Than
            Console.WriteLine($"a4 >= b4 : {a4 >= b4}"); // Greater Than or Equal
            Console.WriteLine($"a4 <= b4 : {a4 <= b4}"); // Less Than or Equal
            /*
             * this operators will return a boolean value (true or false)
             */
            //======================
            //Logical Operators
            bool x1 = true, y1 = false;
            Console.WriteLine($"x1 = {x1} , y1 = {y1}");
            Console.WriteLine("After using Logical Operators");
            Console.WriteLine($"x1 && y1 : {x1 && y1}"); // Logical AND
            Console.WriteLine($"x1 || y1 : {x1 || y1}"); // Logical OR
            Console.WriteLine($"!x1 : {!x1}"); // Logical NOT
            /*
             * &&=> true if both operands are true
             * ||=> true if at least one operand is true
             * !=> opposite of the operand [true to false and false to true]]
             */
            //======================
            //Bitwise Operators
            /*
             * works with binary representation of numbers
             */
            int a5 = 5; // 0101 in binary
            int b5 = 3; // 0011 in binary
            Console.WriteLine($"a5 = {a5} , b5 = {b5}");
            Console.WriteLine("After using Bitwise Operators");
            Console.WriteLine($"a5 | b5 = {a5 | b5}"); // 7
            // why 7 => 0101 | 0011 = 0111 => 7 in binary 
            Console.WriteLine($"a5 & b5 = {a5 & b5}"); // 1
            // why 1 => 0101 & 0011 = 0001 => 1 in binary
            Console.WriteLine($"a5 ^ b5 = {a5 ^ b5}"); // 6
            // why 6 => 0101 ^ 0011 = 0110 => 6 in binary  it called XOR two different bits will be 1 else 0
            Console.WriteLine($" ~a5= {~a5}");// -6
            // why -6 => ~0101 = 1010 => -6 in binary it called NOT (invert all bits)[0's to 1's and vise versa]
            Console.WriteLine($"a5 << 1 = {a5 << 1}"); // 10 ==> من الاخر الشمال بيتضاف 0
            // why 10 => 0101 << 1 = 1010 => 10 in binary it called Left Shift (shift all bits to the left and fill the rightmost bit with 0)
            Console.WriteLine($"a5 << 2 = {a5 << 2}"); // 20 ==> من الاخر الشمال بيتضاف 00
            // why 20 => 0101 << 2 = 10100 => 20 in binary it called Left Shift (shift all bits to the left and fill the rightmost bit with 0)
            Console.WriteLine($"a5 >> 1 = {a5 >> 1}"); // 2 ==> من الاخر اليمين بيتضاف 0
            // why 2 => 0101 >> 1 = 0010 => 2 in binary it called Right Shift (shift all bits to the right and fill the leftmost bit with 0)
            //==================================
            //ternary Operators
            int a6 = 10, b6 = 3;
            Console.WriteLine($"a6 = {a6} , b6 = {b6}");
            Console.WriteLine("After using Other/ ternary Operators");
            Console.WriteLine($"a6 == b6 ? 'true' :'false' {(a6 == b6 ? true : false)} ");
            // condition ? value if true : value if false

            #region Operator Precedence
            /*
             * Operator Precedence => the order in which operators are evaluated in an expression
             * 
             * 1- Parentheses ()
             * 2- Unary Operators ++ --
             * 3- Multiplicative Operators * / %
             * 4- Additive Operators + -
             * 5- Comparison Operators == != > < >= <=
             * 6- Logical AND &&
             * 7- Logical OR ||
             * 8- Assignment Operators = += -= *= /= %=
             * 
             * Operators with higher precedence are evaluated before operators with lower precedence
             * Operators with the same precedence are evaluated from left to right
             * 
             */
            #endregion


            #endregion
            #region Control Flow
            #region If
            int x = 10, y = 3;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else if (x < y)
            {
                Console.WriteLine("x is less than y");
            }
            else
            {
                Console.WriteLine("x is equal to y");
            }
            /*
             * if( condition ) => if true go inside the if block else skip it
             * just enter one scope of if chain 
             */

            #endregion
            #region Switch
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Saturday");
                    break;
                case 2:
                    Console.WriteLine("Sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Thursday");
                    break;
                case 7:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
            /*
             * switch (expression)
             * {
             *      case value1:
             *          // code to be executed if expression == value1
             *          break;
             *      case value2:
             *          // code to be executed if expression == value2
             *          break;
             *      ...
             *      default:
             *          // code to be executed if expression doesn't match any case
             *          break;
             * }
             * 
             * switch => used when we have many conditions based on the same variable
             * and each condition has a specific value
             * 
             */
            #region News in Switch Expression
            //switch expression
            day = 5;
            string dayName = day switch
            {
                1 => "Saturday",
                2 => "Sunday",
                3 => "Monday",
                4 => "Tuesday",
                5 => "Wednesday",
                6 => "Thursday",
                7 => "Friday",
                _ => "Invalid day" // default case
            };
            Console.WriteLine(dayName);
            /*
             * switch expression => introduced in C# 8.0
             * more concise and readable than switch statement
             * can be used to return a value based on the expression
             * 
             */
            //Nested switch
            int month = 2;
            int year = 2020;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30 days");
                    break;
                case 2:
                    switch (year % 4)
                    {
                        case 0:
                            Console.WriteLine("29 days");
                            break;
                        default:
                            Console.WriteLine("28 days");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    break;
            }
            /*
             * Nested switch => switch inside another switch
             * used when we have a condition inside another condition
             * 
             */
            #region Pattern Matching in Switch
            object obj2 = 100;
            switch (obj2)
            {
                case int i when i > 0:
                    Console.WriteLine("Positive integer");
                    break;
                case int i when i < 0:
                    Console.WriteLine("Negative integer");
                    break;
                case int i:
                    Console.WriteLine("Zero");
                    break;
                case string sstr:
                    Console.WriteLine("String");
                    break;
                default:
                    Console.WriteLine("Unknown type");
                    break;
            }
            /*
             * Pattern Matching in Switch => introduced in C# 7.0
             * allows to match the type and value of an expression
             * can be used to simplify complex if-else statements
             * 
             */

            #endregion
            #endregion
            #endregion
            #region Loops
            #region For Loop
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"i = {i}");
            }
            #endregion
            #region While Loop
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine($"j = {j}");
                j++;
            }
            // may not enter the loop if the condition is false
            #endregion
            #region Do-While Loop
            int k = 1;
            do
            {
                Console.WriteLine($"k = {k}");
                k++;
            } while (k <= 5);
            // will enter frist then check the condition
            #endregion
            #region Foreach Loop
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (var item in numbers)
            {
                Console.WriteLine($"item = {item}");
            }
            // in foreach loop we can't modify the collection just for iterate
            /*
             * the iteration variable (item) is strictly Read-Only regarding its direct memory slot (the variable itself on the Stack).
             * You cannot reassign or modify item directly, but you can mutate the inner state of the object it points to in the Heap.
             * [من الاخر تخيل انها طبقات اول طبقه ممنوع تعمل اي حاجه شوف بس الطبقات التانيه اللي تحت تقدر تعدل و تمسح و تحط عادي ]
             */
            Console.WriteLine("====================");
            foreach (var item in numbers)
            {
                //item++; // Compile Time Error => because item is read-only but just for direct value
                Console.WriteLine($"item = {item}");
            }
            //====================
            StringBuilder[] stringBuildersArray =
            {
                new StringBuilder("Hello"),
                new StringBuilder("World"),
                new StringBuilder("from"),
                new StringBuilder("C#")
            };
            foreach (var item in stringBuildersArray)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine("====================");
            foreach (var item in stringBuildersArray)
            {
                item.Append("!"); // we can modify the object that the item refer to 
                // but we can't modify the reference itself (direct value)
                Console.WriteLine(item);
            }

            #endregion
            #region Jump Statements
            // break , continue , return , goto
            // we reduced goto as much as possible because it makes the code hard to read and understand [spaghetti code]
            #endregion

            #endregion
            #endregion


        }
    }
}
