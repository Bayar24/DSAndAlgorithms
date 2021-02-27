using System;
using System.Collections.Generic;
using System.Text;

namespace _02Stack
{
    class StackByArray
    {
        private int[] arr;
        private int top = -1;
        public StackByArray()
        {
            arr = new int[100];
        }
        public void Push(int val)
        {
            if (top == arr.Length - 1)
            {
                int[] tmp = new int[arr.Length * 2];
                for (int i = 0; i < arr.Length; i++)
                {
                    tmp[i] = arr[i];
                }
                arr = tmp;
            }
            arr[++top] = val;
        }
        public int Pop()
        {
            if (!this.IsEmpty())
            {
                return arr[top--];
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
            return top == -1;
        }
        public int StackLength()
        {
            return top + 1;
        }
    }
}
