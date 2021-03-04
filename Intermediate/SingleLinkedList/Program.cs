using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class Node
    {
        public Node next;
        public string val;

        public Node(string value)
        {
            this.val = value;
            this.next = null;
        }

    }

    public class LinkedList
    {
        public Node tail;
        public Node head;
        public int length;

        public LinkedList()
        {
            this.tail = null;
            this.head = null;
            this.length = 0;
        }

        public void push(string val)
        {
            var node = new Node(val);
            if (this.length == 0)
            {
                this.head = node;
                this.tail = node;
            } else
            {
                this.tail.next = node;
                this.tail = node;
            }
            this.length += 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList();
            list.push("Hey");
            list.push("There");
            Console.WriteLine(list.head.next.val);
        }
    }
}
