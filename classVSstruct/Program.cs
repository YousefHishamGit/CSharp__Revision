namespace classVSstruct
{
    internal class Program
    {
        // 1. Class (Reference Type)
        /*
         * Support inheritance (class or interfaces)
         */
        class PersonClass
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        // 2. Struct (Value Type)
        /*
         * Support only interfaces
         */
        struct PersonStruct
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        //Methods
        static void ModifyClass(PersonClass p)
        {
            p.Age = 99; 
        }


        static void ModifyStruct(PersonStruct p)
        {
            p.Age = 99;
        }

        static void Main(string[] args)
        {
            

            // --- CLASS ---
            var c1 = new PersonClass { Name = "Ali", Age = 20 };
            var c2 = c1; // Here two object has the same reference in heap (Copies Reference)
            c2.Age = 30;  // when i change object2 also object1 will change 
                          // because 2 object alread refere to same address in heap

            Console.WriteLine($"Class  -> c1.Age: {c1.Age} | c2.Age: {c2.Age}"); // two be 30
            

            // --- STRUCT ---
            var s1 = new PersonStruct { Name = "Ali", Age = 20 };
            var s2 = s1; //two objects have thier own Address in stack (Copies Actual Data) 
            s2.Age = 30; // just s2 will change 
                         // because the two objects are independent 

            Console.WriteLine($"Struct -> s1.Age: {s1.Age} | s2.Age: {s2.Age}"); // 20  30
            


            Console.WriteLine("\n--- Passing to Methods ---");

            ModifyClass(c1);// passing reference => i have the address
            Console.WriteLine($"Class After Method  : {c1.Age}");  // 99

            ModifyStruct(s1);// passing value only 
            Console.WriteLine($"Struct After Method : {s1.Age}"); //20


            Console.WriteLine("\n--- nulls ---");

            PersonClass cNull = null; // Class can be store null even if it's not Nullable 
            Console.WriteLine($"Class cNull is null: {cNull == null}");

            // PersonStruct sNull = null; // can't be store null
            PersonStruct? sNullable = null; // Can if it is nullable
            Console.WriteLine($"Nullable Struct is null: {sNullable.HasValue == false}");
        








        }
    }
}
