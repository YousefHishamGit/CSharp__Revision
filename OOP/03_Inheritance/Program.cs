namespace _03_Inheritance
{
    internal class Program
    {
        #region Inheritance Example
        public class Animal
        {
            public string Name { get; set; }
            public void Eat()
            {
                Console.WriteLine("Eating...");
            }
        }
        public class Dog : Animal // Dog is a Animal (inhert relation called is a)
        {
            // Dog can access all public and protected members of Animal class
            public void Bark()
            {
                Console.WriteLine("Barking...");
            }
        }
        //Association Example
        public class Person2
        {
            public string Name { get; set; }
            public void Walk()
            {
                Console.WriteLine("Walking...");
            }
        }
        public class Car2
        {
            public string Model { get; set; }
            public Person2 Driver { get; set; } // Car has a Person (association relation called has a)
            public void Drive()
            {
                Console.WriteLine("Driving...");
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region Inheritance
            /*
             * Inheritance is the process by which one class can inherit the properties and methods of another class.
             * => There is a base class ( parent class / super class ) and a derived class ( child class / sub class )
             * ==> The derived class inherits the members of the base class and can also have its own members.
             */
            //====================================================
            //Dog d01 = new Dog();
            //d01.Name = "Buddy"; // inherited from Animal class
            //d01.Eat(); // inherited from Animal class
            //d01.Bark(); // defined in Dog class
            //=============================
            /*
             * Types of inheritance:
             * => Single Inheritance: A class inherits from one base class.
             * => Multilevel Inheritance: A class inherits from a derived class, which in turn inherits from a base class. (Like Chaining)
             * => Hierarchical Inheritance: Multiple classes inherit from a single base class.
             */

            //======================
            /*
             * Relation between classes:
             * Inheritance => is a "is a" relationship
             * 
             * Association => is a "Uses a" relationship
             * Composition(stronger) & Aggergation  => is a "has a" relationship
             * ==> difference in meaning and your understanding of the relation
             * ==> But in Implementation they are the same=>(use object of class in another class)
             * 
             * 
             */




            //Person2 p1 = new Person2();
            //p1.Name = "Ahmed";
            //p1.Walk();
            //Car2 c1 = new Car2();
            //c1.Model = "BMW";
            //c1.Driver = p1; // association
            //c1.Drive();
            //Console.WriteLine(
            //    $"Car Model: {c1.Model} - Driver Name: {c1.Driver.Name}"
            //    );

            #endregion
        }
    }
}
