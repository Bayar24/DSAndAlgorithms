using System;
using System.Collections.Generic;
using System.Text;

namespace _02Stack
{
    class StackByQueue
    {
        private Queue<int> queue1;
        
        public StackByQueue()
        {
            queue1 = new Queue<int>();
        }
        public void Push(int val)
        {
            queue1.Enqueue(val);
        }
        public int Pop()
        {
            if (queue1.Count == 0)
                throw new Exception("");
            int qLen = queue1.Count;
            int i = 0;
            
            while (i < qLen-1)
            {
                queue1.Enqueue(queue1.Dequeue());
                i++;
            }
            return queue1.Dequeue();
        }
        public int Peek()
        {
            if (queue1.Count == 0)
                throw new Exception("");
            int qLen = queue1.Count;
            int i = 0;

            while (i < qLen - 1)
            {
                queue1.Enqueue(queue1.Dequeue());
                i++;
            }
            int ret = queue1.Dequeue();
            queue1.Enqueue(ret);
            return ret;
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