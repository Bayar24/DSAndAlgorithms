using System;

namespace _01LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Linked List!");
            LinkedList listnode = new LinkedList();
            listnode.InsertHead(3);
            listnode.InsertHead(2);
            listnode.InsertTail(4);
            listnode.InsertTail(5);
            listnode.InsertHead(1);
            listnode.WriteLog();
            Console.WriteLine();
            Console.WriteLine("Length:" + listnode.ListLength());
            listnode.DeleteTail();
            listnode.DeleteTail();
            listnode.WriteLog();
            listnode.DeleteHead();
            listnode.WriteLog();
            Console.WriteLine();
            Console.WriteLine("Length:" + listnode.ListLength());
            ListNode node = listnode.Find(2);
            Console.WriteLine();
            Console.WriteLine("Val:" + node.Val);
            listnode.InsertTail(4);
            listnode.InsertTail(5);
            listnode.InsertHead(1);
            listnode.WriteLog();
            listnode.Rotate();
            listnode.WriteLog();
        }
    }
}
