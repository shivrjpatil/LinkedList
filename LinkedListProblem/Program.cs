using System;
namespace LinkedListProblem
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Linked List operation");
            LinkedListQueue list = new LinkedListQueue();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            // list.Add(5);    
            //list.AddInReverseOrder(1);
            //list.AddInReverseOrder(2);
            //list.AddInReverseOrder(3);
            //int a = list.Search(2);
            // list.DeleteNodeAtparticularPosition( 1 );
            //list.Size();

            //list.Display();
            list.Enqueue(50);
            list.Enqueue(30);
            list.Enqueue(70);
            list.Display();
            list.Dequeue();
            list.Display();
            list.Dequeue();
            list.Display();
            list.Dequeue();

            
        }
    }



}