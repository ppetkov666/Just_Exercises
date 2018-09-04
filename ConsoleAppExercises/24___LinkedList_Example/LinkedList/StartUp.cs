using System;
using System.Collections.Generic;

namespace LinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            MyList mylist = new MyList(1);
            mylist.AddToEnd(2);
            mylist.AddToEnd(3);
            mylist.AddToEnd(4);
            mylist.AddToEnd(5);
            mylist.Print();
            Console.WriteLine();
            LinkedList<int> mylinked = new LinkedList<int>();
            
        }
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node(int number)
        {
            this.data = number;
            this.next = null;
        }
        public void Print()
        {
            Console.Write($"{data} -> ");
            if (next != null)
            {
                next.Print();
            }
        }
        public void AddToEnd(int number)
        {
            if (next == null)
            {
                next = new Node(number);
            }
            else
            {
                next.AddToEnd(number);
            }
        }
    }
    public class MyList
    {
        public Node head;
        public MyList(int number)
        {
            this.head = new Node(number);
        }
        public void AddToEnd(int number)
        {
            if (head != null)
            {
                head.AddToEnd(number);
            }
            else
            {
                head.AddToEnd(number);
            }
            
        }
        public void Print()
        {
            if (head != null)
            {
                head.Print();
            }
           
        }
    }
}
