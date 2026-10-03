namespace EqualsVC__
{
    internal class Program
    {
        class t
        {
           public int X;
            public override bool Equals(object? obj)
            {
                // return base.Equals(obj);

                if (obj is t other) // pattern Matching => equals to obj != null && obj is t then Explicit cast to other
                {
                    return X == other.X;
                }

                return false;
            }
        }
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine("S1 == S2 => " + (s1==s2)); // true => because string already override == to compare values
            Console.WriteLine("S1.Equals(S2) => "+s1.Equals(s2)); // true 

            t t1 = new t { X = 5 };
            t t2 = new t { X = 5 };
            Console.WriteLine("t1 == t2 =>  " + (t1 == t2));
            Console.WriteLine("t1.Equals(t2) => " + t1.Equals(t2)); // true => because make override

            // Core Different 
            // ==  check types in compile time
            // .Equals() check in run time

            object o1 = "Hello";
            object o2 = new string(new char[] { 'H', 'e', 'l', 'l', 'o' }); 
            // 2 objects Actually is string data type 
            //But each refere to difference address

            Console.WriteLine("\n--- 2. Object Variables (Compile-time vs Runtime) ---");

           
            Console.WriteLine($"o1 == o2      : {o1 == o2}"); 
            /*
             * will return false why ? we told that string make override and compares values 
             * ====> but == is known the type in compile-time => then it be object which is no override then it compares reference
             */
            Console.WriteLine($"o1.Equals(o2) : {o1.Equals(o2)}");
            /*
             * will return true why ? because it known type in runtime => then it is string type which is compare values
             */
        }
    }
}
