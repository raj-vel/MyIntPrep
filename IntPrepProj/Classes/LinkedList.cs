namespace IntPrepProj.Classes
{
    class LinkedList
    {
    }

    public class Node
    {
        public Node next;
        public object data;

        public Node()
        {

        }

        public Node(object obj)
        {
            next = new Node();
            data = obj;
        }
    }

    public class ListNode
    {
        public ListNode next;
        public int data;

        public ListNode()
        {

        }

        public ListNode(int obj)
        {
            next = new ListNode();
            data = obj;
        }
    }

    public class Node<T>
    {
        public Node<T> next;
        public T data;

        public Node()
        {

        }

        public Node(T obj)
        {
            data = obj;
        }
    }
}
