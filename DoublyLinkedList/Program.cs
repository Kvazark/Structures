using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Minion minion1 = new Minion("Bob", 21);
            Minion minion2 = new Minion("Tom", 18);
            Minion minion3 = new Minion("Tim", 19);
            
           var list = new DoublyLinkedList<Minion>()
           {
               minion1,
               minion2
           };
           
           list.AddFirst(minion3); 
           list.AddFirst(minion2); 
           list.AddFirst(new Minion("Kevin", 19));
           
           
           Console.WriteLine(list[0].CompareTo(list[2]));
           Console.WriteLine(list[1].CompareTo(list[3]));
           Console.WriteLine(list[4].CompareTo(list[0]));
           Console.WriteLine("");
           
           foreach (var item in list)
           { 
               Console.WriteLine(item);
               
           }
           
           Console.WriteLine("");
           
           var minion = new Stack<string>(); 
           minion.Push("minion"); 
           minion.Push("I am"); 
           minion.Push("Hi,");
           
           LetsIterate(minion); 
           minion.Pop(); 
           Console.WriteLine();
           
           LetsIterate(minion);
        }
        static void LetsIterate<T>(Stack<T> stack)
        {
            foreach (var element in stack)
            {
                Print(element);
            }
        }

        static void Print<T>(T element)
        {
            Console.Write(element+" ");
        }
        
    }
}