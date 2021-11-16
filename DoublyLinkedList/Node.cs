namespace DoublyLinkedList
{
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }
        
        public Node(T data)
        {
            this.data = data;
        }
        
    }
}