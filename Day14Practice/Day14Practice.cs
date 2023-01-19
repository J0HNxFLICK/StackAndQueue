using System.Xml.Linq;

namespace Day14Practice
{

    class QueueNode
    {
        public int data;
        public QueueNode next;
        public QueueNode(int data)
        {
            this.data = data;
            next = null;
        }
    }


    class Queue
    {
        QueueNode head = null;
        public void Enqueue(int data)
        {
            QueueNode qnode = new QueueNode(data);
            if (head == null)
                head = qnode;
            else
            {
                QueueNode temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = qnode;
            }
            Console.WriteLine("{0} inserted into queue ", qnode.data);

        }

        public void Display()
        {
            QueueNode temp = head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }

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

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
            }
            else
            {
                Console.WriteLine("Value popped is {0} ", top.data);
                top = top.next;
            }
        }

        public void Peek()
        {
            if (top == null)
                Console.WriteLine("Stack is empty");
            else
                Console.WriteLine("\n{0} is in the top of the stack ", top.data);
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

            // UC2 Peek and Pop until empty
            st.Peek();
            st.Pop();
            st.Peek();
            st.Pop();
            st.Peek();
            st.Pop();
            st.Peek();

            // UC3 Created Queue 56->30->70
            Queue queue= new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
        }
    }
}