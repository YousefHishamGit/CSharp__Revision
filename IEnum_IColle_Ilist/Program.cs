namespace IEnum_IColle_Ilist
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          * IEnumerable => Parent  [for read only]
          * ICollection => Extend from IEnumerable [for read and modify]
          * IList => Extend from ICollection [For all with Index feature]
          * 
          * 
          */
            List<int> initialNumbers = new List<int> { 10, 20, 30 };


            IEnumerable<int> enumerableNumbers = initialNumbers;
            Console.WriteLine("--- IEnumerable ---");
            
            foreach (var num in enumerableNumbers)
            {
                Console.WriteLine(num);
            }
            //enumerableNumbers.Add(40) =>  error




            ICollection<int> collectionNumbers = initialNumbers;

            
            collectionNumbers.Add(40);
            collectionNumbers.Remove(10);

            Console.WriteLine("\n--- ICollection ---");
            Console.WriteLine($"Count: {collectionNumbers.Count}");
            Console.WriteLine($"Contains 20?: {collectionNumbers.Contains(20)}");

            // collectionNumbers[0] = 99; => Error

            IList<int> listNumbers = initialNumbers;

            
            listNumbers[0] = 99;        
            listNumbers.Insert(1, 50);   
            listNumbers.RemoveAt(0);    

            Console.WriteLine("\n--- IList ---");
            Console.WriteLine($"Element at Index 0: {listNumbers[0]}");

            Console.WriteLine("All Elements in IList:");
            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine($"Index [{i}] = {listNumbers[i]}");
            }

        }
    }
}
