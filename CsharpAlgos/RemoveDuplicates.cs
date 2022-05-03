using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgos
{
    internal class RemoveDuplicates
    {
        private static void Main(string[] args)
        {
            int[] test = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int res = RemoveDuplicate(test);

            for (int i = 0; i < res; i++)
            {
                Console.WriteLine(test[i]);
            }
        }

        public static int RemoveDuplicate(int[] nums)
        {
            int head = 0;

            for (int tail = 0; tail < nums.Length; tail++)
            {
                if (nums[tail] > nums[head])
                {
                    head++;
                    swap(nums, head, tail);
                }
            }

            return head + 1;
        }

        public static void swap(int[] nums, int head, int tail)
        {
            int place = nums[head];
            nums[head] = nums[tail];
            nums[tail] = place;
        }
    }
}


