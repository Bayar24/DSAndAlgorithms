using System;
using System.Collections.Generic;
using System.Text;

namespace _03Queue
{
    class QueueByLList
    {
        private ListNode head;
        private ListNode tail;
        int len = 0;
        
        public QueueByLList()
        {
            
        }
        public void Enqueue(int val)
        {
            if (head == null)
            {
                head = new ListNode(val);
                tail = head;
            }
            else
            {
                tail.Next = new ListNode(val);
                tail = tail.Next;
                if (len == 1)
                    head.Next = tail;
            }
            len++;
        }
        public int Dequeue()
        {
            if (!this.IsEmpty())
            {
                int i = head.Val;
                if (len==1)
                    tail = null;
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
