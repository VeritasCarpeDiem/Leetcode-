using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy.Array
{
    internal class Solution
    {
        public int removeDuplicates(int[] nums)
        { 
            if(nums.Length == 0)
            {
                return 0;
            }

            int i = 0;

            for (int j = 1 ; j < nums.Length ; j++)
            {
                if(nums[i] != nums[j])
                {
                    i++;
                    nums[i]= nums[j];
                }
                
            }

            return i + 1;
        }
    }
}
