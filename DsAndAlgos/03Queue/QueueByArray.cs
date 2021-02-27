using System;
using System.Collections.Generic;
using System.Text;

namespace _03Queue
{
    class QueueByArray
    {
        private int[] arr;
        private int top = -1;
        private int bot = -1;
        private int count = 0;
        public QueueByArray()
        {
            arr = new int[3];
            count = 0;
        }

        public void Enqueue(int val)
        {
            if (top == -1)
            {
                top = 0;
            }
            if (count == arr.Length)
            {
                int[] tmp = new int[arr.Length * 2];
                for (int i = 0; i < arr.Length; i++)
                {
                    tmp[i] = arr[(top + i) % arr.Length];
                }
                arr = tmp;
                top = 0;
                bot = count;
            }
            else
                bot = (bot + 1) % arr.Length;
            arr[bot] = val;
            count++;
        }
        public int Dequeue()
        {
            if (!this.IsEmpty())
            {
                int k = arr[top];
                arr[top] = -1;
                top = (top + 1) % arr.Length;
                count--;
                return k;
            }
            else
                throw new Exception("");
        }
        public int Peek()
        {
            if (!this.IsEmpty())
            {
                return arr[top];
            }
            else
                throw new Exception("");
        }
        public bool IsEmpty()
        {
            return count==0;
        }
        public int StackLength()
        {
            return count;
        }
    }
}
