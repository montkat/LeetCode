namespace LeetCodeLibrary
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //Initalize three pointers
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            //Compare the elements at pointers i and j
            while(i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }
            //Repeat this process until all elements from nums2 are placed into nums1
            while(j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }
    }
}
