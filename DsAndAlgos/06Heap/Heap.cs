using System;
using System.Collections.Generic;

namespace _06Heap
{
    public class Heap
    {
        private List<int> heap;
        private int capacity = 0;

        public Heap(int k)
        {
            heap = new List<int>();
            capacity = k;
        }


        public void Insert(int value)
        {
            if (capacity == heap.Count)
            {
                if (heap[0] >= value)
                    return;
                else
                {
                    Remove();
                    SiftDown();
                }
            }


            heap.Add(value);
            SiftUp();

            Print();
        }

        private void SiftUp()
        {
            int cur = heap.Count - 1;
            while (cur > 0)
            {
                int parent = (cur - 1) / 2;
                if (heap[parent] > heap[cur])
                {
                    Swap(cur, parent);
                    cur = parent;
                }
                else
                    return;
            }
        }

        private void Swap(int cur, int parent)
        {
            int tmp = heap[cur];
            heap[cur] = heap[parent];
            heap[parent] = tmp;
        }

        public bool CheckValid()
        {
            int ind = heap.Count-1;
            while (ind > 0)
            {
                int parent = (ind - 1) / 2;
                if (heap[ind] < heap[parent])
                {
                    return false;
                }
                else
                {
                    ind--;
                }    
            }
            return true;
        }


        public void Remove()
        {
            Swap(0, heap.Count-1);
            heap.RemoveAt(heap.Count - 1);
            SiftDown();
        }

        private void SiftDown()
        {
            int cur = 0;
            int size = heap.Count;
            int left = cur * 2 + 1;
            while (left < size)
            {
                int? right = null;
                if (left + 1 < size)
                {
                    right = left + 1;
                }
                int ind = left;
                if (right != null && heap[ind] > heap[right.Value])
                {
                    ind = right.Value;
                }
                if (heap[cur] > heap[ind])
                {
                    Swap(cur, ind);
                    cur = ind;
                    left = cur * 2 + 1;
                }
                else
                    return;
            }
        }

        public void Print()
        {
            Console.WriteLine();
            foreach (int i in heap)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
