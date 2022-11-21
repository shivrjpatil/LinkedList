using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class LinkedListQueue
    {
        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
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
                Console.WriteLine("{0} inserted into queue", node.data);
            
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp== null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            while(temp!=null)
            {
                Console.Write(temp.data + "");
                temp = temp.next;
            }
        }
        internal void Dequeue()
        {
            if (this.head==null)
            {
                Console.WriteLine("Queue is empty,deletion is not possible");
                return ;
            }
            else
            {
                this.head = this.head.next;
                
            }
        }
    }
}
