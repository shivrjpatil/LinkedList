using LinkedListProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class LinkedList
    {
        internal Node head;
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
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
    
      
        internal void AddInReverseOrder(int data)//70,30,56
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }



        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "");
                temp = temp.next;
            }
        }
        internal Node InsertAtParticularPosition(int position, int data)
        {
            Node newestNode = new Node(data);
            if (this.head == null)
            {
                return newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return this.head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            return this.head;

        }
        internal void RemovefirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            this.head = this.head.next;
        }
        internal void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("linkedList is empty");

            }
            if (head.next == null)
            {
                head = null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
        }
        internal int Search(int value)
        {
            Node node = this.head;
            if (node == null)
                return -1;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        internal void Size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("Linlked list is empty");
                return;

            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Length of LinkedList is :-" + " " + count);
        }
        internal void DeleteNodeAtparticularPosition(int position)
        {
            Console.WriteLine("LinkedList is empty");
            return;

            Node temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
                return;

            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            Node next = temp.next.next;
            temp.next = next;
            Size();
        }
    }
}       

    


