using System;
using System.Collections.Generic;
using System.Threading;

namespace DoublyLinkedList
{
    public class Minion : IComparable<Minion>
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        private static int count = 0;
        public Minion(string name, int age)
        {
            this.Id = ++count;
            this.Name = name;
            this.Age = age;
        }
        public int CompareTo(Minion other)
        {
            var result = this.Age.CompareTo(other.Age);
            if (result == 0)
            {
                result = this.Name.CompareTo(other.Name);
            }

            return result;
        }
        public override string ToString()
        {
            return $"id: {Id}, {this.Name}  {this.Age}";
        }

    }
}