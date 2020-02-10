using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.AddFirst(7);
            ll.AddFirst(8);
            ll.AddFirst(9);

            ll.AddLast(6);
            ll.AddLast(5);
            ll.AddLast(4);

            int[] arr = ll.ToArray();
            Console.WriteLine

        }
    }
}
