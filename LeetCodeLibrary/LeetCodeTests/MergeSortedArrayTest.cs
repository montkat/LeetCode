using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeTests
{
    [TestFixture]
    public class MergeSortedArrayTests
    {
        private MergeSortedArray _mergeSortedArray;

        [SetUp]
        public void SetUp()
        {
            _mergeSortedArray = new MergeSortedArray();
        }

        [Test]
        public void Test()
        {
            //Arrange
            int[] nums1 = new int[0];
            int[] nums2 = new int[0];

            //Act
            _mergeSortedArray.Merge(nums1, 0, nums2, 0);

            //Assert
            Assert.IsEmpty(nums1);
        }
        [Test]
        public void Test2()
        {
            int[] nums1 = { 1, 3, 5, 0, 0, 0 };
            int[] nums2 = { 2, 4, 6 };

            //Act
            _mergeSortedArray.Merge(nums1, 3, nums2, 3);

            //Assert
            int[] expected = { 1, 2, 3, 4, 5, 6 };
            Assert.AreEqual(expected, nums1);
        }
    }
}