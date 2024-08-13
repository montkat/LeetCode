using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeTests
{
    [TestFixture]
    public class RemoveDuplicateSortedArrayTest
    {
        private RemoveDuplicatesSortedArray _removeDuplicateSortedArray;

        [SetUp]
        public void SetUp()
        {
            _removeDuplicateSortedArray = new RemoveDuplicatesSortedArray();
        }

        [Test]
        public void Test()
        {
            //Arrange
            int[] nums = new int[0];

            //Act
            int result = _removeDuplicateSortedArray.RemoveDuplicates(nums);

            //Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test2()
        {
            //Arrange
            int[] nums = { 1, 1, 2, 2, 3, 4, 4, 4, 5 };

            //Act
            int result = _removeDuplicateSortedArray.RemoveDuplicates(nums);

            //Assert
            Assert.AreEqual(5, result);
        }

    }
}
