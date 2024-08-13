using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class RemoveDuplicatesSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if(nums.Length ==0)
                return 0; //Returns zero if array is empty

            //Initalize a pointer k to 0 to track the position of the last unique element in the array
            int k = 0;
            //Created a for loop to iterate through the array starting from the second position
            for(int i = 1; i < nums.Length; i++)
            {
                //If the current element is different than the last unique element
                if (nums[i] != nums[k])
                {
                    k++; //Move the pointer k to the next position
                    nums[k] = nums[i]; //Update the element at position k to the current element
                }
            }
            return k + 1; //Return the number of unique elements 
        }
    }
}
