using System.Xml.Linq;

namespace Day14Practice
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;

        }
    }

    class Stack
    {
        private Node top = null;

        public void Push(int value)
        {
            Node node = new Node(value);
            if (top == null)
                node.next = null;
            else
                node.next = top;
                top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }

        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
    internal class Day14Practice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack ,Queue , Linked List.");

            Stack st = new Stack();

            //UC1 Created stack of 56->30->70
            st.Push(70);
            st.Push(30);
            st.Push(56);
            st.Display();

        }
    }
}