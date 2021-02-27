using System;
using System.Collections.Generic;
using System.Text;

namespace _03Queue
{
    class QueueBy2Stacks
    {
        private Stack<int> stack1;
        private Stack<int> stack2;
        public QueueBy2Stacks()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }
        public void Enqueue(int val)
        {
            stack1.Push(val);
            
        }
        public int Dequeue()
        {
            if (!this.IsEmpty())
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0)
                        stack2.Push(stack1.Pop());
                }
                return stack2.Pop();
            }
            else
                throw new Exception();
        }
        public int Peek()
        {
            if (!this.IsEmpty())
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0)
                        stack2.Push(stack1.Pop());
                }
                return stack2.Peek();
            }
            else
                throw new Exception();
        }
        public bool IsEmpty()
        {
            return stack1.Count == 0 && stack2.Count == 0;
        }
        public int StackLength()
        {
            return stack1.Count + stack2.Count;
        }
    }
}