namespace _03_Functions
{
    internal class Program
    {
        #region Functions
        /*
         * syntax be => public[any access modifier] [static] [void | return type] functionName(){}
         */

        public static void print()
        {
            Console.WriteLine("print function");
        }
        public static void print02(char c)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(c);
            }
            Console.WriteLine("print Function 02");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(c);
            }

        }
        public static int sumfrom1To10()
        {
            int sum = 0;
            for (int i = 1; i < 10; i++) { sum += i; }
            return sum; // return function must return int (due to you choose int type in the syntax of function)
        }
        #region Parameters of function

        #region Value Parameters
        public static void valueParameters(int x)
        {
            x += 10;
            Console.WriteLine($"Inside valueParameters function x = {x}");
        }
        public static int valueParameters02(int x)
        {
            x += 10;
            Console.WriteLine($"Inside valueParameters function x = {x}");
            return x;
        }
        #endregion
        #region Reference Parameters
        public static void referenceParameters(ref int x)
        {
            x += 10;
            Console.WriteLine($"Inside referenceParameters function x = {x}");
        }
        public static int referenceParameters02(ref int x)
        {
            x += 10;
            Console.WriteLine($"Inside referenceParameters function x = {x}");
            return x;
        }

        #endregion
        #region Default Parameters
        public static void defaultParameters(int x = 10, int y = 20)
        {
            Console.WriteLine($"Inside defaultParameters function x = {x} , y = {y}");
        }
        #endregion
        #region Out Parameters
        public static void outParameters(out int x)
        {
            x = 100; // should be initialized inside the function
            x += 10;
            Console.WriteLine($"Inside outParameters function x = {x}");
        }
        #endregion
        #region Params Parameters
        public static void paramsParameters(params int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            Console.WriteLine($"Inside paramsParameters function sum = {sum}");
        }
        public static int paramsParameters02(int fristParameter, params int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            Console.WriteLine($"the frist Parameter {fristParameter}");
            Console.WriteLine($"Inside paramsParameters function sum = {sum}");
            return sum;
        }
        //public static void paramsParameters03( params int[] numbers, int fristParameter) => compiler error
        //{
        //    Console.WriteLine("test");
        //}
        #endregion


        #endregion
        #region Static and non-Static Functions
        /*
         * static methods belong to the class itself and can be called without creating an instance of the class.
         * instatic methods belong to an instance of the class and can only be called on an instance of the class.
         */
        public void nonStaticFunction()
        {
            Console.WriteLine("nonStaticFunction");
        }
        public static void staticFunction()
        {
            Console.WriteLine("staticFunction");
        }
        #endregion
        #endregion

        static void Main(string[] args)
        {
            #region Functions
            /*
             * Function is a code block that make spicific logic
             * => used for readablity and reusability
             * => improve my code => Make maintanice easly 
             * 
             * 
             */
            print();// i (call / invoke) the function
            print02('=');
            //the 2 function is void it means you can't store in any datatype or used inside Console.write()
            //Console.WriteLine(print());//compiler error
            //string func = print02('*');//compiler error
            sumfrom1To10();// the function is work successfully but it doesn't appear any thing => due to it return value should store it or print it
            int resultFun = sumfrom1To10();
            //string resultFunString = sumfrom1To10();// Compiler error -> because the function retun int not string
            Console.WriteLine(sumfrom1To10());
            #region Parameters of Function
            /*
   * Function Parameters 
   *
   * 1. Value Parameters
   *    - Default parameter type
   *    - Pass by value
   *    - A copy of the value is passed
   *
   * 2. ref Parameters
   *    - Pass by reference
   *    - Variable must be initialized before passing
   *    - Function can read and modify the value
   *
   * 3. out Parameters
   *    - Pass by reference
   *    - Variable does NOT need to be initialized before passing
   *    - Function MUST assign a value before returning
   *
   * 4. in Parameters
   *    - Pass by reference
   *    - Read-only inside the function
   *    - Argument must have a value
   *    - Used mainly to avoid copying large value types
   *
   * 5. params Parameters
   *    - Allows a variable number of arguments
   *    - Treated as an array inside the function
   *    - Must be the last parameter
   *
   * 6. Parameter Ordering
   *    - Normally arguments match parameters by position
   *    - Named arguments can be used to specify parameters by name
   */
            #region Value Parameters
            int valParam = 100;
            Console.WriteLine($"Before valueParameters function valParam = {valParam}"); // Before valueParameters function valParam = 100
            valueParameters(valParam); // pass by value => pass a copy of the value inside new Variable x inside the function
            Console.WriteLine($"After valueParameters function valParam = {valParam}"); // After valueParameters function valParam = 100
            Console.WriteLine("====================");
            int valParam2 = 100;
            Console.WriteLine($"Before valueParameters02 function valParam2 = {valParam2}"); // Before valueParameters02 function valParam2 = 100
            valParam2 = valueParameters02(valParam2);
            // here i store the return value of the function inside the same variable
            Console.WriteLine($"After valueParameters02 function valParam = {valParam2}");//After valueParameters02 function valParam2 = 100
                                                                                       //valParam2 will be 110 after the function call due to i store the return value of the function inside the same variable
                                                                                       // but if i didn't store the return value it will be 100

            #endregion
            #region Reference Parameters
            int refParam = 100;
            Console.WriteLine($"Before referenceParameters function refParam = {refParam}"); // Before referenceParameters function refParam = 100
            referenceParameters(ref refParam); // pass by reference => pass the address of the variable => it means that the two varibles refer to the same memory location (same block of memory with 2 difference Name)
            Console.WriteLine($"After referenceParameters function refParam = {refParam}"); // After referenceParameters function refParam = 110
                                                                                            //any changes in x inside the function will affect refParam => because they refer to the same memory location

            #endregion
            #region Default Parameters
            defaultParameters(); // use default values => if i didn't pass any value will use the default values
            Console.WriteLine("====================");
            defaultParameters(30); // use default value for y | but i passed value for x 
            Console.WriteLine("====================");
            defaultParameters(y:50); // use default value for x | but i passed value for y
            /*
             * i used Named Arguments to pass value
             * => it means that i can pass value for any parameter without caring about the order of parameters
             * => but should use the name of the parameter of the Function 
             * ===========================================
             * i just have two ways to pass value for parameters
             * Positional Arguments => should pass value in the same order of parameters
             * Named Arguments => can pass value in any order by using the name of the parameter
             */

            Console.WriteLine("====================");
            defaultParameters(30, 40); // i passed value for x and y | so it will not use the default values



            #endregion
            #region Out Parameters
            /*
             * Produce value to be used outside the function
             * Should be initialized inside the function
             */
            int outParam; // don't need to initialize it
            //Console.WriteLine($"Before outParameters function outParam = {outParam}"); // Compile Time Error => use of unassigned local variable 'outParam'
            outParameters(out outParam); // should use out keyword
            Console.WriteLine($"After outParameters function outParam = {outParam}"); // After outParameters function outParam = 200
            /*
             * the difference between out and ref
             * ref => Must be initialized before passing it to the function (Read Frist)
             * out => don't need to initialize it before passing it to the function (Write Frist)
             * 
             */




            #endregion
            #region Params Parameters
            paramsParameters(1, 2, 3, 4, 5);
            /*
             * the param Must be the last parameter in the function
             * you passing multiple values of the same data type
             * then inside the function be inside the Array of the same data type
             * 
             */
            paramsParameters02(55, 1, 2, 3, 4, 5);
            // the function take the required parameters (frist parameters) then the params parameter
            //thats why the params parameter should be the last parameter in the function


            #endregion

            #endregion

            #region Static vs Instance(Non-static) Function
            //Static Function
            staticFunction(); // can call static function inside static function directly (Main is already static)
            Program.staticFunction(); // can call static function inside static function by using the Class name [But it is not necessary]
            //Instance Function
            Program p = new Program(); // create object from the class to call the instance function
            p.nonStaticFunction(); // call instance function by using the object [Necessary]
                                   //nonStaticFunction(); // Compile Time Error => cannot call instance function inside static function directly [you must create Object]
            #endregion

            #endregion
        }
    }
}
