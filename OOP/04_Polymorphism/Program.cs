namespace _04_Polymorphism
{
    internal class Program
    {
        #region Polymorphism Example
        class Animal
        {
            public virtual void MakeSound()
            {
                // virtual keyword allows derived classes to override this method
                Console.WriteLine("Animal sound");
            }
            public virtual void Eat()
            {
                Console.WriteLine("Eating...");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                //method overriding => same method name with same parameters but different implementation
                Console.WriteLine("Woof");
            }
            public new void Eat()
            {
                //method hiding => same method name with same parameters but different implementation
                // new keyword hides the base class method and provides a new implementation for the derived class
                //reference type of base class will call the base class method and reference type of derived class will call the derived class method
                Console.WriteLine("Dog is Eating....");
            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }

        #region Runtime Polymorphism
        // use virtual and override keywords to achieve runtime polymorphism
        class Employee
        {
            public virtual void CalculateSalary()
            {
                Console.WriteLine("Employee salary");
            }
        }

        class Developer : Employee
        {
            public override void CalculateSalary()
            {
                Console.WriteLine("Developer salary");
            }
        }

        class Manager : Employee
        {
            public override void CalculateSalary()
            {
                Console.WriteLine("Manager salary");
            }
        }

        #endregion

        #region Compile-time Polymorphism
        // Method Overloading
        // use same method name with different parameters to achieve compile-time polymorphism
        // Method be resolved at compile time based on the number and type of arguments passed to the method
        class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }
        #endregion
        #endregion

        static void Main(string[] args)
        {
            #region Polymorphism
            /*
             * Polymorphism is the ability of an object to take many forms.
             * (one interface/reference , Many Forms)
             * 
             * Types of Polymorphism:
             * 1. Compile-Time Polymorphism (Static) => Method Overloading
             *    => Same method name with different parameters
             * 
             * 2. Run-Time Polymorphism (Dynamic) => Method Overriding
             *    => Same method name with same parameters but different implementation
             *    => achieved by using virtual and override keywords
             * 
             */
            Animal animal1 = new Dog(); // Anmal is reference type but Dog is Actual object  => this is called upcasting
            Animal animal2 = new Cat();
            Dog dog = new Dog(); // Dog is reference type and Dog is Actual object  => this is called normal object creation

            animal1.MakeSound(); // Woof
            animal2.MakeSound(); // Meow

            animal1.Eat(); // Eating... => because Eat method is not overridden in Dog class so it will call the base class method
            dog.Eat(); // Dog is Eating.... => because Eat method is hidden in Dog class so it will call the Dog class method
            //====================
            Employee e1 = new Developer();
            Employee e2 = new Manager();

            e1.CalculateSalary();
            e2.CalculateSalary();

            // strength of polymorphism is that we can use the same reference type (Employee) to refer to different object types (Developer, Manager) and call the same method (CalculateSalary) but get different implementations based on the actual object type.
            //if (employee is Developer)
            //{
            //    // developer logic
            //}
            //else if (employee is Manager)
            //{
            //    // manager logic
            //}
            //====================
            Calculator calculator = new Calculator();

            calculator.Add(1, 2);
            calculator.Add(1, 2, 3);
            calculator.Add(1.5, 2.5);
            #endregion
        }
    }
}
