using System;
using System.Threading;

namespace DoublyLinkedList
{
    public class Minion
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        private static int count = 0;

        public Minion()
        {
            this.Id = ++count;
            this.Name = "name absence";
            this.Age = 1;
        }

        public Minion(string name)
        {
            this.Id = ++count;
            this.Name = name;
            this.Age = 1;
        }
        public Minion(string name, int age)
        {
            this.Id = ++count;
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"id: {Id}, {Name}  {Age}";
        }
    }
}