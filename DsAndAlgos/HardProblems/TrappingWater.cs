using System;
using System.Collections.Generic;
using System.Text;

namespace HardProblems
{
    public class TrappingWater
    {
        //Бүх элементүүдийн хувьд баруун талын хамгийн их болон зүүн талын хамгийн их элементүүдийг олоод багаас нь өөрийн уртыг хасч
        //тухайн элементийн өндрийг олно.

        public int Trap(int[] height)
        {
            int[] lefts = new int[height.Length];
            int[] rights = new int[height.Length];

            for (int i = 1; i < height.Length; i++)
            {
                if (lefts[i - 1] < height[i - 1])
                {
                    lefts[i] = height[i - 1];
                }
                else
                {
                    lefts[i] = lefts[i - 1];
                }
            }

            for (int i = height.Length - 2; i >= 0; i--)
            {
                if (rights[i + 1] < height[i + 1])
                {
                    rights[i] = height[i + 1];
                }
                else
                {
                    rights[i] = rights[i + 1];
                }
            }
            int size = 0;
            for (int i = 0; i < height.Length; i++)
            {
                size += Math.Max(0, Math.Min(lefts[i], rights[i]) - height[i]);
            }

            return size;
        }

        public int TrapBetter(int[] height)
        {
            int size = 0;
            int left = 0;
            int right = height.Length - 1;
            int maxL = 0;
            int maxR = 0;
            //for every element
            while (left<right)
            {
                //Хэрвээ зүүн элемент нь баруунаасаа бага бол зүүний элемент нь
                //барууныхаас хичнээн томоос үл шалтгаалаад ус хуримтлуулна.
                if (height[left] < height[right])
                {
                    if (height[left] > maxL)
                    {
                        maxL = height[left];
                    }
                    else
                    {
                        size += maxL - height[left];
                    }
                    left++;
                }
                else
                {
                    if (height[right] > maxR)
                    {
                        maxR = height[right];
                    }
                    else
                    {
                        size += maxR - height[right];
                    }
                    right--;
                }
                
            }

            return size;
        }

        public void TestTrap()
        {
            int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Console.WriteLine(Trap(height));
            Console.WriteLine(TrapBetter(height));
        }
    }
}
