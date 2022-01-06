using System;

namespace _05BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Binary tree implementation!");
            BST bst = new BST();
            bst.Insert(21);
            bst.Insert(12);
            bst.Insert(34);
            bst.Insert(3);
            bst.Insert(60);
            bst.Insert(304);
            bst.Insert(15);
            bst.Insert(33);
            bst.Print();

            bst.Remove(21);
            bst.Print();

            bst.Remove(60);
            bst.Print();

            bst.Remove(12);
            bst.Print();
        }
    }
}
