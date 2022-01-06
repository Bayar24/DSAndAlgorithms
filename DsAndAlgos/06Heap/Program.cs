using System;

namespace _06Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Binary tree implementation!");
            Heap heap = new Heap(3);
            heap.Insert(21);
            heap.Insert(12);
            heap.Insert(34);
            heap.Insert(3);
            heap.Insert(60);
            heap.Insert(304);
            heap.Insert(15);
            heap.Insert(330);
            heap.Print();
            Console.WriteLine(heap.CheckValid());
        }
    }
}
