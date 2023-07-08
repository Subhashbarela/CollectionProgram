using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CollectionProgrammingPractice
{
    public class LinkedList
    {
        public Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
           // Console.WriteLine("{0} inserted into linklist :", node.data);
        }
        public void AddLast(int last)
        {
            Node LastNode = new Node(last);

            if (this.head == null)
            {
                this.head = LastNode;
                // Console.WriteLine("list is empty ;");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = LastNode;
            }
            //   Console.WriteLine("{0} inserted into linklist :", LastNode.data);
        }        
        internal int InterAtPosition(int pos, int data)
        {
            Node newNode = new Node(data);
            newNode.data = data;
            newNode.next = null;

            if (pos < 1)
            {
                Console.WriteLine("position should be >=1");

            }
            else if (pos == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node temp = new Node(data);
                temp = head;
                for (int i = 0; i < pos - 1; i++)
                {
                    if (temp != null)
                    {
                        newNode.next = temp.next;
                        temp.next = newNode;
                    }
                    else
                    {
                        Console.WriteLine("previous node is null ");
                    }
                }
            }
            return 0;
        }
        public void DeleteFirstElement()
        {
            //Node delete = new Node(head);
            if (this.head != null)
            {
                Node temp = this.head;
                this.head = this.head.next;
                temp = null;
            }
        }
        internal void DeleteLastElement()
        {
            //Node delete = new Node(head);
            if (this.head == null)
            {

                Console.WriteLine("linked list is empty ");
            }
            if (head.next == null)
            {
                head = null;

            }
            Node last = head;
            // Node SecondLast=head
            while (last.next.next != null)
            {
                last = last.next;
            }
            last.next = null;
        }
        internal void display()
        {
            Console.WriteLine("\n............................................\n");
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("the linked list is empty ");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
