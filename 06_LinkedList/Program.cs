namespace _06_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            /*
             *    LinkedList: is  a doubly linked list that allows fast insertion and deletion of elements at any position.   
             *                each element is Node
             *      
             *      10 ↔ 20 ↔ 30 ↔ 40
             *      [Previous Value Next] => Node
             *    
             */
            LinkedList<int> lin = new LinkedList<int>();
            lin.AddLast(1);
            lin.AddFirst(2);
            foreach (var item in lin)
            {
                Console.WriteLine(item); // 2 1

            }
            LinkedListNode<int> node = lin.Find(2);
            lin.AddAfter(node, 5);
            Console.WriteLine("=================");
            foreach (var item in lin)
            {
                Console.WriteLine(item);
            }
            // Benefit for => fast insertion and deletion of elements at any position
            #endregion

        }
    }
}
