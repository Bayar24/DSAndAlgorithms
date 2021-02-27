using System;
using System.Collections.Generic;
using System.Text;

namespace _02Stack
{
    class StackByLList
    {
        private ListNode head;
        int len = 0;
        
        public StackByLList()
        {
            
        }
        public void Push(int val)
        {
            if (head == null)
                head = new ListNode(val);
            else
            {
                ListNode node = head;
                head = new ListNode(val);
                head.Next = node;
            }
            len++;
        }
        public int Pop()
        {
            if (!this.IsEmpty())
            {
                int i = head.Val;
                head = head.Next;
                len--;
                return i;
            }
            else
                throw new Exception("");
        }
        public int Peek()
        {
            if (!this.IsEmpty())
            {
                return head.Val;
            }
            else
                throw new Exception("");
        }
        public bool IsEmpty()
        {
            return head == null;
        }
        public int StackLength()
        {
            return len;
        }
    }
}
