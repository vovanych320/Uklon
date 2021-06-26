using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace Uklon
{
    class Solution0
    {
        public  Solution0(){}

        public int[] SumaDvokhChysel(int[] nums, int target)
        {
            int[] sorted = new int[nums.Length];
            Array.Copy(nums, 0, sorted, 0, nums.Length);
            Array.Sort(sorted);

            int first_index = 0;
            int last_index = nums.Length -1;

            while (first_index != last_index)
            {
                int pointer = sorted[first_index] + sorted[last_index];
                if (pointer < target)
                {
                    first_index++;
                }
                else if (pointer > target)
                {
                    last_index--;
                }
                else if (pointer == target)
                {
                    break;
                }
            }


            int h1 = sorted[first_index];
            int h2 = sorted[last_index];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == h1 )
                {
                    first_index = i;
                }

                if (nums[i] == h2 )
                {
                    last_index = i;
                }
            }

            return new int[] {first_index, last_index};
        }


        public static void TestTask0()
        {
            int[] nums = {1, 3, 5, 198, 12, 9, 98, 19, 6};
            int target = 22;
            Solution0 a = new Solution0();
            Console.WriteLine(a.SumaDvokhChysel(nums, target)[0] + "  " + a.SumaDvokhChysel(nums, target)[1]);

        }
    }
}
