namespace _05_Keywords
{
    internal class Program
    {
                
        #region Static
        public class MyClass
        {
            public string name { get; set; }
            public static int StaticCount { get; private set; } = 0;
            public MyClass() { StaticCount++; }

            public static void StaticMethod()
            {
                Console.WriteLine("This is a static method.");
            }
        }
        #endregion
        #region Const / Readonly
        public class MyConstReadonlyClass
        {
            public const int MyConstValue = 10; // Compile-time constant
            public readonly int MyReadonlyValue; // Runtime constant
            public MyConstReadonlyClass(int value)
            {
                MyReadonlyValue = value; // Can be set in constructor
            }
            public  void DisplayValues()
            {
                Console.WriteLine($"Const Value: {MyConstValue}");
                 Console.WriteLine($"Readonly Value: {MyReadonlyValue}"); // This line would cause an error because MyReadonlyValue is not static
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Static
            /*
             *  Belongs to the class itself rather than an instance of the class. 
             *  Static members should be accessed using the class name, not through an instance.
             *          => Because a static method belongs to the class and doesn't have a specific object instance (this) to access from members instance.
             *  Static Methods: Can be called on the class itself without creating an instance. They cannot access instance members directly.
             *  
             */
            MyClass myClass1 = new MyClass();
            myClass1.name = "Instance 1";
            MyClass myClass2 = new MyClass();
            myClass2.name = "Instance 2";
            //myClass1.StaticMethod(); // this is not allowed because StaticMethod is a static method and cannot be called on an instance
            MyClass.StaticMethod(); // this is allowed because StaticMethod is a static method and can be called on the class itself
            Console.WriteLine(MyClass.StaticCount); // Output: 2
            #endregion
            #region Const / Readonly
            /*
             *  Const: A compile-time constant. Its value is set at compile time and cannot be changed. Must be initialized at the time of declaration And it is implicitly static..
             *  Readonly: A runtime constant. Its value can be set either at the time of declaration or in a constructor, but cannot be changed afterward IT can be instance-level or static. 
             *  
             *  const => shared across all instances of the class and cannot be changed after compilation.
             *  readonly => can have different values for different instances of the class, but once set (either at declaration or in the constructor), it cannot be changed.
             */
            MyConstReadonlyClass myConstReadonly1 = new MyConstReadonlyClass(20);
            myConstReadonly1.DisplayValues(); // Output: Const Value: 10, Readonly Value: 20
            Console.WriteLine($"Readonly Value from instance 1: {myConstReadonly1.MyReadonlyValue}"); // Output: Readonly Value from instance 1: 20
            Console.WriteLine($"Const Value from instance 1: {MyConstReadonlyClass.MyConstValue}"); // Output: Const Value from instance 1: 10 (implicitly static)
            MyConstReadonlyClass myConstReadonly2 = new MyConstReadonlyClass(30);
            myConstReadonly2.DisplayValues(); // Output: Const Value: 10, Readonly Value: 30
                                              //myConstReadonly2.MyReadonlyValue=40; // This line would cause an error because MyReadonlyValue is readonly and cannot be changed after being set in the constructor

            #endregion
            #region virtual / override / new / abstract 
            /*
             * virtual: A method in a base class that can be overridden in derived classes. It provides a default implementation that can be replaced.
             * override: A method in a derived class that replaces the implementation of a virtual method in the base class. It must have the same signature as the virtual method.
             * abstract: A method or class that is declared but not implemented. Abstract methods must be implemented in derived classes. Abstract classes cannot be instantiated directly.
             * new : A method in a derived class that hides a method in the base class with the same name. It does not override the base method but provides a new implementation. It can be used to hide members of the base class.
             * 
             *  Virtual VS abstract:
             *                      => Virtual methods provide a default implementation that can be overridden, 
             *                      => while abstract methods do not have an implementation and must be implemented in derived classes.
             *                      
             *  override VS new:
             *                   =>  override is used to provide a NEW implementation for a virtual/abstract method in a derived class.
             *                   =>  new is used to hide a member in the base class with a new member in the derived class.
             *                   =>  With override, the method is selected based on the actual object at runtime.
             *                   =>  With new, the method is selected based on the reference type at compile time.
             * 
             */
            #endregion
        }
    }
}
