using System;
using System.Collections.Generic;
using System.Text;

namespace _03Queue
{
    class QueueByStack
    {
        private Stack<int> stack;
        
        public QueueByStack()
        {
            stack = new Stack<int>();
        }
        public void Enqueue(int val)
        {
            stack.Push(val);
        }
        public int Dequeue()
        {
            return DequeueHelper(stack,1);
        }
        private int DequeueHelper(Stack<int> stack, int type)
        {
            if (stack.Count == 0)
                throw new Exception();
            if (stack.Count == 1)
            {
                if(type==1)
                    return stack.Pop();
                else
                    return stack.Peek();
            }
            else
            {
                int val = stack.Pop();
                int k = DequeueHelper(stack, type);
                stack.Push(val);
                return k;
            }
        }
        public int Peek()
        {
            return DequeueHelper(stack, 2);
        }
        public bool IsEmpty()
        {
            return stack.Count == 0;
        }
        public int StackLength()
        {
            return stack.Count;
        }
    }
}