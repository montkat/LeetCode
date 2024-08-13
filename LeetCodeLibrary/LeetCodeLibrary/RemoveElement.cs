using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RemoveElement
    {
        public int RemoveElements(int[] nums, int val)
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                //Swap numbers if current number is not equal to val
                if (nums[j] != val)
                {
                    nums[i] = nums[j]; //Index where numbers not equal to val begin
                    i++;
                }
            }
            return i; //New length after removal
        }
    }
}
