using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public Node<T> head { get; set; }
        public Node<T> tail { get; set; }
        public int size { get; set; }

        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }
        public void Add(T value)
        {
            Node<T> node = new Node<T>(value);
            if (size == 0)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
                tail = node;
            }

            size++;
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            
            if (size == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                if (head.Next == null)
                {
                    head.Next = newNode;
                    tail = newNode;
                    tail.Previous = head;
                }
                else
                {
                    tail.Next = newNode;
                    newNode.Previous = tail;
                    tail = newNode;
                }
            }
            size++;
        }

        public void AddLast(T data)
        {  
            Node<T> newNode = new Node<T>(data);
            
            if (size == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                if (tail.Previous == null)
                {
                    tail.Previous = newNode;
                    head = newNode;
                    head.Next = head;
                }
                else
                {
                    head.Previous = newNode;
                    newNode.Next = head;
                    head = newNode;
                }
            }
            size++;
        }
        public void Delete(int index)
        {
            Node<T> current = head;
            int k = 0;
            while (k < index - 1)
            {
                current = current.Next;
                k++;
            }
            if (k == 0)
            {
                if (head.Next != null)
                {
                    head = head.Next;
                }
                else
                {
                    head = null;
                }
            }
            else if (k == size - 1)
            {
                current.Next = null;
                tail = null;
            }
            else
            {
                current.Next = current.Next.Next;
            }
            size--;
        }
        
        public void Edit(int index,T newData)
        {
            int i = 0;
            Node<T> current = head;
            while (i < index)
            {
                current = current.Next;
                i++;
            }
            current.data = newData;

        }
       
        public void Set(int index, T item)
        {
            if (index < size || index >= size)
            {
                var node = head;
                for (int i = 0; i < index; i++)
                {
                    node = node.Next;
                }

                node.data = item;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public T Get(int index)
        {
            if (index < size)
            {
                var node = head;
                for (int i = 0; i < index; i++)
                {
                    node = node.Next;
                }
                return node.data;
            }

            throw new InvalidOperationException();
        }
        //индексатор
        public T this[int index]
        {
            get
            {
                if (index<0||index>=size)
                {
                    Get(index);
                }

                return Get(index);
            }

            set
            {
                Set(index, value);
            }
        }

        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
 
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.data;
                current = current.Next;
            }
        }
 
        public IEnumerable<T> BackEnumerator()
        {
            Node<T> current = tail;
            while (current != null)
            {
                yield return current.data;
                current = current.Previous;
            }
        }
    }
}