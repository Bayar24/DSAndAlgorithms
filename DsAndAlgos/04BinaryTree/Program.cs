using System;
using System.Collections.Generic;

namespace _04BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Binary tree implementation!");
            BinaryTree bt = new BinaryTree();
            bt.Insert(1);
            bt.Insert(2);
            bt.Insert(3);
            Console.WriteLine("Binary tree " + bt.Search(3).Val);

            int[] nums = new int[] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 };
            int k = 5;
            Dictionary<int, int> hs = new Dictionary<int, int>();
            hs.Add(0, 1);
            int count = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (hs.ContainsKey(sum - k))
                {
                    count += hs[sum - k];
                }
                hs[sum] = hs.ContainsKey(sum) ? hs[sum] + 1 : 1;
            }
            
        }
    }
}
