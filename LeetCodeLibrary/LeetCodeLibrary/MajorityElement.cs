using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MajorityElement
    {
        public int MajorityElements(int[] nums)
        {
            int candidate = 0; //Presumed majority element
            int count = 0; //strength of our presumption

            foreach (int num in nums)
            {
                if (count == 0)
                {
                    candidate = num; //Set the candidate to the current element
                }
                if (num == candidate)
                {
                    count++; //Incriment the count
                }
                else
                {
                    count--; //Decrement the count
                }
            }
            return candidate; //Returns the majority element
        }
    }
}
