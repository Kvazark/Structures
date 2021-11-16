using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new DoublyLinkedList<Minion>();
            
            list.AddLast(new Minion("Bob",15));
            list.AddFirst(new Minion("Stuart", 12));
            list.AddFirst(new Minion("Kevin", 19));
            list.AddLast(new Minion("Aboba", 11));
            list.AddFirst(new Minion("Bill", 23));
          

            for (int i=0; i < list.size; i++)
            {
                Console.WriteLine(list[i]);
            }
            
            Console.WriteLine(" ");
            list.Delete(3);
            list.Edit( 1, new Minion("Phil", 23));
           // list.AddFirst(new Minion("Tom", 20));
            for (int i=0; i < list.size; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        
    }
}