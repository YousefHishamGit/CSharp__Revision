using System.Drawing;

namespace OOP_revision
{
    internal class Program
    {
        #region Enumeration Example
        enum Days { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };
        /*
         * sat=1 ==> that's mean that i started the sequence from 1
         *       =====> so sun=2, mon=3, tue=4, wed=5, thu=6, fri=7
         */

        #endregion
        #region User Defined Data Types Example
        #region Class
        class Car
        {
            public int id;
            public string model;
            public int speed;
            public int MyProperty { get; set; }
            // Default Constructor
            public Car()
            {
                id = 0;
                model = "No Model";
                speed = 0;
            }
            public Car(int id,string model,int speed)
            {
                this.id = id;
                this.model = model;
                this.speed = speed;

            }
            public void DisplayData()
            {
                Console.WriteLine($"ID: {id}");
                Console.WriteLine($"Model: {model}");
                Console.WriteLine($"Speed: {speed}");
            }
            
        }
        #endregion
        #region Struct
        struct Point
        {
            public int x;
            public int y;
           
            public Point(int x, int y) {
                this.x = x;
                this.y = y;
            }
            public void DisplayPoint()
            {
                Console.WriteLine($"X: {x}");
                Console.WriteLine($"Y: {y}");
            }
        }
        #endregion
        #region Record
        record Person
        {
            public int id;
            public string name;
            public int age;


            public void DisplayPerson() {
                Console.WriteLine($"ID: {id}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
            }
        }
        #endregion
        #endregion
        #region Pillars / Concepts Example
        #region Encapsulation
        class EncapsulationTest {
            private int id;
            private string name;
            //Auto-implemented property
            public int MyProperty01 { get; set; }
            //Read-Only property
            public int MyProperty02 { get; private set; }
            public int MyProperty03 { get;  }
            //Full property
            //used if we want to make logic in get or set
            private int myVar;

            public int MyProperty04
            {
                get { return myVar; }
                set { if (value > 10) { myVar = value; } }
            }


            public void SetId(int id)
            {
                this.id = id;
            }
            public void SetName(string name)
            {
                this.name = name;
            }
            public string GetName()
            {
                return name;
            }
            //public EncapsulationTest this[int index]
            //{
            //    get
            //    {
            //        //return object but should make logic to return the correct object
            //        //can return like obj[index]; => in Main
            //    }
            //    set
            //    {
            //        //set object but should make logic to set the correct object
            //        //then i can set like obj[index] = value; => in Main
            //    }
            //}
            public void DisplayName() {
                Console.WriteLine($"ID: {id}");
                Console.WriteLine($"Name: {name}");
            }




        }
        #endregion
        #region Inheritance
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
        #region Polymorphism  
        #endregion
        #endregion
        static void Main(string[] args)
        {
            #region OOP Concepts
            /*
             * OOP is programming paradigm that uses "objects" to design software.
             *  ==> simulate real world objects in programming  *[ simulation of reality ]*
             *  ( يعني بشوف الحاجه اللي عايز اعملها هي اي في الارض الواقع)
             * 
             * we have 4 main concepts in OOP
             * =====> Encapsulation
             * =====> Inheritance
             * =====> Polymorphism
             * =====> Abstraction
             * 
             * 
             */
            #endregion
            #region Enumeration
            /*
             * Enum is a speicial "class" that represents a group of constants (unchangeable variables).
             * stores Constants values  => underlying Inegral numeric  ( memoryيعني أيًّا كان الهيتخز هو في الاصل رقم في ال  )
             * (like a selector forced user to choose from this values Only)
             * is a Value Type
             * 
             * syntax :
             *         enum EnumName { value1, value2, ..., valueN };
             * 
             */
            //====================================================

            //Days d = Days.Sat;
            //Console.WriteLine(d); // Sat
            //Console.WriteLine((int)d); // 1
            //d = (Days)2; // assign by index => should make casting and be in range
            //Console.WriteLine(d); // Sun
            ////take from user
            //Console.Write("Enter Day Number: ");
            //Days d2= (Days)Convert.ToInt32(Console.ReadLine()); // not safe
            //Console.WriteLine(d2);
            //Console.WriteLine((int)d2);

            //bool isParsed = Enum.TryParse<Days>(Console.ReadLine(), out Days day); // safe (sun => overload case sensitive (sun not same as Sun))
            //if (isParsed)
            //    Console.WriteLine($"Day: {day} - Index: {(int)day}");
            //else
            //    Console.WriteLine("Invalid Day");
            //isParsed = Enum.TryParse<Days>(Console.ReadLine(),true,out day); // safe => overload ignore case (sun same as Sun)
            //if (isParsed)
            //    Console.WriteLine($"Day: {day} - Index: {(int)day}");
            //else
            //    Console.WriteLine("Invalid Day");
            #endregion
            #region User Defined Data Types
            #region Class
            /*
             * Class is a blueprint for creating objects.
             *       =>reference type data type
             * 
             * 
             * 
             * syntax :
             *         class ClassName
             *         {
             *              // members ( attributes + methods )
             *         }
             * 
             * 
             * Object is an instance of a class.
             * 
             * syntax :
             *         ClassName obj = new ClassName();
             * 
             */
            //====================================================


            //Car c01 = new Car();
            //c01.id = 1;
            //c01.model = "BMW";
            //c01.speed = 320;
            //c01.DisplayData();
            //Console.WriteLine("===============");
            //Car c02 = new Car();
            //c02.id = 2;
            //c02.model = "Mercedes";
            //c02.speed = 280;
            //c02.DisplayData();
            //Console.WriteLine("===============");
            //Car c03 = new Car();
            //c03.id = 1;
            //c03.model = "BMW";
            //c03.speed = 320;
            //c03.DisplayData();
            //Console.WriteLine("===============");
            //if (c01 == c03)
            //    Console.WriteLine("Same");
            //else
            //    Console.WriteLine("Not Same");


            /*
             * For each object has it's owen copy of attributes , methods and place in memory
             */


            #endregion
            #region Struct
            /*
             * Struct is a value type data type that can encapsulate data and related functionality.
             * 
             * syntax :
             *         struct StructName
             *         {
             *              // members ( attributes + methods )
             *         }
             *         
             * 
             * 
             * 
             */
            //====================================================
            //Point p1; // struct doesn't need new keyword
            //p1.x = 10;
            //p1.y = 20;
            //p1.DisplayPoint();

            #endregion
            #region Record
            /* 
             *  Same as Class but made for storing data containers
             *  big difference between class and record 
             *  ==>class when compare between 2 objects of the same class it will compare by reference (address in memory)
             *  ==>record when compare between 2 objects of the same record it will compare by value (data inside the object)
             * 
             */
            //====================================================
            //Person p1 = new Person();
            //p1.id = 1;
            //p1.name = "Ahmed";
            //p1.age = 25;
            //p1.DisplayPerson();
            //Console.WriteLine("===============");
            //Person p2 = new Person();
            //p2.id = 1;
            //p2.name = "Ahmed";
            //p2.age = 25;
            //p2.DisplayPerson();
            //Console.WriteLine("===============");
            //if (p1 == p2)
            //    Console.WriteLine("Same");
            //else
            //    Console.WriteLine("Not Same");
            #endregion
            #region Important
            /*
             * Class and Struct 
             * Class is a Reference data type => store in heap 
             *  Car c1 = new Car();
             *  ==> keyword new 
             *       ==> that's mean that compiler will allocate memory in heap for this object and 
             *          return the address of this object and store it in c1 
             *  ==> () 
             *      ==> that's mean that we are calling the constructor of this class
             *          that will initialize the object ( attributes ) with default values of their data types
             *          
             * class can hold all OOP pillars / Concepts
             * 
             * ***** can write inside it 
             *       => Attributes
             *       => Functions ( Methods )
             *       => Properties
             *       => Events
             * ***** Constructors
             *                  it is a special method that is called when an object of the class is created.
             *                  Class has a default constructor ( without parameters ) that initializes the object with default values.
             *                  and when we create a constructor with parameters we must create a default constructor if we want to use it.
             * 
             * 
             */
            // =========================
            //Car c1 = new Car();
            //Console.WriteLine(c1.id);
            //Console.WriteLine(c1.model);
            //Console.WriteLine(c1.speed);


            //===============================================
            //===============================================

            /*
             * Struct is a Value data type => store in stack
             *        same as Class 
             *        and can't hold OOP pillars / Concepts specialy Inheritance 
             * 
             * **** can write inside it as the Class
             * 
             * **** Constructors
             *                  Default Constructor ( without parameters ) is exist also if you make a constructor with parameters
             *                  
             * 
             * 
             *        
             */

            //Point p1 =new Point();
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            //Point p2;
            ////Console.WriteLine(p2.x); // Error => must initialize all attributes before use it
            ////Console.WriteLine(p2.y); // Error => must initialize all attributes before use it
            ////Point p3 = Point(); // Error => must use new keyword with constructor


            #endregion

            #endregion
            #region OOP Pillars / Concepts
            #region Members
            /*
             * Members are the attributes and methods that define the behavior and state of an object.
             * 
             * Attributes ( Properties / Fields ) : are the data that describe the object.
             * 
             * Methods ( Functions ) : are the actions that the object can perform.
             * 
             * ==> Members that defined inside the class or struct or record
             *    1.Fields / Attributes
             *    ==>normal variable that defined inside the class or struct or record
             *    2.Constants
             *    ==> Field that its value can't be changed after initialization
             *    3.Properties
             *    ==> special kind of field that has get and set accessors
             *    ==> has 3 types ( read only , full property , Auto-implemented property )
             *    4.Methods
             *    ==> normal function make specific task/logic
             *    5.Constructors
             *    ==> special method that called when an object of the class is created
             *    6.Events
             *    ==> special kind of delegate that used to notify when something happens
             *    7.Finalizers
             *    ==> special method that called when an object is destroyed 
             *    8.Indexers
             *    ==> special kind of property that allows to access the object like an array
             *    9.Operators
             *    ==> special kind of method that allows to define custom behavior for operators (operator overloading)
             *    10.Nested Types
             *    ==> special kind of type that defined inside another type
             * 
             * 
             */
            #endregion
            #region Accessibility
            /** Accessibility is the ability to control the visibility and accessibility of members of a class or struct.
             * 
             * it is achieved by using access modifiers 
             * 
             * Access Modifiers:
             * 1. Private           => accessible only within the same class or struct
             * 2. Private Protected => accessible within the same class or struct and when derived classes inherit it , it be private in the derived class
             * 3. Protected         => accessible within the same class or struct and when derived classes inherit it AND Be as private in them
             * 4. Internal          => accessible only within the same assembly ( project )
             * 5. Protected Internal=> as private protected but be internal in derived classes 
             * 6. Public            => accessible from anywhere
             *
             * ==> Default Access Modifier is Private
             * 
             * 
             * 
             * 
             */
            #endregion
            #region Encapsulation
            /*
             * Encapsulation is the process of bundling data and methods that operate on that data within a single unit or class.
             * 
             * it is used to hide the internal details of an object from the outside world.
             * 
             * it is achieved by using access modifiers (private , private protected ,protected ,internal ,protected internal , public)
             * 
             * 
             * Benefits:
             * 1. Control Access to Data
             * 2. Maintainability
             * 3. Flexibility and Extensibility
             * 4. Data Hiding
             * 
             * ===> يقدر يوصل لاية userالخلاصة انا البحدد ال 
             * 
             * 
             *  
             * 
             * 
             * 
             */
            //====================================================


            //EncapsulationTest e1 = new EncapsulationTest();
            ////e1.id=1 // error => can't access private member
            //e1.SetId(1);
            ////e1.Name="Ahmed"; // error => can't access private member
            //e1.SetName("Ahmed");
            //e1.DisplayName();
            ////int id = e1.id; // error => can't access private member and there is no getter method
            ////then it can't get id value i forced the use setter only

            //Console.WriteLine("Name: " + e1.GetName());


            #endregion
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
            #region Polymorphism  
            #endregion
            #endregion



        }
    }
}
