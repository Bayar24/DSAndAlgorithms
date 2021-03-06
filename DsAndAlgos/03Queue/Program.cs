﻿using System;

namespace _03Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Queue with Array!");
            QueueByArray queue = new QueueByArray();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine("Top: " + queue.Peek());
            Console.WriteLine("Length: " + queue.StackLength());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue()); 
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            Console.WriteLine("Length: " + queue.StackLength());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);
            Console.WriteLine("Length: " + queue.StackLength());
            Console.WriteLine("Top: " + queue.Peek());
            queue.Enqueue(14);
            queue.Enqueue(15);
            queue.Enqueue(16);
            queue.Enqueue(17);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(18);
            queue.Enqueue(19);
            queue.Enqueue(20);
            queue.Enqueue(21);
            Console.WriteLine("Length: " + queue.StackLength());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine("Length: " + queue.StackLength());

            Console.WriteLine("Queue with LList!");
            QueueByLList queueLL = new QueueByLList();
            queueLL.Enqueue(1);
            queueLL.Enqueue(2);
            queueLL.Enqueue(3);
            queueLL.Enqueue(4);
            Console.WriteLine("Top: " + queueLL.Peek());
            Console.WriteLine("Length: " + queueLL.StackLength());
            Console.WriteLine(queueLL.Dequeue());
            Console.WriteLine(queueLL.Dequeue());
            queueLL.Enqueue(5);
            queueLL.Enqueue(6);
            queueLL.Enqueue(7);
            queueLL.Enqueue(8);
            queueLL.Enqueue(9);
            Console.WriteLine("Length: " + queueLL.StackLength());
            Console.WriteLine(queueLL.Dequeue());
            Console.WriteLine(queueLL.Dequeue());
            Console.WriteLine(queueLL.Dequeue());
            queueLL.Enqueue(10);
            queueLL.Enqueue(11);
            queueLL.Enqueue(12);
            queueLL.Enqueue(13);
            Console.WriteLine("Length: " + queueLL.StackLength());
            Console.WriteLine("Top: " + queueLL.Peek());
            queueLL.Enqueue(14);
            queueLL.Enqueue(15);
            queueLL.Enqueue(16);
            queueLL.Enqueue(17);
            Console.WriteLine(queueLL.Dequeue());
            Console.WriteLine(queueLL.Dequeue());
            Console.WriteLine(queueLL.Dequeue());
            queueLL.Enqueue(18);
            queueLL.Enqueue(19);
            queueLL.Enqueue(20);
            queueLL.Enqueue(21);
            Console.WriteLine("Length: " + queueLL.StackLength());
            Console.WriteLine(queueLL.Dequeue());
            Console.WriteLine("Length: " + queueLL.StackLength());

            Console.WriteLine("Queue with a Stack!");
            QueueByStack queueByStack = new QueueByStack();
            queueByStack.Enqueue(1);
            queueByStack.Enqueue(2);
            queueByStack.Enqueue(3);
            queueByStack.Enqueue(4);
            Console.WriteLine("Top: " + queueByStack.Peek());
            Console.WriteLine("Length: " + queueByStack.StackLength());
            Console.WriteLine(queueByStack.Dequeue());
            Console.WriteLine(queueByStack.Dequeue());
            queueByStack.Enqueue(5);
            queueByStack.Enqueue(6);
            queueByStack.Enqueue(7);
            queueByStack.Enqueue(8);
            queueByStack.Enqueue(9);
            Console.WriteLine("Length: " + queueByStack.StackLength());
            Console.WriteLine(queueByStack.Dequeue());
            Console.WriteLine(queueByStack.Dequeue());
            Console.WriteLine(queueByStack.Dequeue());
            queueByStack.Enqueue(10);
            queueByStack.Enqueue(11);
            queueByStack.Enqueue(12);
            queueByStack.Enqueue(13);
            Console.WriteLine("Length: " + queueByStack.StackLength());
            Console.WriteLine("Top: " + queueByStack.Peek());
            queueByStack.Enqueue(14);
            queueByStack.Enqueue(15);
            queueByStack.Enqueue(16);
            queueByStack.Enqueue(17);
            Console.WriteLine(queueByStack.Dequeue());
            Console.WriteLine(queueByStack.Dequeue());
            Console.WriteLine(queueByStack.Dequeue());
            queueByStack.Enqueue(18);
            queueByStack.Enqueue(19);
            queueByStack.Enqueue(20);
            queueByStack.Enqueue(21);
            Console.WriteLine("Length: " + queueByStack.StackLength());
            Console.WriteLine(queueByStack.Dequeue());
            Console.WriteLine("Length: " + queueByStack.StackLength());

            Console.WriteLine("Queue with 2 Stacks!");
            QueueBy2Stacks queue2Stacks = new QueueBy2Stacks();
            queue2Stacks.Enqueue(1);
            queue2Stacks.Enqueue(2);
            queue2Stacks.Enqueue(3);
            queue2Stacks.Enqueue(4);
            Console.WriteLine("Top: " + queue2Stacks.Peek());
            Console.WriteLine("Length: " + queue2Stacks.StackLength());
            Console.WriteLine(queue2Stacks.Dequeue());
            Console.WriteLine(queue2Stacks.Dequeue());
            queue2Stacks.Enqueue(5);
            queue2Stacks.Enqueue(6);
            queue2Stacks.Enqueue(7);
            queue2Stacks.Enqueue(8);
            queue2Stacks.Enqueue(9);
            Console.WriteLine("Length: " + queue2Stacks.StackLength());
            Console.WriteLine(queue2Stacks.Dequeue());
            Console.WriteLine(queue2Stacks.Dequeue());
            Console.WriteLine(queue2Stacks.Dequeue());
            queue2Stacks.Enqueue(10);
            queue2Stacks.Enqueue(11);
            queue2Stacks.Enqueue(12);
            queue2Stacks.Enqueue(13);
            Console.WriteLine("Length: " + queue2Stacks.StackLength());
            Console.WriteLine("Top: " + queue2Stacks.Peek());
            queue2Stacks.Enqueue(14);
            queue2Stacks.Enqueue(15);
            queue2Stacks.Enqueue(16);
            queue2Stacks.Enqueue(17);
            Console.WriteLine(queue2Stacks.Dequeue());
            Console.WriteLine(queue2Stacks.Dequeue());
            Console.WriteLine(queue2Stacks.Dequeue());
            queue2Stacks.Enqueue(18);
            queue2Stacks.Enqueue(19);
            queue2Stacks.Enqueue(20);
            queue2Stacks.Enqueue(21);
            Console.WriteLine("Length: " + queue2Stacks.StackLength());
            Console.WriteLine(queue2Stacks.Dequeue());
            Console.WriteLine("Length: " + queue2Stacks.StackLength());
        }
    }
}
