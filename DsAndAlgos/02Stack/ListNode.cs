using System;
using System.Collections.Generic;
using System.Text;

namespace _02Stack
{
    class ListNode
    {
        public int Val { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int val)
        {
            this.Val = val;
            this.Next = null;
        }
    }
    class LinkedList
    {
        private ListNode head;

        public bool IsNull()
        {
            return head == null;
        }

        public void InsertHead(int val)
        {
            ListNode node = new ListNode(val)
            {
                Next = this.head
            };
            this.head = node;
        }
        public void InsertTail(int val)
        {
            ListNode node = head;
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = new ListNode(val);
        }
        public void DeleteHead()
        {
            if (head != null)
            {
                head = head.Next;
            }
        }
        public void DeleteTail()
        {
            if (head == null)
            {
                return;
            }
            if (head.Next == null)
            {
                head = null;
                return;
            }
            ListNode node = head;
            while (node.Next.Next != null)
            {
                node = node.Next;
            }
            node.Next = null;
        }
        public int ListLength()
        {
            int i = 0;
            ListNode node = head;
            while (node != null)
            {
                i++;
                node = node.Next;
            }
            return i;
        }
        public void WriteLog()
        {
            Console.WriteLine();
            ListNode node = head;
            while (node != null)
            {
                Console.Write(" : " + node.Val);
                node = node.Next;
            }
        }
        public ListNode Find (int val)
        {
            ListNode node = head;
            while (node != null)
            {
                if (node.Val == val)
                {
                    return node;
                }
                node = node.Next;
            }
            return null;
        }
        public void Rotate()
        {
            ListNode node = head;
            ListNode last = null;
            while (node != null)
            {
                ListNode tmp = node.Next;
                node.Next = last;
                last = node;
                node = tmp;
            }
            this.head = last;
        }
    }
}
