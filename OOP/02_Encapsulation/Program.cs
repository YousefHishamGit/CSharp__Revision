namespace _02_Encapsulation
{
    internal class Program
    {
        #region Encapsulation Example
        class EncapsulationTest
        {
            private int id;
            private string name;

            //Auto-implemented property
            public int MyProperty01 { get; set; }
            //=============
            //Read-Only property
            public int MyProperty02 { get; private set; }
            public int MyProperty03 { get; }
            //=============
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
            //Indexer => to access object like array
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
            public void DisplayName()
            {
                Console.WriteLine($"ID: {id}");
                Console.WriteLine($"Name: {name}");
            }
        }
        #endregion

        static void Main(string[] args)
        {
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
             */
            //====================================================


            EncapsulationTest e1 = new EncapsulationTest();
            //e1.id=1 // error => can't access private member
            e1.SetId(1);
            //e1.Name="Ahmed"; // error => can't access private member
            e1.SetName("Ahmed");
            e1.DisplayName();
            //int id = e1.id; // error => can't access private member and there is no getter method
            //then it can't get id value i forced the use setter only

            Console.WriteLine("Name: " + e1.GetName());


            #endregion
        }
    }
}
