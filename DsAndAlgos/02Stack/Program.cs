using System;

namespace _02Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Stack with Array!");
            StackByArray stack = new StackByArray();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine("Top: " + stack.Peek());
            Console.WriteLine("Length: " + stack.StackLength());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Top: " + stack.Peek());
            Console.WriteLine("Length: " + stack.StackLength());
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Length: " + stack.StackLength());
            stack.Push(5);
            Console.WriteLine("Top: " + stack.Peek());
            Console.WriteLine("Length: " + stack.StackLength());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Stack with LList!");
            StackByLList stackLL = new StackByLList();
            stackLL.Push(1);
            stackLL.Push(2);
            stackLL.Push(3);
            stackLL.Push(4);
            Console.WriteLine("Top: " + stackLL.Peek());
            Console.WriteLine("Length: " + stackLL.StackLength());
            Console.WriteLine(stackLL.Pop());
            Console.WriteLine(stackLL.Pop());
            Console.WriteLine(stackLL.Pop());
            Console.WriteLine("Top: " + stackLL.Peek());
            Console.WriteLine("Length: " + stackLL.StackLength());
            Console.WriteLine(stackLL.Pop());
            Console.WriteLine("Length: " + stackLL.StackLength());
            stackLL.Push(5);
            Console.WriteLine("Top: " + stackLL.Peek());
            Console.WriteLine("Length: " + stackLL.StackLength());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Stack with Queue!");
            StackByQueue stackQ = new StackByQueue();
            stackQ.Push(1);
            stackQ.Push(2);
            stackQ.Push(3);
            stackQ.Push(4);
            Console.WriteLine("Top: " + stackQ.Peek());
            Console.WriteLine("Length: " + stackQ.StackLength());
            Console.WriteLine(stackQ.Pop());
            Console.WriteLine(stackQ.Pop());
            Console.WriteLine(stackQ.Pop());
            Console.WriteLine("Top: " + stackQ.Peek());
            Console.WriteLine("Length: " + stackQ.StackLength());
            Console.WriteLine(stackQ.Pop());
            Console.WriteLine("Length: " + stackQ.StackLength());
            stackQ.Push(5);
            Console.WriteLine("Top: " + stackQ.Peek());
            Console.WriteLine("Length: " + stackQ.StackLength());


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Stack with 2 Queues!");
            StackBy2Queues stackQQ = new StackBy2Queues();
            stackQQ.Push(1);
            stackQQ.Push(2);
            stackQQ.Push(3);
            stackQQ.Push(4);
            Console.WriteLine("Top: " + stackQQ.Peek());
            Console.WriteLine("Length: " + stackQ.StackLength());
            Console.WriteLine(stackQQ.Pop());
            Console.WriteLine(stackQQ.Pop());
            Console.WriteLine(stackQQ.Pop());
            Console.WriteLine("Top: " + stackQQ.Peek());
            Console.WriteLine("Length: " + stackQQ.StackLength());
            Console.WriteLine(stackQQ.Pop());
            Console.WriteLine("Length: " + stackQQ.StackLength());
            stackQQ.Push(5);
            Console.WriteLine("Top: " + stackQQ.Peek());
            Console.WriteLine("Length: " + stackQQ.StackLength());
        }
    }
}
