using System;
using System.Collections.Generic;
using System.Text;

namespace _02Stack
{
    class StackBy2Queues
    {
        private Queue<int> queue1;
        private Queue<int> queue2;
        public StackBy2Queues()
        {
            queue1 = new Queue<int>();
            queue2 = new Queue<int>();
        }
        public void Push(int val)
        {
            queue2.Enqueue(val);
            while (queue1.Count>0)
            {
                queue2.Enqueue(queue1.Dequeue());
            }
            Queue<int> queue = queue1;
            queue1 = queue2;
            queue2 = queue;
        }
        public int Pop()
        {
            return queue1.Dequeue();
        }
        public int Peek()
        {
            return queue1.Peek();
        }
        public bool IsEmpty()
        {
            return queue1.Count == 0;
        }
        public int StackLength()
        {
            return queue1.Count;
        }
    }
}